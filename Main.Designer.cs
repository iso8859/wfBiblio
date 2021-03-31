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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlCirculation = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddLecteur = new System.Windows.Forms.Button();
            this.btnChercherNotice = new System.Windows.Forms.Button();
            this.btnCirculation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCirculation = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvResultNotice = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnregistrerNotice = new System.Windows.Forms.Button();
            this.ctrlNotices1 = new wfBiblio.ctrlNotices();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAddNotice = new System.Windows.Forms.Button();
            this.btnSearchNotices = new System.Windows.Forms.Button();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ctrlCorriger1 = new wfBiblio.ctrlCorriger();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDesherbage = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesherbage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 1061);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.pnlCirculation);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1916, 1017);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Circulation";
            // 
            // pnlCirculation
            // 
            this.pnlCirculation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCirculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCirculation.Location = new System.Drawing.Point(5, 103);
            this.pnlCirculation.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCirculation.Name = "pnlCirculation";
            this.pnlCirculation.Size = new System.Drawing.Size(1906, 909);
            this.pnlCirculation.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Beige;
            this.panel4.Controls.Add(this.btnAddLecteur);
            this.panel4.Controls.Add(this.btnChercherNotice);
            this.panel4.Controls.Add(this.btnCirculation);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtSearchCirculation);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1906, 98);
            this.panel4.TabIndex = 4;
            // 
            // btnAddLecteur
            // 
            this.btnAddLecteur.Location = new System.Drawing.Point(1600, 19);
            this.btnAddLecteur.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddLecteur.Name = "btnAddLecteur";
            this.btnAddLecteur.Size = new System.Drawing.Size(218, 42);
            this.btnAddLecteur.TabIndex = 4;
            this.btnAddLecteur.Text = "Ajouter lecteur";
            this.btnAddLecteur.UseVisualStyleBackColor = true;
            this.btnAddLecteur.Click += new System.EventHandler(this.btnAddLecteur_Click);
            // 
            // btnChercherNotice
            // 
            this.btnChercherNotice.Location = new System.Drawing.Point(1366, 20);
            this.btnChercherNotice.Margin = new System.Windows.Forms.Padding(5);
            this.btnChercherNotice.Name = "btnChercherNotice";
            this.btnChercherNotice.Size = new System.Drawing.Size(224, 42);
            this.btnChercherNotice.TabIndex = 3;
            this.btnChercherNotice.Text = "Chercher notice";
            this.btnChercherNotice.UseVisualStyleBackColor = true;
            this.btnChercherNotice.Click += new System.EventHandler(this.btnChercherNotice_Click);
            // 
            // btnCirculation
            // 
            this.btnCirculation.Location = new System.Drawing.Point(1140, 20);
            this.btnCirculation.Margin = new System.Windows.Forms.Padding(5);
            this.btnCirculation.Name = "btnCirculation";
            this.btnCirculation.Size = new System.Drawing.Size(133, 42);
            this.btnCirculation.TabIndex = 2;
            this.btnCirculation.Text = "OK";
            this.btnCirculation.UseVisualStyleBackColor = true;
            this.btnCirculation.Click += new System.EventHandler(this.btnCirculation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher lecteur, code barre....";
            // 
            // txtSearchCirculation
            // 
            this.txtSearchCirculation.Location = new System.Drawing.Point(588, 22);
            this.txtSearchCirculation.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchCirculation.Name = "txtSearchCirculation";
            this.txtSearchCirculation.Size = new System.Drawing.Size(498, 38);
            this.txtSearchCirculation.TabIndex = 1;
            this.txtSearchCirculation.Click += new System.EventHandler(this.txtSearchCirculation_Click);
            this.txtSearchCirculation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCirculation_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvResultNotice);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1916, 1017);
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
            this.dgvResultNotice.Location = new System.Drawing.Point(5, 117);
            this.dgvResultNotice.Margin = new System.Windows.Forms.Padding(5);
            this.dgvResultNotice.Name = "dgvResultNotice";
            this.dgvResultNotice.ReadOnly = true;
            this.dgvResultNotice.RowHeadersVisible = false;
            this.dgvResultNotice.RowTemplate.Height = 50;
            this.dgvResultNotice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultNotice.Size = new System.Drawing.Size(994, 895);
            this.dgvResultNotice.TabIndex = 1;
            this.dgvResultNotice.SelectionChanged += new System.EventHandler(this.dgvResultNotice_SelectionChanged);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ctrlNotices1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(999, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 895);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnregistrerNotice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 799);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 96);
            this.panel3.TabIndex = 0;
            // 
            // btnEnregistrerNotice
            // 
            this.btnEnregistrerNotice.Location = new System.Drawing.Point(708, 20);
            this.btnEnregistrerNotice.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnregistrerNotice.Name = "btnEnregistrerNotice";
            this.btnEnregistrerNotice.Size = new System.Drawing.Size(178, 53);
            this.btnEnregistrerNotice.TabIndex = 4;
            this.btnEnregistrerNotice.Text = "Enregistrer";
            this.btnEnregistrerNotice.UseVisualStyleBackColor = true;
            this.btnEnregistrerNotice.Click += new System.EventHandler(this.btnEnregistrerNotice_Click);
            // 
            // ctrlNotices1
            // 
            this.ctrlNotices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlNotices1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlNotices1.Location = new System.Drawing.Point(0, 0);
            this.ctrlNotices1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ctrlNotices1.Name = "ctrlNotices1";
            this.ctrlNotices1.Size = new System.Drawing.Size(912, 895);
            this.ctrlNotices1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.btnAddNotice);
            this.panel1.Controls.Add(this.btnSearchNotices);
            this.panel1.Controls.Add(this.txtNotice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1906, 112);
            this.panel1.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(34, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 31);
            this.lblResult.TabIndex = 4;
            // 
            // btnAddNotice
            // 
            this.btnAddNotice.Location = new System.Drawing.Point(1280, 25);
            this.btnAddNotice.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNotice.Name = "btnAddNotice";
            this.btnAddNotice.Size = new System.Drawing.Size(178, 53);
            this.btnAddNotice.TabIndex = 3;
            this.btnAddNotice.Text = "Ajouter";
            this.btnAddNotice.UseVisualStyleBackColor = true;
            this.btnAddNotice.Click += new System.EventHandler(this.btnAddNotice_Click);
            // 
            // btnSearchNotices
            // 
            this.btnSearchNotices.Location = new System.Drawing.Point(1036, 25);
            this.btnSearchNotices.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchNotices.Name = "btnSearchNotices";
            this.btnSearchNotices.Size = new System.Drawing.Size(178, 53);
            this.btnSearchNotices.TabIndex = 2;
            this.btnSearchNotices.Text = "Chercher";
            this.btnSearchNotices.UseVisualStyleBackColor = true;
            this.btnSearchNotices.Click += new System.EventHandler(this.btnSearchNotices_Click);
            // 
            // txtNotice
            // 
            this.txtNotice.Location = new System.Drawing.Point(404, 31);
            this.txtNotice.Margin = new System.Windows.Forms.Padding(5);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(600, 38);
            this.txtNotice.TabIndex = 1;
            this.txtNotice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chercher par titre, auteur....";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ctrlCorriger1);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1916, 1017);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "A corriger";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ctrlCorriger1
            // 
            this.ctrlCorriger1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlCorriger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCorriger1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCorriger1.Margin = new System.Windows.Forms.Padding(7);
            this.ctrlCorriger1.Name = "ctrlCorriger1";
            this.ctrlCorriger1.Size = new System.Drawing.Size(1916, 1017);
            this.ctrlCorriger1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDesherbage);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1916, 1017);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Desherbage";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDesherbage
            // 
            this.dgvDesherbage.AllowUserToAddRows = false;
            this.dgvDesherbage.AllowUserToDeleteRows = false;
            this.dgvDesherbage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesherbage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDesherbage.Location = new System.Drawing.Point(0, 0);
            this.dgvDesherbage.Name = "dgvDesherbage";
            this.dgvDesherbage.RowTemplate.Height = 30;
            this.dgvDesherbage.Size = new System.Drawing.Size(1916, 1017);
            this.dgvDesherbage.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "business_contact-96.png");
            this.imageList1.Images.SetKeyName(1, "fine_print-96.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_tools_599559.png");
            this.imageList1.Images.SetKeyName(3, "Certification.ico");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage5
            // 
            this.tabPage5.ImageIndex = 3;
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1916, 1017);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "En attente";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Main";
            this.Text = "wfBiblio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultNotice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesherbage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSearchCirculation;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCirculation;
        private System.Windows.Forms.Panel pnlCirculation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddLecteur;
        private System.Windows.Forms.Button btnChercherNotice;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TabPage tabPage3;
        private ctrlCorriger ctrlCorriger1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDesherbage;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

