namespace Munkaido_nyilvantarto_alkalmazas
{
    partial class SzerkesztoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNev = new System.Windows.Forms.TextBox();
            this.dtpSzulDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSzabi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOraszam = new System.Windows.Forms.ComboBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAzonosito = new System.Windows.Forms.TextBox();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.cbAdminE = new System.Windows.Forms.CheckBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSzabi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(12, 80);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(260, 26);
            this.tbNev.TabIndex = 0;
            // 
            // dtpSzulDatum
            // 
            this.dtpSzulDatum.Location = new System.Drawing.Point(12, 301);
            this.dtpSzulDatum.Name = "dtpSzulDatum";
            this.dtpSzulDatum.Size = new System.Drawing.Size(260, 26);
            this.dtpSzulDatum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-mail cím:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dolgozó szerkesztése/új felvétel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Név:";
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(12, 150);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(260, 26);
            this.tbEMail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Születési dátum:";
            // 
            // numSzabi
            // 
            this.numSzabi.Location = new System.Drawing.Point(12, 396);
            this.numSzabi.Name = "numSzabi";
            this.numSzabi.Size = new System.Drawing.Size(260, 26);
            this.numSzabi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kivehető szabadságok száma:";
            // 
            // cbOraszam
            // 
            this.cbOraszam.FormattingEnabled = true;
            this.cbOraszam.Items.AddRange(new object[] {
            "20",
            "40"});
            this.cbOraszam.Location = new System.Drawing.Point(12, 476);
            this.cbOraszam.Name = "cbOraszam";
            this.cbOraszam.Size = new System.Drawing.Size(260, 28);
            this.cbOraszam.TabIndex = 11;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(366, 369);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(232, 53);
            this.btnMentes.TabIndex = 12;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Azonosító:";
            // 
            // tbAzonosito
            // 
            this.tbAzonosito.Enabled = false;
            this.tbAzonosito.Location = new System.Drawing.Point(452, 8);
            this.tbAzonosito.Name = "tbAzonosito";
            this.tbAzonosito.ReadOnly = true;
            this.tbAzonosito.Size = new System.Drawing.Size(146, 26);
            this.tbAzonosito.TabIndex = 14;
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.Location = new System.Drawing.Point(366, 454);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(232, 50);
            this.btnMegsem.TabIndex = 16;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // cbAdminE
            // 
            this.cbAdminE.AutoSize = true;
            this.cbAdminE.Location = new System.Drawing.Point(366, 152);
            this.cbAdminE.Name = "cbAdminE";
            this.cbAdminE.Size = new System.Drawing.Size(89, 24);
            this.cbAdminE.TabIndex = 17;
            this.cbAdminE.Text = "Admin?";
            this.cbAdminE.UseVisualStyleBackColor = true;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(12, 219);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '*';
            this.tbJelszo.Size = new System.Drawing.Size(260, 26);
            this.tbJelszo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Jelszó:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Heti óraszám:";
            // 
            // SzerkesztoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.cbAdminE);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.tbAzonosito);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.cbOraszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSzabi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSzulDatum);
            this.Controls.Add(this.tbNev);
            this.Name = "SzerkesztoForm";
            this.Text = "SzerkesztoForm";
            ((System.ComponentModel.ISupportInitialize)(this.numSzabi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.DateTimePicker dtpSzulDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSzabi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOraszam;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAzonosito;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.CheckBox cbAdminE;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}