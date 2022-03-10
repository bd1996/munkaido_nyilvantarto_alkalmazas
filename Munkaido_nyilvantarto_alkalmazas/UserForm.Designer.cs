namespace Munkaido_nyilvantarto_alkalmazas
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mcValaszto = new System.Windows.Forms.MonthCalendar();
            this.cbSzabadsagok = new System.Windows.Forms.ComboBox();
            this.btnKivesz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaradek = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem válassza ki mely napokra szeretne szabadságot kivenni!";
            // 
            // mcValaszto
            // 
            this.mcValaszto.Location = new System.Drawing.Point(151, 43);
            this.mcValaszto.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.mcValaszto.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.mcValaszto.Name = "mcValaszto";
            this.mcValaszto.TabIndex = 1;
            // 
            // cbSzabadsagok
            // 
            this.cbSzabadsagok.FormattingEnabled = true;
            this.cbSzabadsagok.Items.AddRange(new object[] {
            "Fizetett szabadság",
            "Fizetés nélküli szabadság",
            "Betegszabadság"});
            this.cbSzabadsagok.Location = new System.Drawing.Point(143, 339);
            this.cbSzabadsagok.Name = "cbSzabadsagok";
            this.cbSzabadsagok.Size = new System.Drawing.Size(249, 28);
            this.cbSzabadsagok.TabIndex = 2;
            // 
            // btnKivesz
            // 
            this.btnKivesz.Location = new System.Drawing.Point(430, 322);
            this.btnKivesz.Name = "btnKivesz";
            this.btnKivesz.Size = new System.Drawing.Size(204, 45);
            this.btnKivesz.TabIndex = 3;
            this.btnKivesz.Text = "Szabadság kivétele";
            this.btnKivesz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "A kivehető szabadságok száma:";
            // 
            // lbMaradek
            // 
            this.lbMaradek.AutoSize = true;
            this.lbMaradek.Location = new System.Drawing.Point(268, 439);
            this.lbMaradek.Name = "lbMaradek";
            this.lbMaradek.Size = new System.Drawing.Size(13, 20);
            this.lbMaradek.TabIndex = 5;
            this.lbMaradek.Text = " ";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(430, 405);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(204, 54);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin felület megnyitása";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 485);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lbMaradek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKivesz);
            this.Controls.Add(this.cbSzabadsagok);
            this.Controls.Add(this.mcValaszto);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcValaszto;
        private System.Windows.Forms.ComboBox cbSzabadsagok;
        private System.Windows.Forms.Button btnKivesz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaradek;
        private System.Windows.Forms.Button btnAdmin;
    }
}