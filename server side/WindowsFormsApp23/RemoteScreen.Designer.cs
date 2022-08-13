namespace WindowsFormsApp23
{
    partial class RemoteScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.mema = new System.Windows.Forms.PictureBox();
            this.mouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mema)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "exit button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "running on port 443";
            // 
            // mema
            // 
            this.mema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mema.Location = new System.Drawing.Point(0, 0);
            this.mema.Name = "mema";
            this.mema.Size = new System.Drawing.Size(1051, 471);
            this.mema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mema.TabIndex = 1;
            this.mema.TabStop = false;
            this.mema.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // mouse
            // 
            this.mouse.Location = new System.Drawing.Point(180, 427);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(115, 44);
            this.mouse.TabIndex = 5;
            this.mouse.Text = "Change to zoom view";
            this.mouse.UseVisualStyleBackColor = true;
            this.mouse.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoteScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 471);
            this.Controls.Add(this.mouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoteScreen";
            this.Text = "RemoteScreen";
            this.Load += new System.EventHandler(this.RemoteScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mema;
        private System.Windows.Forms.Button mouse;
    }
}