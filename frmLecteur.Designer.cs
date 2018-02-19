namespace wfBiblio
{
    partial class frmLecteur
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
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label commentairesLabel;
            System.Windows.Forms.Label débutAdhésionLabel;
            System.Windows.Forms.Label dernierEmpruntLabel;
            System.Windows.Forms.Label finAdhésionLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label téléphoneLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label duréeEmpruntsLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label codePostalLabel;
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.lecteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentairesTextBox = new System.Windows.Forms.TextBox();
            this.débutAdhésionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dernierEmpruntDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finAdhésionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.téléphoneTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codePostalComboBox = new System.Windows.Forms.ComboBox();
            this.villeComboBox = new System.Windows.Forms.ComboBox();
            this.titreComboBox = new System.Windows.Forms.ComboBox();
            this.duréeEmpruntsTextBox = new System.Windows.Forms.TextBox();
            this.infoLecteurDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoLecteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListeEmprunts = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            adresseLabel = new System.Windows.Forms.Label();
            commentairesLabel = new System.Windows.Forms.Label();
            débutAdhésionLabel = new System.Windows.Forms.Label();
            dernierEmpruntLabel = new System.Windows.Forms.Label();
            finAdhésionLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            téléphoneLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            duréeEmpruntsLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lecteurBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoLecteurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoLecteurBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(16, 54);
            adresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(70, 20);
            adresseLabel.TabIndex = 1;
            adresseLabel.Text = "adresse:";
            // 
            // commentairesLabel
            // 
            commentairesLabel.AutoSize = true;
            commentairesLabel.Location = new System.Drawing.Point(521, 126);
            commentairesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            commentairesLabel.Name = "commentairesLabel";
            commentairesLabel.Size = new System.Drawing.Size(113, 20);
            commentairesLabel.TabIndex = 5;
            commentairesLabel.Text = "commentaires:";
            // 
            // débutAdhésionLabel
            // 
            débutAdhésionLabel.AutoSize = true;
            débutAdhésionLabel.Location = new System.Drawing.Point(521, 24);
            débutAdhésionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            débutAdhésionLabel.Name = "débutAdhésionLabel";
            débutAdhésionLabel.Size = new System.Drawing.Size(125, 20);
            débutAdhésionLabel.TabIndex = 7;
            débutAdhésionLabel.Text = "début Adhésion:";
            // 
            // dernierEmpruntLabel
            // 
            dernierEmpruntLabel.AutoSize = true;
            dernierEmpruntLabel.Location = new System.Drawing.Point(521, 96);
            dernierEmpruntLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dernierEmpruntLabel.Name = "dernierEmpruntLabel";
            dernierEmpruntLabel.Size = new System.Drawing.Size(127, 20);
            dernierEmpruntLabel.TabIndex = 9;
            dernierEmpruntLabel.Text = "dernier Emprunt:";
            // 
            // finAdhésionLabel
            // 
            finAdhésionLabel.AutoSize = true;
            finAdhésionLabel.Location = new System.Drawing.Point(521, 60);
            finAdhésionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            finAdhésionLabel.Name = "finAdhésionLabel";
            finAdhésionLabel.Size = new System.Drawing.Size(101, 20);
            finAdhésionLabel.TabIndex = 11;
            finAdhésionLabel.Text = "fin Adhésion:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(16, 162);
            mailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(41, 20);
            mailLabel.TabIndex = 15;
            mailLabel.Text = "mail:";
            // 
            // téléphoneLabel
            // 
            téléphoneLabel.AutoSize = true;
            téléphoneLabel.Location = new System.Drawing.Point(16, 126);
            téléphoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            téléphoneLabel.Name = "téléphoneLabel";
            téléphoneLabel.Size = new System.Drawing.Size(84, 20);
            téléphoneLabel.TabIndex = 17;
            téléphoneLabel.Text = "téléphone:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(16, 18);
            titreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(63, 20);
            titreLabel.TabIndex = 19;
            titreLabel.Text = "groupe:";
            // 
            // duréeEmpruntsLabel
            // 
            duréeEmpruntsLabel.AutoSize = true;
            duréeEmpruntsLabel.Location = new System.Drawing.Point(16, 196);
            duréeEmpruntsLabel.Name = "duréeEmpruntsLabel";
            duréeEmpruntsLabel.Size = new System.Drawing.Size(127, 20);
            duréeEmpruntsLabel.TabIndex = 22;
            duréeEmpruntsLabel.Text = "durée Emprunts:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(259, 89);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(38, 20);
            villeLabel.TabIndex = 24;
            villeLabel.Text = "ville:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(16, 89);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(96, 20);
            codePostalLabel.TabIndex = 25;
            codePostalLabel.Text = "code Postal:";
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "adresse", true));
            this.adresseTextBox.Location = new System.Drawing.Point(150, 50);
            this.adresseTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(343, 26);
            this.adresseTextBox.TabIndex = 2;
            // 
            // lecteurBindingSource
            // 
            this.lecteurBindingSource.DataSource = typeof(wfBiblio.Lecteur);
            // 
            // commentairesTextBox
            // 
            this.commentairesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "commentaires", true));
            this.commentairesTextBox.Location = new System.Drawing.Point(655, 126);
            this.commentairesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentairesTextBox.Multiline = true;
            this.commentairesTextBox.Name = "commentairesTextBox";
            this.commentairesTextBox.Size = new System.Drawing.Size(241, 101);
            this.commentairesTextBox.TabIndex = 11;
            // 
            // débutAdhésionDateTimePicker
            // 
            this.débutAdhésionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lecteurBindingSource, "débutAdhésion", true));
            this.débutAdhésionDateTimePicker.Location = new System.Drawing.Point(655, 18);
            this.débutAdhésionDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.débutAdhésionDateTimePicker.Name = "débutAdhésionDateTimePicker";
            this.débutAdhésionDateTimePicker.Size = new System.Drawing.Size(241, 26);
            this.débutAdhésionDateTimePicker.TabIndex = 8;
            // 
            // dernierEmpruntDateTimePicker
            // 
            this.dernierEmpruntDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lecteurBindingSource, "dernierEmprunt", true));
            this.dernierEmpruntDateTimePicker.Location = new System.Drawing.Point(655, 90);
            this.dernierEmpruntDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dernierEmpruntDateTimePicker.Name = "dernierEmpruntDateTimePicker";
            this.dernierEmpruntDateTimePicker.Size = new System.Drawing.Size(241, 26);
            this.dernierEmpruntDateTimePicker.TabIndex = 10;
            // 
            // finAdhésionDateTimePicker
            // 
            this.finAdhésionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lecteurBindingSource, "finAdhésion", true));
            this.finAdhésionDateTimePicker.Location = new System.Drawing.Point(655, 54);
            this.finAdhésionDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finAdhésionDateTimePicker.Name = "finAdhésionDateTimePicker";
            this.finAdhésionDateTimePicker.Size = new System.Drawing.Size(241, 26);
            this.finAdhésionDateTimePicker.TabIndex = 9;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(150, 158);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(343, 26);
            this.mailTextBox.TabIndex = 6;
            // 
            // téléphoneTextBox
            // 
            this.téléphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "téléphone", true));
            this.téléphoneTextBox.Location = new System.Drawing.Point(150, 123);
            this.téléphoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.téléphoneTextBox.Name = "téléphoneTextBox";
            this.téléphoneTextBox.Size = new System.Drawing.Size(343, 26);
            this.téléphoneTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(codePostalLabel);
            this.panel1.Controls.Add(this.codePostalComboBox);
            this.panel1.Controls.Add(villeLabel);
            this.panel1.Controls.Add(this.villeComboBox);
            this.panel1.Controls.Add(this.titreComboBox);
            this.panel1.Controls.Add(duréeEmpruntsLabel);
            this.panel1.Controls.Add(this.duréeEmpruntsTextBox);
            this.panel1.Controls.Add(dernierEmpruntLabel);
            this.panel1.Controls.Add(commentairesLabel);
            this.panel1.Controls.Add(this.dernierEmpruntDateTimePicker);
            this.panel1.Controls.Add(finAdhésionLabel);
            this.panel1.Controls.Add(this.finAdhésionDateTimePicker);
            this.panel1.Controls.Add(this.commentairesTextBox);
            this.panel1.Controls.Add(adresseLabel);
            this.panel1.Controls.Add(débutAdhésionLabel);
            this.panel1.Controls.Add(this.débutAdhésionDateTimePicker);
            this.panel1.Controls.Add(titreLabel);
            this.panel1.Controls.Add(this.adresseTextBox);
            this.panel1.Controls.Add(this.téléphoneTextBox);
            this.panel1.Controls.Add(mailLabel);
            this.panel1.Controls.Add(téléphoneLabel);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 257);
            this.panel1.TabIndex = 23;
            // 
            // codePostalComboBox
            // 
            this.codePostalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.codePostalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.codePostalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "codePostal", true));
            this.codePostalComboBox.FormattingEnabled = true;
            this.codePostalComboBox.Location = new System.Drawing.Point(149, 86);
            this.codePostalComboBox.Name = "codePostalComboBox";
            this.codePostalComboBox.Size = new System.Drawing.Size(100, 28);
            this.codePostalComboBox.TabIndex = 3;
            // 
            // villeComboBox
            // 
            this.villeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.villeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.villeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "ville", true));
            this.villeComboBox.FormattingEnabled = true;
            this.villeComboBox.Location = new System.Drawing.Point(303, 86);
            this.villeComboBox.Name = "villeComboBox";
            this.villeComboBox.Size = new System.Drawing.Size(190, 28);
            this.villeComboBox.TabIndex = 4;
            // 
            // titreComboBox
            // 
            this.titreComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.titreComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.titreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "titre", true));
            this.titreComboBox.FormattingEnabled = true;
            this.titreComboBox.Location = new System.Drawing.Point(150, 15);
            this.titreComboBox.Name = "titreComboBox";
            this.titreComboBox.Size = new System.Drawing.Size(343, 28);
            this.titreComboBox.TabIndex = 1;
            // 
            // duréeEmpruntsTextBox
            // 
            this.duréeEmpruntsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecteurBindingSource, "duréeEmprunts", true));
            this.duréeEmpruntsTextBox.Location = new System.Drawing.Point(149, 193);
            this.duréeEmpruntsTextBox.Name = "duréeEmpruntsTextBox";
            this.duréeEmpruntsTextBox.Size = new System.Drawing.Size(100, 26);
            this.duréeEmpruntsTextBox.TabIndex = 7;
            // 
            // infoLecteurDataGridView
            // 
            this.infoLecteurDataGridView.AutoGenerateColumns = false;
            this.infoLecteurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoLecteurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.infoLecteurDataGridView.DataSource = this.infoLecteurBindingSource;
            this.infoLecteurDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLecteurDataGridView.Location = new System.Drawing.Point(0, 257);
            this.infoLecteurDataGridView.Name = "infoLecteurDataGridView";
            this.infoLecteurDataGridView.Size = new System.Drawing.Size(916, 311);
            this.infoLecteurDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn4.HeaderText = "prénom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "commentaires";
            this.dataGridViewTextBoxColumn5.HeaderText = "commentaires";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 350;
            // 
            // infoLecteurBindingSource
            // 
            this.infoLecteurBindingSource.DataSource = typeof(wfBiblio.InfoLecteur);
            this.infoLecteurBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.infoLecteurBindingSource_AddingNew);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnListeEmprunts);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 74);
            this.panel2.TabIndex = 24;
            // 
            // btnListeEmprunts
            // 
            this.btnListeEmprunts.Location = new System.Drawing.Point(584, 20);
            this.btnListeEmprunts.Name = "btnListeEmprunts";
            this.btnListeEmprunts.Size = new System.Drawing.Size(181, 32);
            this.btnListeEmprunts.TabIndex = 3;
            this.btnListeEmprunts.Text = "Exporter les emprunts";
            this.btnListeEmprunts.UseVisualStyleBackColor = true;
            this.btnListeEmprunts.Click += new System.EventHandler(this.btnListeEmprunts_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(771, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(28, 20);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Enregistrer";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.csv";
            this.saveFileDialog1.Filter = "Fichier CSV|*.csv";
            this.saveFileDialog1.Title = "Exporter les emprunts vers Excel";
            // 
            // frmLecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 642);
            this.Controls.Add(this.infoLecteurDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLecteur";
            this.Text = "Lecteur";
            ((System.ComponentModel.ISupportInitialize)(this.lecteurBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoLecteurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoLecteurBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource lecteurBindingSource;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox commentairesTextBox;
        private System.Windows.Forms.DateTimePicker débutAdhésionDateTimePicker;
        private System.Windows.Forms.DateTimePicker dernierEmpruntDateTimePicker;
        private System.Windows.Forms.DateTimePicker finAdhésionDateTimePicker;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox téléphoneTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource infoLecteurBindingSource;
        private System.Windows.Forms.DataGridView infoLecteurDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnListeEmprunts;
        private System.Windows.Forms.TextBox duréeEmpruntsTextBox;
        private System.Windows.Forms.ComboBox titreComboBox;
        private System.Windows.Forms.ComboBox villeComboBox;
        private System.Windows.Forms.ComboBox codePostalComboBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}