namespace Munkaido_nyilvantarto_alkalmazas
{
    partial class BejelentkezesForm
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
            this.btnBejelentkezes = new System.Windows.Forms.Button();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.tbEMailCim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBejelentkezes
            // 
            this.btnBejelentkezes.Location = new System.Drawing.Point(176, 235);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(152, 45);
            this.btnBejelentkezes.TabIndex = 0;
            this.btnBejelentkezes.Text = "Bejelentkezés";
            this.btnBejelentkezes.UseVisualStyleBackColor = true;
            this.btnBejelentkezes.Click += new System.EventHandler(this.btnBejelentkezes_Click);
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(26, 168);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '*';
            this.tbJelszo.Size = new System.Drawing.Size(174, 26);
            this.tbJelszo.TabIndex = 1;
            // 
            // tbEMailCim
            // 
            this.tbEMailCim.Location = new System.Drawing.Point(26, 73);
            this.tbEMailCim.Name = "tbEMailCim";
            this.tbEMailCim.Size = new System.Drawing.Size(174, 26);
            this.tbEMailCim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-mail cím";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó";
            // 
            // BejelentkezesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEMailCim);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.btnBejelentkezes);
            this.Name = "BejelentkezesForm";
            this.Text = "BejelentkezesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBejelentkezes;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.TextBox tbEMailCim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

