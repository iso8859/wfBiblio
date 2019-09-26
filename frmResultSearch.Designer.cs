namespace wfBiblio
{
    partial class frmResultSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copierTitreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierAuteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierIsbnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Double cliquez sur la notice recherchée";
            // 
            // dgvNotices
            // 
            this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.AllowUserToDeleteRows = false;
            this.dgvNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotices.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvNotices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotices.Location = new System.Drawing.Point(0, 60);
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowTemplate.Height = 30;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(1230, 621);
            this.dgvNotices.TabIndex = 1;
            this.dgvNotices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotices_CellDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierTitreToolStripMenuItem,
            this.copierAuteurToolStripMenuItem,
            this.copierIsbnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            // 
            // copierTitreToolStripMenuItem
            // 
            this.copierTitreToolStripMenuItem.Name = "copierTitreToolStripMenuItem";
            this.copierTitreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copierTitreToolStripMenuItem.Text = "Copier titre";
            this.copierTitreToolStripMenuItem.Click += new System.EventHandler(this.copierTitreToolStripMenuItem_Click);
            // 
            // copierAuteurToolStripMenuItem
            // 
            this.copierAuteurToolStripMenuItem.Name = "copierAuteurToolStripMenuItem";
            this.copierAuteurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copierAuteurToolStripMenuItem.Text = "Copier auteur";
            this.copierAuteurToolStripMenuItem.Click += new System.EventHandler(this.copierAuteurToolStripMenuItem_Click);
            // 
            // copierIsbnToolStripMenuItem
            // 
            this.copierIsbnToolStripMenuItem.Name = "copierIsbnToolStripMenuItem";
            this.copierIsbnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copierIsbnToolStripMenuItem.Text = "Copier isbn";
            this.copierIsbnToolStripMenuItem.Click += new System.EventHandler(this.copierIsbnToolStripMenuItem_Click);
            // 
            // frmResultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 681);
            this.Controls.Add(this.dgvNotices);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmResultSearch";
            this.Text = "Resultats recherche";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copierTitreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierAuteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierIsbnToolStripMenuItem;
    }
}