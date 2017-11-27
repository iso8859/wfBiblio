namespace wfBiblio
{
    partial class ctrlNotices
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label annéeLabel;
            System.Windows.Forms.Label auteurLabel;
            System.Windows.Forms.Label autresAuteursLabel;
            System.Windows.Forms.Label collectionLabel;
            System.Windows.Forms.Label commentairesLabel;
            System.Windows.Forms.Label complémentTitreLabel;
            System.Windows.Forms.Label dateAchatLabel;
            System.Windows.Forms.Label éditeurLabel;
            System.Windows.Forms.Label isbnLabel;
            System.Windows.Forms.Label titreLabel;
            this.annéeTextBox = new System.Windows.Forms.TextBox();
            this.auteurTextBox = new System.Windows.Forms.TextBox();
            this.autresAuteursTextBox = new System.Windows.Forms.TextBox();
            this.collectionTextBox = new System.Windows.Forms.TextBox();
            this.commentairesTextBox = new System.Windows.Forms.TextBox();
            this.complémentTitreTextBox = new System.Windows.Forms.TextBox();
            this.dateAchatTextBox = new System.Windows.Forms.TextBox();
            this.éditeurTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.noticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            annéeLabel = new System.Windows.Forms.Label();
            auteurLabel = new System.Windows.Forms.Label();
            autresAuteursLabel = new System.Windows.Forms.Label();
            collectionLabel = new System.Windows.Forms.Label();
            commentairesLabel = new System.Windows.Forms.Label();
            complémentTitreLabel = new System.Windows.Forms.Label();
            dateAchatLabel = new System.Windows.Forms.Label();
            éditeurLabel = new System.Windows.Forms.Label();
            isbnLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // annéeLabel
            // 
            annéeLabel.AutoSize = true;
            annéeLabel.Location = new System.Drawing.Point(23, 220);
            annéeLabel.Name = "annéeLabel";
            annéeLabel.Size = new System.Drawing.Size(58, 20);
            annéeLabel.TabIndex = 1;
            annéeLabel.Text = "année:";
            // 
            // auteurLabel
            // 
            auteurLabel.AutoSize = true;
            auteurLabel.Location = new System.Drawing.Point(23, 92);
            auteurLabel.Name = "auteurLabel";
            auteurLabel.Size = new System.Drawing.Size(59, 20);
            auteurLabel.TabIndex = 3;
            auteurLabel.Text = "auteur:";
            // 
            // autresAuteursLabel
            // 
            autresAuteursLabel.AutoSize = true;
            autresAuteursLabel.Location = new System.Drawing.Point(23, 124);
            autresAuteursLabel.Name = "autresAuteursLabel";
            autresAuteursLabel.Size = new System.Drawing.Size(118, 20);
            autresAuteursLabel.TabIndex = 5;
            autresAuteursLabel.Text = "autres Auteurs:";
            // 
            // collectionLabel
            // 
            collectionLabel.AutoSize = true;
            collectionLabel.Location = new System.Drawing.Point(23, 156);
            collectionLabel.Name = "collectionLabel";
            collectionLabel.Size = new System.Drawing.Size(79, 20);
            collectionLabel.TabIndex = 7;
            collectionLabel.Text = "collection:";
            // 
            // commentairesLabel
            // 
            commentairesLabel.AutoSize = true;
            commentairesLabel.Location = new System.Drawing.Point(23, 284);
            commentairesLabel.Name = "commentairesLabel";
            commentairesLabel.Size = new System.Drawing.Size(113, 20);
            commentairesLabel.TabIndex = 9;
            commentairesLabel.Text = "commentaires:";
            // 
            // complémentTitreLabel
            // 
            complémentTitreLabel.AutoSize = true;
            complémentTitreLabel.Location = new System.Drawing.Point(23, 59);
            complémentTitreLabel.Name = "complémentTitreLabel";
            complémentTitreLabel.Size = new System.Drawing.Size(131, 20);
            complémentTitreLabel.TabIndex = 11;
            complémentTitreLabel.Text = "complément titre:";
            // 
            // dateAchatLabel
            // 
            dateAchatLabel.AutoSize = true;
            dateAchatLabel.Location = new System.Drawing.Point(229, 223);
            dateAchatLabel.Name = "dateAchatLabel";
            dateAchatLabel.Size = new System.Drawing.Size(91, 20);
            dateAchatLabel.TabIndex = 13;
            dateAchatLabel.Text = "date Achat:";
            // 
            // éditeurLabel
            // 
            éditeurLabel.AutoSize = true;
            éditeurLabel.Location = new System.Drawing.Point(23, 188);
            éditeurLabel.Name = "éditeurLabel";
            éditeurLabel.Size = new System.Drawing.Size(62, 20);
            éditeurLabel.TabIndex = 15;
            éditeurLabel.Text = "éditeur:";
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new System.Drawing.Point(23, 252);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new System.Drawing.Size(42, 20);
            isbnLabel.TabIndex = 17;
            isbnLabel.Text = "isbn:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(23, 25);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(40, 20);
            titreLabel.TabIndex = 19;
            titreLabel.Text = "titre:";
            // 
            // annéeTextBox
            // 
            this.annéeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "année", true));
            this.annéeTextBox.Location = new System.Drawing.Point(108, 217);
            this.annéeTextBox.Name = "annéeTextBox";
            this.annéeTextBox.Size = new System.Drawing.Size(100, 26);
            this.annéeTextBox.TabIndex = 7;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "auteur", true));
            this.auteurTextBox.Location = new System.Drawing.Point(88, 89);
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(396, 26);
            this.auteurTextBox.TabIndex = 3;
            // 
            // autresAuteursTextBox
            // 
            this.autresAuteursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "autresAuteurs", true));
            this.autresAuteursTextBox.Location = new System.Drawing.Point(164, 121);
            this.autresAuteursTextBox.Name = "autresAuteursTextBox";
            this.autresAuteursTextBox.Size = new System.Drawing.Size(320, 26);
            this.autresAuteursTextBox.TabIndex = 4;
            // 
            // collectionTextBox
            // 
            this.collectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "collection", true));
            this.collectionTextBox.Location = new System.Drawing.Point(108, 153);
            this.collectionTextBox.Name = "collectionTextBox";
            this.collectionTextBox.Size = new System.Drawing.Size(376, 26);
            this.collectionTextBox.TabIndex = 5;
            // 
            // commentairesTextBox
            // 
            this.commentairesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "commentaires", true));
            this.commentairesTextBox.Location = new System.Drawing.Point(164, 281);
            this.commentairesTextBox.Multiline = true;
            this.commentairesTextBox.Name = "commentairesTextBox";
            this.commentairesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentairesTextBox.Size = new System.Drawing.Size(320, 85);
            this.commentairesTextBox.TabIndex = 10;
            // 
            // complémentTitreTextBox
            // 
            this.complémentTitreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "complémentTitre", true));
            this.complémentTitreTextBox.Location = new System.Drawing.Point(164, 56);
            this.complémentTitreTextBox.Name = "complémentTitreTextBox";
            this.complémentTitreTextBox.Size = new System.Drawing.Size(320, 26);
            this.complémentTitreTextBox.TabIndex = 2;
            // 
            // dateAchatTextBox
            // 
            this.dateAchatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "dateAchat", true));
            this.dateAchatTextBox.Location = new System.Drawing.Point(326, 217);
            this.dateAchatTextBox.Name = "dateAchatTextBox";
            this.dateAchatTextBox.Size = new System.Drawing.Size(100, 26);
            this.dateAchatTextBox.TabIndex = 8;
            // 
            // éditeurTextBox
            // 
            this.éditeurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "éditeur", true));
            this.éditeurTextBox.Location = new System.Drawing.Point(91, 185);
            this.éditeurTextBox.Name = "éditeurTextBox";
            this.éditeurTextBox.Size = new System.Drawing.Size(393, 26);
            this.éditeurTextBox.TabIndex = 6;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "isbn", true));
            this.isbnTextBox.Location = new System.Drawing.Point(108, 249);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(318, 26);
            this.isbnTextBox.TabIndex = 9;
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noticeBindingSource, "titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(69, 22);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(415, 26);
            this.titreTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 183);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // noticeBindingSource
            // 
            this.noticeBindingSource.DataSource = typeof(wfBiblio.Notice);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlNotices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(annéeLabel);
            this.Controls.Add(this.annéeTextBox);
            this.Controls.Add(auteurLabel);
            this.Controls.Add(this.auteurTextBox);
            this.Controls.Add(autresAuteursLabel);
            this.Controls.Add(this.autresAuteursTextBox);
            this.Controls.Add(collectionLabel);
            this.Controls.Add(this.collectionTextBox);
            this.Controls.Add(commentairesLabel);
            this.Controls.Add(this.commentairesTextBox);
            this.Controls.Add(complémentTitreLabel);
            this.Controls.Add(this.complémentTitreTextBox);
            this.Controls.Add(dateAchatLabel);
            this.Controls.Add(this.dateAchatTextBox);
            this.Controls.Add(éditeurLabel);
            this.Controls.Add(this.éditeurTextBox);
            this.Controls.Add(isbnLabel);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(titreLabel);
            this.Controls.Add(this.titreTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlNotices";
            this.Size = new System.Drawing.Size(508, 547);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource noticeBindingSource;
        private System.Windows.Forms.TextBox annéeTextBox;
        private System.Windows.Forms.TextBox auteurTextBox;
        private System.Windows.Forms.TextBox autresAuteursTextBox;
        private System.Windows.Forms.TextBox collectionTextBox;
        private System.Windows.Forms.TextBox commentairesTextBox;
        private System.Windows.Forms.TextBox complémentTitreTextBox;
        private System.Windows.Forms.TextBox dateAchatTextBox;
        private System.Windows.Forms.TextBox éditeurTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
