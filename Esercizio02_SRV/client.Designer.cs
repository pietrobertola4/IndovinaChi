namespace Esercizio02_SRV
{
    partial class client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));
            this.txtIndirizzoIP = new System.Windows.Forms.TextBox();
            this.cmbPorta = new System.Windows.Forms.ComboBox();
            this.btnConnetti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndirizzoIP
            // 
            this.txtIndirizzoIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(91)))));
            this.txtIndirizzoIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIndirizzoIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIndirizzoIP.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndirizzoIP.ForeColor = System.Drawing.Color.White;
            this.txtIndirizzoIP.Location = new System.Drawing.Point(246, 155);
            this.txtIndirizzoIP.Name = "txtIndirizzoIP";
            this.txtIndirizzoIP.Size = new System.Drawing.Size(343, 41);
            this.txtIndirizzoIP.TabIndex = 5;
            this.txtIndirizzoIP.Text = "xxx.xxx.xxx.xxx";
            this.txtIndirizzoIP.Click += new System.EventHandler(this.txtIndirizzoIP_Click);
            this.txtIndirizzoIP.TextChanged += new System.EventHandler(this.txtIndirizzoIP_TextChanged);
            // 
            // cmbPorta
            // 
            this.cmbPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(91)))));
            this.cmbPorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPorta.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorta.ForeColor = System.Drawing.Color.White;
            this.cmbPorta.FormattingEnabled = true;
            this.cmbPorta.Items.AddRange(new object[] {
            "8080\t",
            "8888",
            "9090",
            "9999"});
            this.cmbPorta.Location = new System.Drawing.Point(246, 294);
            this.cmbPorta.Name = "cmbPorta";
            this.cmbPorta.Size = new System.Drawing.Size(288, 47);
            this.cmbPorta.TabIndex = 4;
            // 
            // btnConnetti
            // 
            this.btnConnetti.BackColor = System.Drawing.Color.Transparent;
            this.btnConnetti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnetti.BackgroundImage")));
            this.btnConnetti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnetti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnetti.FlatAppearance.BorderSize = 0;
            this.btnConnetti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConnetti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConnetti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnetti.Location = new System.Drawing.Point(336, 395);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(188, 51);
            this.btnConnetti.TabIndex = 2;
            this.btnConnetti.UseVisualStyleBackColor = false;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 160);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(65, 294);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(852, 464);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIndirizzoIP);
            this.Controls.Add(this.cmbPorta);
            this.Controls.Add(this.btnConnetti);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIndirizzoIP;
        private System.Windows.Forms.ComboBox cmbPorta;
        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}