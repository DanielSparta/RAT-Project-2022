namespace WindowsFormsApp23
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Clients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrivateIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentWindow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdleTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.createAServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.commandToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerSpeakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crashingBlueScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoHideTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskbarLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msgbox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.shutdownComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFormServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAMDosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyloggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randsdomwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.forDaDoop = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.theme = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.port_btn = new System.Windows.Forms.Button();
            this.portUse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clients,
            this.PrivateIP,
            this.PublicIP,
            this.ComputerName,
            this.CurrentWindow,
            this.IdleTime});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(1039, 401);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Clients
            // 
            this.Clients.Text = "Clients";
            this.Clients.Width = 150;
            // 
            // PrivateIP
            // 
            this.PrivateIP.Text = "Private IP";
            this.PrivateIP.Width = 150;
            // 
            // PublicIP
            // 
            this.PublicIP.Text = "Public IP";
            this.PublicIP.Width = 150;
            // 
            // ComputerName
            // 
            this.ComputerName.Text = "Computer Name";
            this.ComputerName.Width = 160;
            // 
            // CurrentWindow
            // 
            this.CurrentWindow.Text = "Current Window";
            this.CurrentWindow.Width = 280;
            // 
            // IdleTime
            // 
            this.IdleTime.Text = "Idle time";
            this.IdleTime.Width = 140;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.createAServerToolStripMenuItem,
            this.deleteAServerToolStripMenuItem,
            this.buildProgramToolStripMenuItem,
            this.toolStripMenuItem1,
            this.commandToolsToolStripMenuItem,
            this.screenViewerToolStripMenuItem,
            this.processManagerToolStripMenuItem,
            this.reverseShellToolStripMenuItem,
            this.rAMDosToolStripMenuItem,
            this.paintToolToolStripMenuItem,
            this.remoteChatToolStripMenuItem,
            this.keyloggerToolStripMenuItem,
            this.randsdomwareToolStripMenuItem,
            this.toolStripMenuItem3,
            this.settingsToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 352);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test1ToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.medall;
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.test1ToolStripMenuItem.Text = "Hall Of Frame";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(157, 6);
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // createAServerToolStripMenuItem
            // 
            this.createAServerToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.server;
            this.createAServerToolStripMenuItem.Name = "createAServerToolStripMenuItem";
            this.createAServerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createAServerToolStripMenuItem.Text = "Create a Server";
            this.createAServerToolStripMenuItem.Click += new System.EventHandler(this.createAServerToolStripMenuItem_Click);
            // 
            // deleteAServerToolStripMenuItem
            // 
            this.deleteAServerToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.Icons8_Windows_8_Network_Disconnected;
            this.deleteAServerToolStripMenuItem.Name = "deleteAServerToolStripMenuItem";
            this.deleteAServerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteAServerToolStripMenuItem.Text = "Delete a server";
            this.deleteAServerToolStripMenuItem.Click += new System.EventHandler(this.deleteAServerToolStripMenuItem_Click);
            // 
            // buildProgramToolStripMenuItem
            // 
            this.buildProgramToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.download;
            this.buildProgramToolStripMenuItem.Name = "buildProgramToolStripMenuItem";
            this.buildProgramToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buildProgramToolStripMenuItem.Text = "Build program";
            this.buildProgramToolStripMenuItem.Click += new System.EventHandler(this.buildProgramToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // commandToolsToolStripMenuItem
            // 
            this.commandToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerSpeakToolStripMenuItem,
            this.crashingBlueScreenToolStripMenuItem,
            this.autoHideTaskbarToolStripMenuItem,
            this.taskbarLocationToolStripMenuItem,
            this.msgbox,
            this.toolStripMenuItem2,
            this.shutdownComputerToolStripMenuItem,
            this.restartClientToolStripMenuItem,
            this.disconnectFormServerToolStripMenuItem});
            this.commandToolsToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.tool;
            this.commandToolsToolStripMenuItem.Name = "commandToolsToolStripMenuItem";
            this.commandToolsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.commandToolsToolStripMenuItem.Text = "Command tools";
            this.commandToolsToolStripMenuItem.Click += new System.EventHandler(this.commandToolsToolStripMenuItem_Click);
            // 
            // computerSpeakToolStripMenuItem
            // 
            this.computerSpeakToolStripMenuItem.Name = "computerSpeakToolStripMenuItem";
            this.computerSpeakToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.computerSpeakToolStripMenuItem.Text = "Computer Speak";
            this.computerSpeakToolStripMenuItem.Click += new System.EventHandler(this.computerSpeakToolStripMenuItem_Click);
            // 
            // crashingBlueScreenToolStripMenuItem
            // 
            this.crashingBlueScreenToolStripMenuItem.Name = "crashingBlueScreenToolStripMenuItem";
            this.crashingBlueScreenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.crashingBlueScreenToolStripMenuItem.Text = "Crashing blue screen";
            this.crashingBlueScreenToolStripMenuItem.Click += new System.EventHandler(this.crashingBlueScreenToolStripMenuItem_Click);
            // 
            // autoHideTaskbarToolStripMenuItem
            // 
            this.autoHideTaskbarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.autoHideTaskbarToolStripMenuItem.Name = "autoHideTaskbarToolStripMenuItem";
            this.autoHideTaskbarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.autoHideTaskbarToolStripMenuItem.Text = "AutoHide taskbar";
            this.autoHideTaskbarToolStripMenuItem.Click += new System.EventHandler(this.autoHideTaskbarToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // taskbarLocationToolStripMenuItem
            // 
            this.taskbarLocationToolStripMenuItem.Name = "taskbarLocationToolStripMenuItem";
            this.taskbarLocationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.taskbarLocationToolStripMenuItem.Text = "taskbar location";
            this.taskbarLocationToolStripMenuItem.Click += new System.EventHandler(this.taskbarLocationToolStripMenuItem_Click);
            // 
            // msgbox
            // 
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(184, 22);
            this.msgbox.Text = "Message";
            this.msgbox.Click += new System.EventHandler(this.msgbox_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // shutdownComputerToolStripMenuItem
            // 
            this.shutdownComputerToolStripMenuItem.Name = "shutdownComputerToolStripMenuItem";
            this.shutdownComputerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.shutdownComputerToolStripMenuItem.Text = "Shutdown client";
            this.shutdownComputerToolStripMenuItem.Click += new System.EventHandler(this.shutdownComputerToolStripMenuItem_Click);
            // 
            // restartClientToolStripMenuItem
            // 
            this.restartClientToolStripMenuItem.Name = "restartClientToolStripMenuItem";
            this.restartClientToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.restartClientToolStripMenuItem.Text = "Restart client";
            this.restartClientToolStripMenuItem.Click += new System.EventHandler(this.restartClientToolStripMenuItem_Click);
            // 
            // disconnectFormServerToolStripMenuItem
            // 
            this.disconnectFormServerToolStripMenuItem.Name = "disconnectFormServerToolStripMenuItem";
            this.disconnectFormServerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.disconnectFormServerToolStripMenuItem.Text = "logout client";
            this.disconnectFormServerToolStripMenuItem.Click += new System.EventHandler(this.disconnectFormServerToolStripMenuItem_Click);
            // 
            // screenViewerToolStripMenuItem
            // 
            this.screenViewerToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.screen;
            this.screenViewerToolStripMenuItem.Name = "screenViewerToolStripMenuItem";
            this.screenViewerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.screenViewerToolStripMenuItem.Text = "Screen viewer";
            this.screenViewerToolStripMenuItem.Click += new System.EventHandler(this.screenViewerToolStripMenuItem_Click);
            // 
            // processManagerToolStripMenuItem
            // 
            this.processManagerToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.manager;
            this.processManagerToolStripMenuItem.Name = "processManagerToolStripMenuItem";
            this.processManagerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.processManagerToolStripMenuItem.Text = "Task manager";
            this.processManagerToolStripMenuItem.Click += new System.EventHandler(this.processManagerToolStripMenuItem_Click);
            // 
            // reverseShellToolStripMenuItem
            // 
            this.reverseShellToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.powershell1;
            this.reverseShellToolStripMenuItem.Name = "reverseShellToolStripMenuItem";
            this.reverseShellToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reverseShellToolStripMenuItem.Text = "Reverse Shell";
            this.reverseShellToolStripMenuItem.Click += new System.EventHandler(this.reverseShellToolStripMenuItem_Click);
            // 
            // rAMDosToolStripMenuItem
            // 
            this.rAMDosToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.fire;
            this.rAMDosToolStripMenuItem.Name = "rAMDosToolStripMenuItem";
            this.rAMDosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.rAMDosToolStripMenuItem.Text = "ram DoS";
            this.rAMDosToolStripMenuItem.Click += new System.EventHandler(this.rAMDosToolStripMenuItem_Click);
            // 
            // paintToolToolStripMenuItem
            // 
            this.paintToolToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.paint;
            this.paintToolToolStripMenuItem.Name = "paintToolToolStripMenuItem";
            this.paintToolToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.paintToolToolStripMenuItem.Text = "Paint tool";
            this.paintToolToolStripMenuItem.Click += new System.EventHandler(this.paintToolToolStripMenuItem_Click);
            // 
            // remoteChatToolStripMenuItem
            // 
            this.remoteChatToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.chat;
            this.remoteChatToolStripMenuItem.Name = "remoteChatToolStripMenuItem";
            this.remoteChatToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.remoteChatToolStripMenuItem.Text = "Remote Chat";
            this.remoteChatToolStripMenuItem.Click += new System.EventHandler(this.remoteChatToolStripMenuItem_Click);
            // 
            // keyloggerToolStripMenuItem
            // 
            this.keyloggerToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.keylogger;
            this.keyloggerToolStripMenuItem.Name = "keyloggerToolStripMenuItem";
            this.keyloggerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.keyloggerToolStripMenuItem.Text = "Keylogger";
            this.keyloggerToolStripMenuItem.Click += new System.EventHandler(this.keyloggerToolStripMenuItem_Click);
            // 
            // randsdomwareToolStripMenuItem
            // 
            this.randsdomwareToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.rans;
            this.randsdomwareToolStripMenuItem.Name = "randsdomwareToolStripMenuItem";
            this.randsdomwareToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.randsdomwareToolStripMenuItem.Text = "Screen lock";
            this.randsdomwareToolStripMenuItem.Click += new System.EventHandler(this.randsdomwareToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 6);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.settingsToolStripMenuItem.Text = "settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutMeToolStripMenuItem.Image = global::WindowsFormsApp23.Properties.Resources.download_icon_about_131964752256876096_256;
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.aboutMeToolStripMenuItem.Text = "about me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // forDaDoop
            // 
            this.forDaDoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.forDaDoop_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(930, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "2022 fxp RAT project";
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // theme
            // 
            this.theme.DoWork += new System.ComponentModel.DoWorkEventHandler(this.theme_DoWork);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 349);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1035, 46);
            this.axWindowsMediaPlayer1.TabIndex = 39;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // port_btn
            // 
            this.port_btn.Location = new System.Drawing.Point(371, 173);
            this.port_btn.Name = "port_btn";
            this.port_btn.Size = new System.Drawing.Size(104, 35);
            this.port_btn.TabIndex = 42;
            this.port_btn.Text = "Port to use";
            this.port_btn.UseVisualStyleBackColor = true;
            this.port_btn.Click += new System.EventHandler(this.port_btn_Click);
            // 
            // portUse
            // 
            this.portUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portUse.Location = new System.Drawing.Point(481, 173);
            this.portUse.Name = "portUse";
            this.portUse.Size = new System.Drawing.Size(111, 35);
            this.portUse.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "לא לגעת בקוד מבלי לדבר איתי קודם\r\nראו הוזהרתם, לא הקשבתם = לא אכפת לי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "במידה ואתם רוצים לשחק עם הקוד, תדברו עם מפתח התוכנה קודם (ספרטה), אחרת \r\nהתוכנה ה" +
    "זו תוכל להרוס לכם את המחשב בגלל מנגנוני אנטי סקידים ששמתי";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1039, 401);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portUse);
            this.Controls.Add(this.port_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FXP - SpartaRAT Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Clients;
        private System.Windows.Forms.ColumnHeader PrivateIP;
        private System.Windows.Forms.ColumnHeader PublicIP;
        private System.Windows.Forms.ColumnHeader ComputerName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader CurrentWindow;
        private System.Windows.Forms.ColumnHeader IdleTime;
        private System.Windows.Forms.ToolStripSeparator test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerSpeakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crashingBlueScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoHideTaskbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAMDosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem shutdownComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFormServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyloggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msgbox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.ComponentModel.BackgroundWorker forDaDoop;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.ToolStripMenuItem randsdomwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskbarLocationToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker theme;
        private System.Windows.Forms.ToolStripMenuItem remoteChatToolStripMenuItem;
        private System.Windows.Forms.Button port_btn;
        private System.Windows.Forms.TextBox portUse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

