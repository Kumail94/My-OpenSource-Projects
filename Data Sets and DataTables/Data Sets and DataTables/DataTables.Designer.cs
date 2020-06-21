namespace Data_Sets_and_DataTables
{
    partial class DataTables
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
            this.Search = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            this.linkLabe = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.ContextStrip.SuspendLayout();
            this.SortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(19, 36);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(79, 33);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(139, 20);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.ContextStrip;
            this.dataGridView.Location = new System.Drawing.Point(12, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(458, 146);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
            // 
            // ContextStrip
            // 
            this.ContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.ContextStrip.Name = "ContextStrip";
            this.ContextStrip.Size = new System.Drawing.Size(181, 92);
            this.ContextStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextStrip_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertToolStripMenuItem.Text = "&Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.SalaryRadioButton);
            this.SortGroupBox.Controls.Add(this.NameRadioButton);
            this.SortGroupBox.Location = new System.Drawing.Point(254, 12);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Size = new System.Drawing.Size(216, 46);
            this.SortGroupBox.TabIndex = 3;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Sorting";
            this.SortGroupBox.Enter += new System.EventHandler(this.SortGroupBox_Enter);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(115, 18);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(69, 17);
            this.SalaryRadioButton.TabIndex = 1;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "By Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.Location = new System.Drawing.Point(17, 19);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(68, 17);
            this.NameRadioButton.TabIndex = 0;
            this.NameRadioButton.TabStop = true;
            this.NameRadioButton.Text = "By Name";
            this.NameRadioButton.UseVisualStyleBackColor = true;
            this.NameRadioButton.CheckedChanged += new System.EventHandler(this.NameRadioButton_CheckedChanged);
            // 
            // linkLabe
            // 
            this.linkLabe.AutoSize = true;
            this.linkLabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabe.Location = new System.Drawing.Point(12, 4);
            this.linkLabe.Name = "linkLabe";
            this.linkLabe.Size = new System.Drawing.Size(27, 24);
            this.linkLabe.TabIndex = 9;
            this.linkLabe.TabStop = true;
            this.linkLabe.Text = "->";
            this.linkLabe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabe_LinkClicked);
            // 
            // DataTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 217);
            this.Controls.Add(this.linkLabe);
            this.Controls.Add(this.SortGroupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DataTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataTables";
            this.Load += new System.EventHandler(this.DataTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ContextStrip.ResumeLayout(false);
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.RadioButton SalaryRadioButton;
        private System.Windows.Forms.RadioButton NameRadioButton;
        private System.Windows.Forms.ContextMenuStrip ContextStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabe;
    }
}