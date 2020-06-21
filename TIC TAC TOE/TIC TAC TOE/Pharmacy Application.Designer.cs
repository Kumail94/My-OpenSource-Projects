namespace TIC_TAC_TOE
{
    partial class Pharmacy_Application
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.CartItems = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.PrintOrder = new System.Windows.Forms.Button();
            this.PrintPreview = new System.Windows.Forms.Button();
            this.PharmacyGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 326);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHARMACY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.CartItems);
            this.groupBox.Controls.Add(this.PriceTextBox);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.QuantityTextBox);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.comboBox);
            this.groupBox.Location = new System.Drawing.Point(167, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(714, 75);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Cart Item";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // CartItems
            // 
            this.CartItems.BackColor = System.Drawing.Color.Tan;
            this.CartItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CartItems.Location = new System.Drawing.Point(627, 11);
            this.CartItems.Name = "CartItems";
            this.CartItems.Size = new System.Drawing.Size(80, 58);
            this.CartItems.TabIndex = 0;
            this.CartItems.Text = "Add to Cart";
            this.CartItems.UseVisualStyleBackColor = false;
            this.CartItems.Click += new System.EventHandler(this.CartItems_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(482, 21);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(130, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(293, 19);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(130, 20);
            this.QuantityTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Names";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Poston ",
            "Panadol\t",
            "Disprine",
            "Calpol\t",
            "Hydrolein"});
            this.comboBox.Location = new System.Drawing.Point(85, 22);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(139, 21);
            this.comboBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Amount";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(847, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(847, 267);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(720, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sales Tax:  ($)16 %";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(847, 293);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(720, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Pay";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(197, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.BackColor = System.Drawing.Color.Tan;
            this.NewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewRecord.Location = new System.Drawing.Point(893, 20);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(109, 52);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "New Record";
            this.NewRecord.UseVisualStyleBackColor = false;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // PrintOrder
            // 
            this.PrintOrder.BackColor = System.Drawing.Color.Tan;
            this.PrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrintOrder.Location = new System.Drawing.Point(893, 77);
            this.PrintOrder.Name = "PrintOrder";
            this.PrintOrder.Size = new System.Drawing.Size(109, 50);
            this.PrintOrder.TabIndex = 1;
            this.PrintOrder.Text = "Print Order";
            this.PrintOrder.UseVisualStyleBackColor = false;
            // 
            // PrintPreview
            // 
            this.PrintPreview.BackColor = System.Drawing.Color.Tan;
            this.PrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrintPreview.Location = new System.Drawing.Point(893, 133);
            this.PrintPreview.Name = "PrintPreview";
            this.PrintPreview.Size = new System.Drawing.Size(109, 53);
            this.PrintPreview.TabIndex = 2;
            this.PrintPreview.Text = "Print Preview";
            this.PrintPreview.UseVisualStyleBackColor = false;
            // 
            // PharmacyGridView
            // 
            this.PharmacyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PharmacyGridView.Location = new System.Drawing.Point(167, 94);
            this.PharmacyGridView.Name = "PharmacyGridView";
            this.PharmacyGridView.Size = new System.Drawing.Size(714, 131);
            this.PharmacyGridView.TabIndex = 10;
            // 
            // Pharmacy_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1012, 320);
            this.Controls.Add(this.PharmacyGridView);
            this.Controls.Add(this.PrintPreview);
            this.Controls.Add(this.PrintOrder);
            this.Controls.Add(this.NewRecord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacy_Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy_Application";
            this.Load += new System.EventHandler(this.Pharmacy_Application_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CartItems;
        private System.Windows.Forms.Button NewRecord;
        private System.Windows.Forms.Button PrintOrder;
        private System.Windows.Forms.Button PrintPreview;
        private System.Windows.Forms.DataGridView PharmacyGridView;
    }
}