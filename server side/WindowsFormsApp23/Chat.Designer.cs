namespace WindowsFormsApp23
{
    partial class Chat
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
            this.button1 = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.TextBox();
            this.receive = new System.Windows.Forms.TextBox();
            this.reader = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(10, 383);
            this.send.Multiline = true;
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(367, 56);
            this.send.TabIndex = 4;
            // 
            // receive
            // 
            this.receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receive.Location = new System.Drawing.Point(-3, 0);
            this.receive.Multiline = true;
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(536, 377);
            this.receive.TabIndex = 3;
            // 
            // reader
            // 
            this.reader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.reader_DoWork);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.receive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox send;
        private System.Windows.Forms.TextBox receive;
        private System.ComponentModel.BackgroundWorker reader;
    }
}