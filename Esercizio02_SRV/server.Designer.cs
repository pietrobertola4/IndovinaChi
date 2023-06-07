namespace Esercizio02_SRV
{
    partial class server
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(server));
            this.btnArresta = new System.Windows.Forms.Button();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.lblStatoServer = new System.Windows.Forms.Label();
            this.cmbPorta = new System.Windows.Forms.ComboBox();
            this.lstIndirizziIP = new System.Windows.Forms.ListBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.lstLOG = new System.Windows.Forms.ListBox();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArresta
            // 
            this.btnArresta.BackColor = System.Drawing.Color.Transparent;
            this.btnArresta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArresta.BackgroundImage")));
            this.btnArresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArresta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArresta.Enabled = false;
            this.btnArresta.FlatAppearance.BorderSize = 0;
            this.btnArresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnArresta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnArresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArresta.ForeColor = System.Drawing.Color.White;
            this.btnArresta.Location = new System.Drawing.Point(916, 178);
            this.btnArresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArresta.Name = "btnArresta";
            this.btnArresta.Size = new System.Drawing.Size(273, 119);
            this.btnArresta.TabIndex = 7;
            this.btnArresta.UseVisualStyleBackColor = false;
            this.btnArresta.Click += new System.EventHandler(this.btnArresta_Click);
            // 
            // btnAvvia
            // 
            this.btnAvvia.BackColor = System.Drawing.Color.Transparent;
            this.btnAvvia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAvvia.BackgroundImage")));
            this.btnAvvia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvvia.FlatAppearance.BorderSize = 0;
            this.btnAvvia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAvvia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAvvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvvia.ForeColor = System.Drawing.Color.White;
            this.btnAvvia.Location = new System.Drawing.Point(627, 188);
            this.btnAvvia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(223, 99);
            this.btnAvvia.TabIndex = 6;
            this.btnAvvia.UseVisualStyleBackColor = false;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // lblStatoServer
            // 
            this.lblStatoServer.AutoSize = true;
            this.lblStatoServer.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatoServer.ForeColor = System.Drawing.Color.Red;
            this.lblStatoServer.Location = new System.Drawing.Point(300, 285);
            this.lblStatoServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatoServer.Name = "lblStatoServer";
            this.lblStatoServer.Size = new System.Drawing.Size(0, 34);
            this.lblStatoServer.TabIndex = 5;
            // 
            // cmbPorta
            // 
            this.cmbPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(91)))));
            this.cmbPorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPorta.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorta.ForeColor = System.Drawing.Color.White;
            this.cmbPorta.FormattingEnabled = true;
            this.cmbPorta.Items.AddRange(new object[] {
            "8080",
            "8888",
            "9090",
            "9999"});
            this.cmbPorta.Location = new System.Drawing.Point(305, 226);
            this.cmbPorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPorta.Name = "cmbPorta";
            this.cmbPorta.Size = new System.Drawing.Size(121, 42);
            this.cmbPorta.TabIndex = 3;
            // 
            // lstIndirizziIP
            // 
            this.lstIndirizziIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(91)))));
            this.lstIndirizziIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstIndirizziIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstIndirizziIP.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIndirizziIP.ForeColor = System.Drawing.Color.White;
            this.lstIndirizziIP.FormattingEnabled = true;
            this.lstIndirizziIP.ItemHeight = 34;
            this.lstIndirizziIP.Location = new System.Drawing.Point(40, 200);
            this.lstIndirizziIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstIndirizziIP.Name = "lstIndirizziIP";
            this.lstIndirizziIP.Size = new System.Drawing.Size(197, 102);
            this.lstIndirizziIP.TabIndex = 1;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.lstLOG);
            this.grpLog.Controls.Add(this.btnPulisci);
            this.grpLog.Enabled = false;
            this.grpLog.ForeColor = System.Drawing.Color.White;
            this.grpLog.Location = new System.Drawing.Point(23, 324);
            this.grpLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLog.Name = "grpLog";
            this.grpLog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLog.Size = new System.Drawing.Size(1196, 335);
            this.grpLog.TabIndex = 1;
            this.grpLog.TabStop = false;
            // 
            // lstLOG
            // 
            this.lstLOG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(91)))));
            this.lstLOG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLOG.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLOG.ForeColor = System.Drawing.Color.White;
            this.lstLOG.FormattingEnabled = true;
            this.lstLOG.ItemHeight = 34;
            this.lstLOG.Location = new System.Drawing.Point(10, 71);
            this.lstLOG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLOG.Name = "lstLOG";
            this.lstLOG.ScrollAlwaysVisible = true;
            this.lstLOG.Size = new System.Drawing.Size(1156, 238);
            this.lstLOG.TabIndex = 1;
            // 
            // btnPulisci
            // 
            this.btnPulisci.BackColor = System.Drawing.Color.Transparent;
            this.btnPulisci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPulisci.BackgroundImage")));
            this.btnPulisci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPulisci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPulisci.FlatAppearance.BorderSize = 0;
            this.btnPulisci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPulisci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPulisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPulisci.ForeColor = System.Drawing.Color.White;
            this.btnPulisci.Location = new System.Drawing.Point(1042, 30);
            this.btnPulisci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(124, 30);
            this.btnPulisci.TabIndex = 0;
            this.btnPulisci.UseVisualStyleBackColor = false;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(303, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1242, 867);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnArresta);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.lblStatoServer);
            this.Controls.Add(this.cmbPorta);
            this.Controls.Add(this.lstIndirizziIP);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.server_FormClosing);
            this.Load += new System.EventHandler(this.server_Load);
            this.grpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnArresta;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Label lblStatoServer;
        private System.Windows.Forms.ComboBox cmbPorta;
        private System.Windows.Forms.ListBox lstIndirizziIP;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.ListBox lstLOG;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
