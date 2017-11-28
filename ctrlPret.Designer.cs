namespace wfBiblio
{
    partial class ctrlPret
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.txtExemplaire = new System.Windows.Forms.TextBox();
            this.txtDatepret = new System.Windows.Forms.TextBox();
            this.txtDateRetour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exemplaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de prêt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de retour";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(100, 6);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.ReadOnly = true;
            this.txtTitre.Size = new System.Drawing.Size(192, 22);
            this.txtTitre.TabIndex = 5;
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(100, 41);
            this.txtAuteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.ReadOnly = true;
            this.txtAuteur.Size = new System.Drawing.Size(192, 22);
            this.txtAuteur.TabIndex = 6;
            // 
            // txtExemplaire
            // 
            this.txtExemplaire.Location = new System.Drawing.Point(100, 77);
            this.txtExemplaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExemplaire.Name = "txtExemplaire";
            this.txtExemplaire.ReadOnly = true;
            this.txtExemplaire.Size = new System.Drawing.Size(192, 22);
            this.txtExemplaire.TabIndex = 7;
            // 
            // txtDatepret
            // 
            this.txtDatepret.Location = new System.Drawing.Point(314, 32);
            this.txtDatepret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatepret.Name = "txtDatepret";
            this.txtDatepret.ReadOnly = true;
            this.txtDatepret.Size = new System.Drawing.Size(101, 22);
            this.txtDatepret.TabIndex = 8;
            // 
            // txtDateRetour
            // 
            this.txtDateRetour.Location = new System.Drawing.Point(314, 77);
            this.txtDateRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateRetour.Name = "txtDateRetour";
            this.txtDateRetour.ReadOnly = true;
            this.txtDateRetour.Size = new System.Drawing.Size(101, 22);
            this.txtDateRetour.TabIndex = 9;
            // 
            // ctrlPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.txtDateRetour);
            this.Controls.Add(this.txtDatepret);
            this.Controls.Add(this.txtExemplaire);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlPret";
            this.Size = new System.Drawing.Size(426, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTitre;
        public System.Windows.Forms.TextBox txtAuteur;
        public System.Windows.Forms.TextBox txtExemplaire;
        public System.Windows.Forms.TextBox txtDatepret;
        public System.Windows.Forms.TextBox txtDateRetour;
    }
}
