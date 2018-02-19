namespace wfBiblio
{
    partial class frmrExemplaire
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codeBarreLabel;
            System.Windows.Forms.Label commentairesLabel;
            System.Windows.Forms.Label coteLabel;
            System.Windows.Forms.Label localisationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrExemplaire));
            this.exemplaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeBarreTextBox = new System.Windows.Forms.TextBox();
            this.commentairesTextBox = new System.Windows.Forms.TextBox();
            this.coteTextBox = new System.Windows.Forms.TextBox();
            this.localisationTextBox = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            codeBarreLabel = new System.Windows.Forms.Label();
            commentairesLabel = new System.Windows.Forms.Label();
            coteLabel = new System.Windows.Forms.Label();
            localisationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeBarreLabel
            // 
            codeBarreLabel.AutoSize = true;
            codeBarreLabel.Location = new System.Drawing.Point(34, 42);
            codeBarreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codeBarreLabel.Name = "codeBarreLabel";
            codeBarreLabel.Size = new System.Drawing.Size(91, 20);
            codeBarreLabel.TabIndex = 1;
            codeBarreLabel.Text = "code Barre:";
            // 
            // commentairesLabel
            // 
            commentairesLabel.AutoSize = true;
            commentairesLabel.Location = new System.Drawing.Point(34, 162);
            commentairesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            commentairesLabel.Name = "commentairesLabel";
            commentairesLabel.Size = new System.Drawing.Size(113, 20);
            commentairesLabel.TabIndex = 3;
            commentairesLabel.Text = "commentaires:";
            // 
            // coteLabel
            // 
            coteLabel.AutoSize = true;
            coteLabel.Location = new System.Drawing.Point(34, 82);
            coteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            coteLabel.Name = "coteLabel";
            coteLabel.Size = new System.Drawing.Size(44, 20);
            coteLabel.TabIndex = 5;
            coteLabel.Text = "cote:";
            // 
            // localisationLabel
            // 
            localisationLabel.AutoSize = true;
            localisationLabel.Location = new System.Drawing.Point(34, 122);
            localisationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            localisationLabel.Name = "localisationLabel";
            localisationLabel.Size = new System.Drawing.Size(91, 20);
            localisationLabel.TabIndex = 7;
            localisationLabel.Text = "localisation:";
            // 
            // exemplaireBindingSource
            // 
            this.exemplaireBindingSource.DataSource = typeof(wfBiblio.Exemplaire);
            // 
            // codeBarreTextBox
            // 
            this.codeBarreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exemplaireBindingSource, "codeBarre", true));
            this.codeBarreTextBox.Location = new System.Drawing.Point(156, 37);
            this.codeBarreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.codeBarreTextBox.Name = "codeBarreTextBox";
            this.codeBarreTextBox.Size = new System.Drawing.Size(337, 26);
            this.codeBarreTextBox.TabIndex = 1;
            // 
            // commentairesTextBox
            // 
            this.commentairesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exemplaireBindingSource, "commentaires", true));
            this.commentairesTextBox.Location = new System.Drawing.Point(156, 157);
            this.commentairesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentairesTextBox.Multiline = true;
            this.commentairesTextBox.Name = "commentairesTextBox";
            this.commentairesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentairesTextBox.Size = new System.Drawing.Size(337, 122);
            this.commentairesTextBox.TabIndex = 4;
            // 
            // coteTextBox
            // 
            this.coteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exemplaireBindingSource, "cote", true));
            this.coteTextBox.Location = new System.Drawing.Point(156, 77);
            this.coteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coteTextBox.Name = "coteTextBox";
            this.coteTextBox.Size = new System.Drawing.Size(337, 26);
            this.coteTextBox.TabIndex = 2;
            // 
            // localisationTextBox
            // 
            this.localisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exemplaireBindingSource, "localisation", true));
            this.localisationTextBox.Location = new System.Drawing.Point(156, 117);
            this.localisationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.localisationTextBox.Name = "localisationTextBox";
            this.localisationTextBox.Size = new System.Drawing.Size(337, 26);
            this.localisationTextBox.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(122, 309);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Valider";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 309);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmrExemplaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(528, 381);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(codeBarreLabel);
            this.Controls.Add(this.codeBarreTextBox);
            this.Controls.Add(commentairesLabel);
            this.Controls.Add(this.commentairesTextBox);
            this.Controls.Add(coteLabel);
            this.Controls.Add(this.coteTextBox);
            this.Controls.Add(localisationLabel);
            this.Controls.Add(this.localisationTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmrExemplaire";
            this.Text = "Exemplaire";
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource exemplaireBindingSource;
        private System.Windows.Forms.TextBox codeBarreTextBox;
        private System.Windows.Forms.TextBox commentairesTextBox;
        private System.Windows.Forms.TextBox coteTextBox;
        private System.Windows.Forms.TextBox localisationTextBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}