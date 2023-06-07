using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

using System.IO;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace Esercizio02_SRV
{
    public delegate void aggiornaGraficaEventHandler(clsMessaggio Msg);

    public partial class server : Form
    {

        private clsSocket serverSocket;
        int cont = 0;
        string[] vFiles = new string[99]; // MAX 99 Files
        private string pathFiles;
        string[] name = { "Avery", "Charlie", "Eli", "Finley", "Gray",
    "Harper", "Indigo", "Jordan", "Kai", "Leo",
    "Maddox", "Navy", "Olive", "Parker", "Quinn",
    "River", "Sage", "Tate", "Umber", "Violet",
    "Wren", "Xander", "Yara", "Zion", "Aiden",
    "Brayden", "Caden", "Dakota", "Emmett", "Finn",
    "Gage", "Hudson", "Indy", "Jax", "Koda",
    "Leighton", "Maxwell", "Nash", "Oakley", "Paxton",
    "Quincy", "Rhett", "Sawyer", "Tanner", "Uriah",
    "Vincent", "Wyatt", "Alex", "Yael", "Zayden"};

        public static bool turnoServer = false, guess1 = false, guess2 = false;
        public static string soluzione = "";
        public static string finale = "";
        public bool sort = false;
        string[] vImg = new string[15];
        string[] vNomi = new string[15];
        string card;
        public static string sceltaServer = null;

        public server()
        {
            InitializeComponent();
        }

        private void server_Load(object sender, EventArgs e)
        {


            int I;

            clsAddress.cercaIP();
            lstIndirizziIP.DataSource = clsAddress.ipVett;
            lstIndirizziIP.SelectedIndex = 1;

            cmbPorta.SelectedIndex = 1;

            lblStatoServer.Text = "STOPPED";

            pathFiles = Application.StartupPath + "\\FtpFiles\\";

            for (I = 0; I < vFiles.Length; I++)
                vFiles[I] = null;

        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            bool errore = false;

            try
            {
                if (serverSocket == null)
                {
                    // Creo l'IP su cui attivare il Server
                    ip = clsAddress.ipVett[lstIndirizziIP.SelectedIndex];

                    // Creo il Server Socket
                    serverSocket = new clsSocket(true, Convert.ToInt32(cmbPorta.Text), ip);

                    // Aggiungo l'Evento datiRicevuti
                    serverSocket.datiRicevutiEvent += new datiRicevutiEventHandler(datiRicevuti);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ATTENZIONE: " + ex.Message);
                errore = true;
            }

            if (!errore)
            {
                // Avvio del Socket
                serverSocket.avviaServer();

                lstIndirizziIP.Enabled = false;
                cmbPorta.Enabled = false;
                btnAvvia.Enabled = false;
                btnArresta.Enabled = true;
                grpLog.Enabled = true;

                lblStatoServer.Text = "RUNNING";
                lblStatoServer.ForeColor = Color.Green;
                name = name.OrderBy(x => Guid.NewGuid()).ToArray();
                Random rnd = new Random();
                if (sort == false)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        vImg[i] = loadCard(rnd);
                        card += vImg[i] + "@";
                    }
                    card += "$";

                    for (int i = 0; i < 15; i++)
                    {
                        if (i == 14)
                        {
                            vNomi[i] = name[i];
                            card += vNomi[i];
                        }
                        vNomi[i] = name[i];
                        card += vNomi[i] + "@";
                    }
                    sort = true;
                }
                game form = new game(card, true);
                form.ShowDialog();
                this.WindowState = FormWindowState.Minimized;
            }

        }
        private void btnArresta_Click(object sender, EventArgs e)
        {
            // Arresto il Socket
            serverSocket.arrestaServer();

            lstIndirizziIP.Enabled = true;
            cmbPorta.Enabled = true;
            btnAvvia.Enabled = true;
            btnArresta.Enabled = false;
            grpLog.Enabled = false;

            lblStatoServer.Text = "STOPPED";
            lblStatoServer.ForeColor = Color.Red;
        }

        private void server_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se il Socket Server è attivo => lo chido
            if (serverSocket != null)
                serverSocket.Dispose();

        }

        private void datiRicevuti(clsMessaggio Msg)
        {

            string tipoRQ;
            string[] vDati;



            tipoRQ = Msg.messaggio.Substring(0, 6);

            switch (tipoRQ)
            {
                case "*TEST*":

                    Msg.esito = "*CONNESSO";

                    Msg.card = card;
                    serverSocket.inviaMsgSERVER(Msg.card);

                    break;

                case "*SEND*":
                    // Gestisco i Dati ricevuti dal Client
                    vDati = Msg.messaggio.Split('@');
                    switch (vDati[1])
                    {
                        case "scelta":
                            turnoServer = true;
                            soluzione += vNomi[Convert.ToInt32(vDati[2])-1] + "|";
                            while (sceltaServer == null) { }
                            soluzione += sceltaServer;
                            Msg.esito = "ok";
                            serverSocket.inviaMsgSERVER(Msg.esito);
                            turnoServer = false;
                            //MessageBox.Show(soluzione);

                            break;
                        case "gioco":
                            turnoServer = true;
                            if (game.primaDomanda == true)
                            {
                                Msg.esito = game.aggiornaGame(vDati[2]);
                                game.primaDomanda = false;
                            }
                            else
                                Msg.esito = game.aggiornaGame(vDati[2] + "@" + vDati[3]);

                            serverSocket.inviaMsgSERVER(Msg.esito);
                            turnoServer = false;
                            break;
                    }

                    break;

                case "*_TRY*":
                    Msg.esito = soluzione.Split('|')[1];
                    serverSocket.inviaMsgSERVER(Msg.esito);
                    if (soluzione.Split('|')[1] == Msg.messaggio.Split('@')[1])
                        finale = "Hai perso!!!\nL'avversario ha indovinato!";
                    else
                        finale = "Hai vinto!!!\nL'avversario ha pensato che fosse" + Msg.messaggio.Split('@')[1] + "!";
                    break;

                case "*_END*":
                    Msg.esito = "*RSP*@Fine File";

                    break;

                default:
                    Msg.esito = "ERR_TXRQ*";
                    break;
            }

            // Invio la Risposta (Messaggio) al Client
            //serverSocket.inviaMsgSERVER(Msg.esito);

            // Visualizzo il Messaggio ricevuto dal Client nella Lista LOG
            aggiornaGraficaEventHandler pt = new aggiornaGraficaEventHandler(aggiornaGrafica);
            this.Invoke(pt, Msg);
        }



        private void aggiornaGrafica(clsMessaggio Msg)
        {
            lstLOG.Items.Add(Msg.ToString());
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            lstLOG.Items.Clear();
        }

        private string loadCard(Random rnd)
        {
            string str = "";

            DirectoryInfo d = new DirectoryInfo(Application.StartupPath + "\\img");

            FileInfo[] Files = d.GetFiles("*.png");

            str = Files[rnd.Next(Files.Length)].Name.Split('.')[0] + ".png";

            return str;
        }

    }
}