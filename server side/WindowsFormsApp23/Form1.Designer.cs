namespace WindowsFormsApp23
{
    partial class HallOfFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HallOfFrame));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.ExploticsIMG = new System.Windows.Forms.PictureBox();
            this.erezIMG = new System.Windows.Forms.PictureBox();
            this.yoyoshIMG = new System.Windows.Forms.PictureBox();
            this.rainbow = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.yoyoshTEXT = new System.Windows.Forms.Label();
            this.rainbowtext = new System.Windows.Forms.Label();
            this.ExploticsText = new System.Windows.Forms.Label();
            this.erezTEXT = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.ExploticsIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erezIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoyoshIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(-29, -150);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(601, 73);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "קישור לפוסט פרוייקט";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(-159, -150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 64);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ExploticsIMG
            // 
            this.ExploticsIMG.Cursor = System.Windows.Forms.Cursors.Help;
            this.ExploticsIMG.Image = global::WindowsFormsApp23.Properties.Resources.Expl0itics;
            this.ExploticsIMG.Location = new System.Drawing.Point(623, 27);
            this.ExploticsIMG.Name = "ExploticsIMG";
            this.ExploticsIMG.Size = new System.Drawing.Size(131, 104);
            this.ExploticsIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExploticsIMG.TabIndex = 29;
            this.ExploticsIMG.TabStop = false;
            this.ExploticsIMG.Click += new System.EventHandler(this.ExploticsIMG_Click);
            // 
            // erezIMG
            // 
            this.erezIMG.Cursor = System.Windows.Forms.Cursors.Help;
            this.erezIMG.Image = global::WindowsFormsApp23.Properties.Resources.erez;
            this.erezIMG.Location = new System.Drawing.Point(911, 27);
            this.erezIMG.Name = "erezIMG";
            this.erezIMG.Size = new System.Drawing.Size(131, 104);
            this.erezIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erezIMG.TabIndex = 28;
            this.erezIMG.TabStop = false;
            this.erezIMG.Click += new System.EventHandler(this.erezIMG_Click);
            // 
            // yoyoshIMG
            // 
            this.yoyoshIMG.Cursor = System.Windows.Forms.Cursors.Help;
            this.yoyoshIMG.Image = global::WindowsFormsApp23.Properties.Resources.Expl0itics;
            this.yoyoshIMG.Location = new System.Drawing.Point(44, 27);
            this.yoyoshIMG.Name = "yoyoshIMG";
            this.yoyoshIMG.Size = new System.Drawing.Size(131, 104);
            this.yoyoshIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yoyoshIMG.TabIndex = 27;
            this.yoyoshIMG.TabStop = false;
            this.yoyoshIMG.Click += new System.EventHandler(this.yoyoshIMG_Click);
            // 
            // rainbow
            // 
            this.rainbow.Cursor = System.Windows.Forms.Cursors.Help;
            this.rainbow.Image = global::WindowsFormsApp23.Properties.Resources.rainbow;
            this.rainbow.Location = new System.Drawing.Point(322, 27);
            this.rainbow.Name = "rainbow";
            this.rainbow.Size = new System.Drawing.Size(131, 104);
            this.rainbow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rainbow.TabIndex = 17;
            this.rainbow.TabStop = false;
            this.rainbow.Click += new System.EventHandler(this.rainbow_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(848, 436);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(157, 18);
            this.linkLabel2.TabIndex = 30;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "פוסט הפרוייקט המלא";
            // 
            // yoyoshTEXT
            // 
            this.yoyoshTEXT.AutoSize = true;
            this.yoyoshTEXT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yoyoshTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yoyoshTEXT.ForeColor = System.Drawing.Color.SkyBlue;
            this.yoyoshTEXT.Location = new System.Drawing.Point(56, 144);
            this.yoyoshTEXT.Name = "yoyoshTEXT";
            this.yoyoshTEXT.Size = new System.Drawing.Size(111, 31);
            this.yoyoshTEXT.TabIndex = 31;
            this.yoyoshTEXT.Text = "Yoyosh";
            // 
            // rainbowtext
            // 
            this.rainbowtext.AutoSize = true;
            this.rainbowtext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rainbowtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainbowtext.ForeColor = System.Drawing.Color.SteelBlue;
            this.rainbowtext.Location = new System.Drawing.Point(283, 144);
            this.rainbowtext.Name = "rainbowtext";
            this.rainbowtext.Size = new System.Drawing.Size(206, 31);
            this.rainbowtext.TabIndex = 32;
            this.rainbowtext.Text = "Rainbow_dash";
            // 
            // ExploticsText
            // 
            this.ExploticsText.AutoSize = true;
            this.ExploticsText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExploticsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExploticsText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ExploticsText.Location = new System.Drawing.Point(617, 144);
            this.ExploticsText.Name = "ExploticsText";
            this.ExploticsText.Size = new System.Drawing.Size(139, 31);
            this.ExploticsText.TabIndex = 33;
            this.ExploticsText.Text = "Expl0itics";
            // 
            // erezTEXT
            // 
            this.erezTEXT.AutoSize = true;
            this.erezTEXT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.erezTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erezTEXT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.erezTEXT.Location = new System.Drawing.Point(941, 144);
            this.erezTEXT.Name = "erezTEXT";
            this.erezTEXT.Size = new System.Drawing.Size(74, 31);
            this.erezTEXT.TabIndex = 34;
            this.erezTEXT.Text = "Erez";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp23.Properties.Resources.picture;
            this.pictureBox5.Location = new System.Drawing.Point(36, 339);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 103);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel3.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel3.Location = new System.Drawing.Point(184, 369);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(197, 46);
            this.linkLabel3.TabIndex = 36;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "<-- Sparta. (me)";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1009, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 47);
            this.button2.TabIndex = 37;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Oswald", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(325, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 109);
            this.label1.TabIndex = 39;
            this.label1.Text = "Hall Of Frame";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp23.Properties.Resources.thanks;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(937, 391);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(68, 42);
            this.axWindowsMediaPlayer1.TabIndex = 38;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // HallOfFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.erezTEXT);
            this.Controls.Add(this.ExploticsText);
            this.Controls.Add(this.rainbowtext);
            this.Controls.Add(this.yoyoshTEXT);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.ExploticsIMG);
            this.Controls.Add(this.erezIMG);
            this.Controls.Add(this.yoyoshIMG);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rainbow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HallOfFrame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExploticsIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erezIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoyoshIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox rainbow;
        private System.Windows.Forms.PictureBox yoyoshIMG;
        private System.Windows.Forms.PictureBox ExploticsIMG;
        private System.Windows.Forms.PictureBox erezIMG;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label yoyoshTEXT;
        private System.Windows.Forms.Label rainbowtext;
        private System.Windows.Forms.Label ExploticsText;
        private System.Windows.Forms.Label erezTEXT;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}