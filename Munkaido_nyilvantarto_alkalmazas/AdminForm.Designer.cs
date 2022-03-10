namespace Munkaido_nyilvantarto_alkalmazas
{
    partial class AdminForm
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnSzerkeszt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFelvisz = new System.Windows.Forms.Button();
            this.btnVisszalep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 20;
            this.lbLista.Location = new System.Drawing.Point(12, 46);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(635, 524);
            this.lbLista.TabIndex = 0;
            // 
            // btnSzerkeszt
            // 
            this.btnSzerkeszt.Location = new System.Drawing.Point(691, 46);
            this.btnSzerkeszt.Name = "btnSzerkeszt";
            this.btnSzerkeszt.Size = new System.Drawing.Size(219, 45);
            this.btnSzerkeszt.TabIndex = 1;
            this.btnSzerkeszt.Text = "Dolgozó szerkesztése";
            this.btnSzerkeszt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nyilvántartásban lévő dolgozók:";
            // 
            // btnFelvisz
            // 
            this.btnFelvisz.Location = new System.Drawing.Point(691, 124);
            this.btnFelvisz.Name = "btnFelvisz";
            this.btnFelvisz.Size = new System.Drawing.Size(219, 51);
            this.btnFelvisz.TabIndex = 3;
            this.btnFelvisz.Text = "Új dolgozó felvitele";
            this.btnFelvisz.UseVisualStyleBackColor = true;
            // 
            // btnVisszalep
            // 
            this.btnVisszalep.Location = new System.Drawing.Point(691, 214);
            this.btnVisszalep.Name = "btnVisszalep";
            this.btnVisszalep.Size = new System.Drawing.Size(219, 64);
            this.btnVisszalep.TabIndex = 4;
            this.btnVisszalep.Text = "Visszalépés az előző oldalra";
            this.btnVisszalep.UseVisualStyleBackColor = true;
            // 
            // ListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 592);
            this.Controls.Add(this.btnVisszalep);
            this.Controls.Add(this.btnFelvisz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSzerkeszt);
            this.Controls.Add(this.lbLista);
            this.Name = "ListaForm";
            this.Text = "ListaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnSzerkeszt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFelvisz;
        private System.Windows.Forms.Button btnVisszalep;
    }
}