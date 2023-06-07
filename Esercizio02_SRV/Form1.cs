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

namespace Esercizio02_SRV
{
    

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnFaq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClient.BackgroundImage")));
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(347, 478);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(249, 89);
            this.btnClient.TabIndex = 0;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.Transparent;
            this.btnServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServer.BackgroundImage")));
            this.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServer.FlatAppearance.BorderSize = 0;
            this.btnServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.Location = new System.Drawing.Point(197, 388);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(564, 84);
            this.btnServer.TabIndex = 1;
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnFaq
            // 
            this.btnFaq.BackColor = System.Drawing.Color.Transparent;
            this.btnFaq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaq.BackgroundImage")));
            this.btnFaq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFaq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaq.FlatAppearance.BorderSize = 0;
            this.btnFaq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFaq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaq.ForeColor = System.Drawing.Color.White;
            this.btnFaq.Location = new System.Drawing.Point(12, 517);
            this.btnFaq.Name = "btnFaq";
            this.btnFaq.Size = new System.Drawing.Size(82, 53);
            this.btnFaq.TabIndex = 2;
            this.btnFaq.UseVisualStyleBackColor = false;
            this.btnFaq.Click += new System.EventHandler(this.btnFaq_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 582);
            this.Controls.Add(this.btnFaq);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            client form = new client();
            form.ShowDialog();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            server form = new server();
            form.ShowDialog();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFaq_Click(object sender, EventArgs e)
        {
            Istruzioni form = new Istruzioni();
            form.ShowDialog();
        }
    }
}
