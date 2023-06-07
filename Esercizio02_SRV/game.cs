using Esercizio02_SRV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Threading;

namespace Esercizio02_SRV
{
    public partial class game : Form
    {
        public string[] imgFrmSrv = new string[15];
        public string[] msgFrmSrv = new string[2];
        public string[] nomFrmSrv = new string[15];
        public string risp = null;
        public static bool domanda = false, invio = false;
        clsSocket clientSocket;
        clsMessaggio msgByServer;
        public static string msg;
        public bool isServer;
        public string stato = "scelta";
        public static string strDomanda = null;
        public static string strRisposta = null;
        public static string strDomandaServer = null;
        public static bool primaDomanda = true;
        public string strIN;
        public bool finito = false;
        public game()
        {
            InitializeComponent();
        }

        public game(string s, bool server)
        {
            InitializeComponent();
            msgFrmSrv = s.Split('$');
            imgFrmSrv = msgFrmSrv[0].Split('@');
            nomFrmSrv = msgFrmSrv[1].Split('@');
            isServer = server;
            if (server == true)
                lblTurno.Text = "Avversario";
            else
                lblTurno.Text = "Tu";


        }

        Thread t;
        Thread threadClientAscolta;


        private void game_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lstChat.Items.Clear();

            t = new System.Threading.Thread(LoopAsync);
            threadClientAscolta = new System.Threading.Thread(Ascolto);
            t.Start();

            pictureBoxRotonde1.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[0];
            label3.Text = nomFrmSrv[0];
            pictureBoxRotonde2.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[1];
            label4.Text = nomFrmSrv[1];
            pictureBoxRotonde3.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[2];
            label5.Text = nomFrmSrv[2];
            pictureBoxRotonde4.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[3];
            label6.Text = nomFrmSrv[3];
            pictureBoxRotonde5.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[4];
            label7.Text = nomFrmSrv[4];
            pictureBoxRotonde6.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[5];
            label8.Text = nomFrmSrv[5];
            pictureBoxRotonde7.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[6];
            label9.Text = nomFrmSrv[6];
            pictureBoxRotonde8.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[7];
            label10.Text = nomFrmSrv[7];
            pictureBoxRotonde9.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[8];
            label11.Text = nomFrmSrv[8];
            pictureBoxRotonde10.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[9];
            label12.Text = nomFrmSrv[9];
            pictureBoxRotonde11.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[10];
            label13.Text = nomFrmSrv[10];
            pictureBoxRotonde12.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[11];
            label14.Text = nomFrmSrv[11];
            pictureBoxRotonde13.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[12];
            label15.Text = nomFrmSrv[12];
            pictureBoxRotonde14.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[13];
            label16.Text = nomFrmSrv[13];
            pictureBoxRotonde15.ImageLocation = Application.StartupPath + "\\img\\" + imgFrmSrv[14];
            label17.Text = nomFrmSrv[14];

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    control.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                }
            }

        }

        // Questo è il metodo che gestirà l'evento MouseClick per ogni PictureBox
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {

            PictureBox pic = sender as PictureBox;

            if (e.Button == MouseButtons.Right)
            {
                if (stato != "scelta" && ((isServer == true && server.turnoServer == true) || (isServer != true && server.turnoServer != true)))
                {
                    stato = "tentativo";
                    // Gestisco l'invio del tentativo
                    pic.BackColor = Color.Green;
                    if (MessageBox.Show("Vuoi chiedere se è " + nomFrmSrv[Convert.ToInt32(pic.Name.Split('e')[2]) - 1] + "?", "TENTATIVO?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (isServer == true)
                        {
                            if (server.soluzione.Split('|')[0] == nomFrmSrv[Convert.ToInt32(pic.Name.Split('e')[2]) - 1])
                                MessageBox.Show("Hai vinto!!!!!!");
                            else
                                MessageBox.Show("Hai perso, la soluzione era: " + server.soluzione.Split('|')[0]);
                        }
                        else
                        {
                            clientSocket = new clsSocket(false, 8888, client.ipServer);
                            strIN = "*_TRY*@" + nomFrmSrv[Convert.ToInt32(pic.Name.Split('e')[2]) - 1];
                            Ascolto();
                            if (msgByServer.messaggio == nomFrmSrv[Convert.ToInt32(pic.Name.Split('e')[2]) - 1])
                                MessageBox.Show("Hai vinto!!!!!!");
                            else
                                MessageBox.Show("Hai perso, la soluzione era: " + msgByServer.messaggio);
                        }

                        Application.Exit();
                    }

                }


            }
            else if (e.Button == MouseButtons.Left)
            {
                if (stato == "scelta")
                {
                    // Scelta PictureBox
                    fotoScelta.Image = pic.Image;
                    fotoScelta.Visible = true;
                    stato = "";
                    if (isServer == false)
                    {
                        // Istanzio il Client Socket
                        clientSocket = new clsSocket(false, 8888, client.ipServer);
                        // Invio il messaggio al server
                        strIN = new string(pic.Name.Where(char.IsDigit).ToArray());
                        strIN = "*SEND*@scelta@" + (Convert.ToInt32(strIN)).ToString();

                        threadClientAscolta.Start();



                    }
                    else if (server.turnoServer == true && isServer == true)
                    {
                        server.sceltaServer += nomFrmSrv[Convert.ToInt32(pic.Name.Split('e')[2]) - 1];

                    }



                }
                else
                {
                    // Annulla Carte (simula tirarle giù)
                    if (pic.BackColor == Color.LightGray)
                        pic.BackColor = Color.FromArgb(255,93,91); // metto colore rosina al posto SkyBlue
                    else
                        pic.BackColor = Color.LightGray;
                }
            }
        }
        // PULSANTE SI
        private void btnSi_Click(object sender, EventArgs e)
        {
            msg = "SI";
            lstChat.Items.Add("Risposta: " + msg);

            txtMessaggio.Enabled = true;
            btnManda.Enabled = true;
        }

        // PULSANTE NO
        private void btnNo_Click(object sender, EventArgs e)
        {
            msg = "NO";
            lstChat.Items.Add("Risposta: " + msg);

            txtMessaggio.Enabled = true;
            btnManda.Enabled = true;
        }

        private void btnManda_Click(object sender, EventArgs e)
        {

            lstChat.Items.Add("Domanda: " + txtMessaggio.Text);
            bool enable = true;
            abilitaComandi(!enable);
            if (isServer == false)
            {
                threadClientAscolta.Join();
                // Istanzio il Client Socket
                clientSocket = new clsSocket(false, 8888, client.ipServer);

                // Invio il messaggio al server
                if (primaDomanda == true)
                    strIN = "*SEND*@gioco@" + txtMessaggio.Text;
                else
                    strIN = "*SEND*@gioco@" + txtMessaggio.Text + "@" + msg;
                Thread threadQA = new Thread(Ascolto);
                threadQA.Start();
                threadQA.Join();
                primaDomanda = false;
                btnSi.Enabled = true;
                btnNo.Enabled = true;
                string[] vRisposte = msgByServer.messaggio.Split('@');

                lstChat.Items.Add("Risposta: " + vRisposte[0]);
                lstChat.Items.Add("Domanda: " + vRisposte[1]);
            }
            else
            {
                strDomandaServer = txtMessaggio.Text;
                invio = true;
            }
            txtMessaggio.Text = "";
        }


        /* |========================================| */
        /* FUNZIONE DEL THREAD PER L'ASCOLTO DEI DATI */
        /* |========================================| */
        private void Ascolto()
        {
            server.turnoServer = true;
            clientSocket.inviaMsgCLIENT(strIN);

            // Aspetto il Messaggio di Risposta del Server
            msgByServer = clientSocket.clientRicevi();
            server.turnoServer = false;

            // Chiudo Connessione
            clientSocket.Dispose();
            if (stato == "scelta")
                stato = "gioca";
            else if (stato == "gioca")
            {
                string[] vDati = msgByServer.messaggio.Split('@');
                lstChat.Items.Add("Risposta: " + vDati[0]);
                lstChat.Items.Add("Domanda: " + vDati[1]);
            }
        }

        private void abilitaComandi(bool enable)
        {
            btnSi.Enabled = enable;
            btnNo.Enabled = enable;

            txtMessaggio.Enabled = enable;
            btnManda.Enabled = enable;

        }

        // questo metodo viene eseguito in un thread separato
        // e viene eseguito in modo asincrono
        private void LoopAsync()
        {
            while (true)
            {
                // questa chiamata aspetta che il metodo venga completato prima di continuare
                // con l'iterazione successiva del ciclo
                MethodInvoker mi = delegate ()
                {

                    // inserire il codice da eseguire in ogni iterazione del ciclo qui
                    if (server.turnoServer == true && isServer == true)
                    {
                        lblTurno.Text = "Tu";
                        btnSi.Enabled = true;
                        btnNo.Enabled = true;
                    }
                    else if (server.turnoServer == false && isServer == false)
                    {
                        lblTurno.Text = "Tu";
                        if (primaDomanda == true)
                        {
                            btnSi.Enabled = false;
                            btnNo.Enabled = false;
                            btnManda.Enabled = true;
                            txtMessaggio.Enabled = true;
                        }
                        else
                        {
                            btnSi.Enabled = true;
                            btnNo.Enabled = true;
                            btnManda.Enabled = true;
                        }
                    }
                    else if (server.turnoServer == false && isServer == true)
                    {
                        lblTurno.Text = "Avversario";
                    }
                    else if (server.turnoServer == true && isServer == false)
                    {
                        lblTurno.Text = "Avversario";
                    }
                    if (domanda == true)
                    {
                        if (game.strRisposta != null)
                            lstChat.Items.Add("Risposts: " + game.strRisposta);
                        lstChat.Items.Add("Domanda: " + game.strDomanda);
                        domanda = false;
                        game.strRisposta = null;
                    }
                    if (primaDomanda == false && isServer == false && server.turnoServer == false)
                    {
                        btnManda.Enabled = true;
                        btnSi.Enabled = true;
                        btnNo.Enabled = true;
                    }
                    else if (primaDomanda == false && isServer == true && server.turnoServer == false)
                    {
                    }
                    if (server.finale != "")
                    {
                        MessageBox.Show(server.finale);
                        Application.Exit();
                    }
                };
                this.Invoke(mi);

                Thread.Sleep(1000);
            }
        }

        private void pictureBoxRotonde12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRotonde7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRotonde3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRotonde5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRotonde6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRotonde11_Click(object sender, EventArgs e)
        {

        }

        public static string aggiornaGame(string Dom)
        {
            if (game.primaDomanda == false)
            {
                string[] vQA = Dom.Split('@');
                game.strDomanda = vQA[0];
                game.strRisposta = vQA[1];
            }
            else
            {
                game.strDomanda = Dom;

            }
            game.domanda = true;
            while (msg == null) { }
            server.turnoServer = true;
            while (invio == false) { }
            invio = false;
            //lstChat.Items.Add(msg);
            return msg + "@" + strDomandaServer;
        }


    }
}