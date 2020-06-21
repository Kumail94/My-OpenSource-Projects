namespace Socket_Programming_For_Clients
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ServerMessage = new System.Windows.Forms.TextBox();
            this.SendText = new System.Windows.Forms.TextBox();
            this.SendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servers";
            // 
            // ServerMessage
            // 
            this.ServerMessage.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerMessage.Location = new System.Drawing.Point(24, 35);
            this.ServerMessage.Multiline = true;
            this.ServerMessage.Name = "ServerMessage";
            this.ServerMessage.Size = new System.Drawing.Size(547, 129);
            this.ServerMessage.TabIndex = 1;
            // 
            // SendText
            // 
            this.SendText.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendText.Location = new System.Drawing.Point(24, 186);
            this.SendText.Multiline = true;
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(434, 30);
            this.SendText.TabIndex = 2;
            // 
            // SendRequest
            // 
            this.SendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendRequest.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequest.Location = new System.Drawing.Point(470, 186);
            this.SendRequest.Name = "SendRequest";
            this.SendRequest.Size = new System.Drawing.Size(101, 31);
            this.SendRequest.TabIndex = 3;
            this.SendRequest.Text = "Send Message";
            this.SendRequest.UseVisualStyleBackColor = true;
            this.SendRequest.Click += new System.EventHandler(this.SendRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 243);
            this.Controls.Add(this.SendRequest);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.ServerMessage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socket Programming For Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerMessage;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.Button SendRequest;
    }
}

