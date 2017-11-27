namespace wfBiblio
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvResultNotice = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNotice = new System.Windows.Forms.Button();
            this.btnSearchNotices = new System.Windows.Forms.Button();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.éditeurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autresAuteursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complémentTitreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annéeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAchatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlNotices1 = new wfBiblio.ctrlNotices();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnregistrerNotice = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultNotice)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1287, 715);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1125, 730);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Circulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Retours";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher emprunteur, exemplaire....";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvResultNotice);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1279, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notices";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvResultNotice
            // 
            this.dgvResultNotice.AllowUserToAddRows = false;
            this.dgvResultNotice.AllowUserToDeleteRows = false;
            this.dgvResultNotice.AutoGenerateColumns = false;
            this.dgvResultNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titreDataGridViewTextBoxColumn,
            this.auteurDataGridViewTextBoxColumn,
            this.éditeurDataGridViewTextBoxColumn,
            this.autresAuteursDataGridViewTextBoxColumn,
            this.complémentTitreDataGridViewTextBoxColumn,
            this.annéeDataGridViewTextBoxColumn,
            this.dateAchatDataGridViewTextBoxColumn,
            this.collectionDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn});
            this.dgvResultNotice.DataSource = this.noticeBindingSource;
            this.dgvResultNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultNotice.Location = new System.Drawing.Point(3, 75);
            this.dgvResultNotice.Name = "dgvResultNotice";
            this.dgvResultNotice.ReadOnly = true;
            this.dgvResultNotice.RowHeadersVisible = false;
            this.dgvResultNotice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultNotice.Size = new System.Drawing.Size(760, 604);
            this.dgvResultNotice.TabIndex = 1;
            this.dgvResultNotice.SelectionChanged += new System.EventHandler(this.dgvResultNotice_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNotice);
            this.panel1.Controls.Add(this.btnSearchNotices);
            this.panel1.Controls.Add(this.txtNotice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnAddNotice
            // 
            this.btnAddNotice.Location = new System.Drawing.Point(720, 16);
            this.btnAddNotice.Name = "btnAddNotice";
            this.btnAddNotice.Size = new System.Drawing.Size(100, 34);
            this.btnAddNotice.TabIndex = 3;
            this.btnAddNotice.Text = "Ajouter";
            this.btnAddNotice.UseVisualStyleBackColor = true;
            this.btnAddNotice.Click += new System.EventHandler(this.btnAddNotice_Click);
            // 
            // btnSearchNotices
            // 
            this.btnSearchNotices.Location = new System.Drawing.Point(583, 16);
            this.btnSearchNotices.Name = "btnSearchNotices";
            this.btnSearchNotices.Size = new System.Drawing.Size(100, 34);
            this.btnSearchNotices.TabIndex = 2;
            this.btnSearchNotices.Text = "Chercher";
            this.btnSearchNotices.UseVisualStyleBackColor = true;
            this.btnSearchNotices.Click += new System.EventHandler(this.btnSearchNotices_Click);
            // 
            // txtNotice
            // 
            this.txtNotice.Location = new System.Drawing.Point(227, 20);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(339, 26);
            this.txtNotice.TabIndex = 1;
            this.txtNotice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chercher par titre, auteur....";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1125, 730);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exemplaires";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1125, 730);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Emprunteurs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auteurDataGridViewTextBoxColumn
            // 
            this.auteurDataGridViewTextBoxColumn.DataPropertyName = "auteur";
            this.auteurDataGridViewTextBoxColumn.HeaderText = "auteur";
            this.auteurDataGridViewTextBoxColumn.Name = "auteurDataGridViewTextBoxColumn";
            this.auteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // éditeurDataGridViewTextBoxColumn
            // 
            this.éditeurDataGridViewTextBoxColumn.DataPropertyName = "éditeur";
            this.éditeurDataGridViewTextBoxColumn.HeaderText = "éditeur";
            this.éditeurDataGridViewTextBoxColumn.Name = "éditeurDataGridViewTextBoxColumn";
            this.éditeurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autresAuteursDataGridViewTextBoxColumn
            // 
            this.autresAuteursDataGridViewTextBoxColumn.DataPropertyName = "autresAuteurs";
            this.autresAuteursDataGridViewTextBoxColumn.HeaderText = "autresAuteurs";
            this.autresAuteursDataGridViewTextBoxColumn.Name = "autresAuteursDataGridViewTextBoxColumn";
            this.autresAuteursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complémentTitreDataGridViewTextBoxColumn
            // 
            this.complémentTitreDataGridViewTextBoxColumn.DataPropertyName = "complémentTitre";
            this.complémentTitreDataGridViewTextBoxColumn.HeaderText = "complémentTitre";
            this.complémentTitreDataGridViewTextBoxColumn.Name = "complémentTitreDataGridViewTextBoxColumn";
            this.complémentTitreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // annéeDataGridViewTextBoxColumn
            // 
            this.annéeDataGridViewTextBoxColumn.DataPropertyName = "année";
            this.annéeDataGridViewTextBoxColumn.HeaderText = "année";
            this.annéeDataGridViewTextBoxColumn.Name = "annéeDataGridViewTextBoxColumn";
            this.annéeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAchatDataGridViewTextBoxColumn
            // 
            this.dateAchatDataGridViewTextBoxColumn.DataPropertyName = "dateAchat";
            this.dateAchatDataGridViewTextBoxColumn.HeaderText = "dateAchat";
            this.dateAchatDataGridViewTextBoxColumn.Name = "dateAchatDataGridViewTextBoxColumn";
            this.dateAchatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectionDataGridViewTextBoxColumn
            // 
            this.collectionDataGridViewTextBoxColumn.DataPropertyName = "collection";
            this.collectionDataGridViewTextBoxColumn.HeaderText = "collection";
            this.collectionDataGridViewTextBoxColumn.Name = "collectionDataGridViewTextBoxColumn";
            this.collectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noticeBindingSource
            // 
            this.noticeBindingSource.DataSource = typeof(wfBiblio.Notice);
            // 
            // ctrlNotices1
            // 
            this.ctrlNotices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlNotices1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlNotices1.Location = new System.Drawing.Point(0, 0);
            this.ctrlNotices1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlNotices1.Name = "ctrlNotices1";
            this.ctrlNotices1.Size = new System.Drawing.Size(513, 604);
            this.ctrlNotices1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ctrlNotices1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(763, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 604);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnregistrerNotice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 542);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 62);
            this.panel3.TabIndex = 0;
            // 
            // btnEnregistrerNotice
            // 
            this.btnEnregistrerNotice.Location = new System.Drawing.Point(398, 13);
            this.btnEnregistrerNotice.Name = "btnEnregistrerNotice";
            this.btnEnregistrerNotice.Size = new System.Drawing.Size(100, 34);
            this.btnEnregistrerNotice.TabIndex = 4;
            this.btnEnregistrerNotice.Text = "Enregistrer";
            this.btnEnregistrerNotice.UseVisualStyleBackColor = true;
            this.btnEnregistrerNotice.Click += new System.EventHandler(this.btnEnregistrerNotice_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 715);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "wfBiblio";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultNotice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResultNotice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNotice;
        private System.Windows.Forms.Button btnSearchNotices;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.Label label3;
        private ctrlNotices ctrlNotices1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn éditeurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autresAuteursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complémentTitreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annéeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAchatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource noticeBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnregistrerNotice;
    }
}

