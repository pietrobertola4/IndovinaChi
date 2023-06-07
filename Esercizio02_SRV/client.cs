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
using Esercizio02_SRV;

namespace Esercizio02_SRV
{
    public partial class client : Form
    {

        static public IPAddress ipServer;
        static clsSocket clientSocket;
        static public clsMessaggio msgByServer;


        string pathFileTXT = string.Empty;

        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            cmbPorta.SelectedIndex = 1;

            
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            bool esito = false;

            if (txtIndirizzoIP.Text == String.Empty)
            {
                MessageBox.Show("Indirizzo IP non VALIDO!");
                txtIndirizzoIP.Focus();
            }
            else
            {
                try
                {
                    ipServer = clsAddress.cercaIP(txtIndirizzoIP.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Indirizzo IP non valido : " + ex.Message);
                    txtIndirizzoIP.Focus();
                    ipServer = null;
                }

                if (ipServer != null)
                {
                    //Provo a connettermi al server
                    this.Cursor = Cursors.WaitCursor;

                    try
                    {
                        inviaDatiServer("*TEST*");
                        esito = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ATTENZIONE: " + ex.Message);
                    }

                    this.Cursor = Cursors.Default;

                    if (esito)
                    {
                        txtIndirizzoIP.Enabled = false;
                        cmbPorta.Enabled = false;
                        btnConnetti.Enabled = false;
                        game form = new game(msgByServer.messaggio, false);
                        form.ShowDialog();
                        this.WindowState = FormWindowState.Minimized;
                    }
                }
            }

            
               
        }

        private void inviaDatiServer(string strIN)
        {
            // Istanzio il Client Socket
            clientSocket = new clsSocket(false, Convert.ToInt16(cmbPorta.Text), ipServer);

            // Invio il messaggio al server
            clientSocket.inviaMsgCLIENT(strIN);

            // Aspetto il Messaggio di Risposta del Server
            msgByServer = clientSocket.clientRicevi();

            //Aggiungo alla lista la risposta del Server

            // Chiudo il socket
            clientSocket.Dispose();
        }

        private void txtIndirizzoIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIndirizzoIP_Click(object sender, EventArgs e)
        {
            txtIndirizzoIP.Text = "";
        }
    }
}