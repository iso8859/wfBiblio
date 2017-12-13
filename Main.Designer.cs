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
            this.btnAddNotice = new System.Windows.Forms.Button();
            this.btnSearchNotices = new System.Windows.Forms.Button();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 1061);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlCirculation);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage1.Size = new System.Drawing.Size(1916, 1017);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Circulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlCirculation
            // 
            this.pnlCirculation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCirculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCirculation.Location = new System.Drawing.Point(5, 103);
            this.pnlCirculation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlCirculation.Name = "pnlCirculation";
            this.pnlCirculation.Size = new System.Drawing.Size(1906, 909);
            this.pnlCirculation.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Beige;
            this.panel4.Controls.Add(this.btnCirculation);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtSearchCirculation);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1906, 98);
            this.panel4.TabIndex = 4;
            // 
            // btnCirculation
            // 
            this.btnCirculation.Location = new System.Drawing.Point(1140, 20);
            this.btnCirculation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.label1.Size = new System.Drawing.Size(422, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher lecteur, exemplaire....";
            // 
            // txtSearchCirculation
            // 
            this.txtSearchCirculation.Location = new System.Drawing.Point(588, 22);
            this.txtSearchCirculation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearchCirculation.Name = "txtSearchCirculation";
            this.txtSearchCirculation.Size = new System.Drawing.Size(498, 38);
            this.txtSearchCirculation.TabIndex = 1;
            this.txtSearchCirculation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCirculation_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvResultNotice);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.dgvResultNotice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 895);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnregistrerNotice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 799);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 96);
            this.panel3.TabIndex = 0;
            // 
            // btnEnregistrerNotice
            // 
            this.btnEnregistrerNotice.Location = new System.Drawing.Point(708, 20);
            this.btnEnregistrerNotice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.ctrlNotices1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlNotices1.Location = new System.Drawing.Point(0, 0);
            this.ctrlNotices1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ctrlNotices1.Name = "ctrlNotices1";
            this.ctrlNotices1.Size = new System.Drawing.Size(912, 895);
            this.ctrlNotices1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNotice);
            this.panel1.Controls.Add(this.btnSearchNotices);
            this.panel1.Controls.Add(this.txtNotice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1906, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnAddNotice
            // 
            this.btnAddNotice.Location = new System.Drawing.Point(1280, 25);
            this.btnAddNotice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.btnSearchNotices.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.txtNotice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
    }
}

