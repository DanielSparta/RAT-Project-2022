namespace WindowsFormsApp26
{
    partial class Form2
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
            this.locked = new System.Windows.Forms.Label();
            this.unlock_text = new System.Windows.Forms.TextBox();
            this.unlock_label = new System.Windows.Forms.Label();
            this.unlock_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // locked
            // 
            this.locked.AutoSize = true;
            this.locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locked.ForeColor = System.Drawing.Color.Red;
            this.locked.Location = new System.Drawing.Point(843, 340);
            this.locked.Name = "locked";
            this.locked.Size = new System.Drawing.Size(376, 73);
            this.locked.TabIndex = 0;
            this.locked.Text = "Locked out!";
            // 
            // unlock_text
            // 
            this.unlock_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlock_text.Location = new System.Drawing.Point(1064, 649);
            this.unlock_text.Name = "unlock_text";
            this.unlock_text.Size = new System.Drawing.Size(350, 47);
            this.unlock_text.TabIndex = 2;
            // 
            // unlock_label
            // 
            this.unlock_label.AutoSize = true;
            this.unlock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlock_label.Location = new System.Drawing.Point(850, 658);
            this.unlock_label.Name = "unlock_label";
            this.unlock_label.Size = new System.Drawing.Size(162, 31);
            this.unlock_label.TabIndex = 3;
            this.unlock_label.Text = "unlock key:";
            // 
            // unlock_btn
            // 
            this.unlock_btn.Location = new System.Drawing.Point(1043, 721);
            this.unlock_btn.Name = "unlock_btn";
            this.unlock_btn.Size = new System.Drawing.Size(114, 63);
            this.unlock_btn.TabIndex = 4;
            this.unlock_btn.Text = "Unlock my computer";
            this.unlock_btn.UseVisualStyleBackColor = true;
            this.unlock_btn.Click += new System.EventHandler(this.unlock_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1249, 698);
            this.Controls.Add(this.unlock_btn);
            this.Controls.Add(this.unlock_label);
            this.Controls.Add(this.unlock_text);
            this.Controls.Add(this.locked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locked;
        private System.Windows.Forms.TextBox unlock_text;
        private System.Windows.Forms.Label unlock_label;
        private System.Windows.Forms.Button unlock_btn;
        private System.Windows.Forms.Timer timer1;
    }
}