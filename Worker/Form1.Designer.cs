
namespace Worker
{
    partial class Worker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worker));
            this.bunifuCards1 = new ns1.BunifuCards();
            this.panelNotify = new System.Windows.Forms.Panel();
            this.LabelNotify = new ns1.BunifuCustomLabel();
            this.ProgressbarIndicator = new ns1.BunifuCircleProgressbar();
            this.ButtonStatus = new ns1.BunifuFlatButton();
            this.ButtonExit = new ns1.BunifuFlatButton();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.TextboxOrganization = new ns1.BunifuMaterialTextbox();
            this.TextboxEmail = new ns1.BunifuMaterialTextbox();
            this.TextboxPassword = new ns1.BunifuMaterialTextbox();
            this.ButtonLogIn = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runOnStartUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runOnStartUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerIndecator = new System.Windows.Forms.Timer(this.components);
            this.panelOrganization = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.panelNotify.SuspendLayout();
            this.panelLogIn.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelOrganization.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Navy;
            this.bunifuCards1.Controls.Add(this.panelOrganization);
            this.bunifuCards1.Controls.Add(this.panelNotify);
            this.bunifuCards1.Controls.Add(this.ProgressbarIndicator);
            this.bunifuCards1.Controls.Add(this.ButtonStatus);
            this.bunifuCards1.Controls.Add(this.ButtonExit);
            this.bunifuCards1.Controls.Add(this.panelLogIn);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(800, 450);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuForm_MouseDown);
            this.bunifuCards1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.bunifuCards1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // panelNotify
            // 
            this.panelNotify.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNotify.Controls.Add(this.LabelNotify);
            this.panelNotify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotify.Location = new System.Drawing.Point(0, 402);
            this.panelNotify.Name = "panelNotify";
            this.panelNotify.Size = new System.Drawing.Size(800, 48);
            this.panelNotify.TabIndex = 9;
            this.panelNotify.Visible = false;
            // 
            // LabelNotify
            // 
            this.LabelNotify.AutoSize = true;
            this.LabelNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotify.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelNotify.Location = new System.Drawing.Point(360, 13);
            this.LabelNotify.Name = "LabelNotify";
            this.LabelNotify.Size = new System.Drawing.Size(91, 20);
            this.LabelNotify.TabIndex = 7;
            this.LabelNotify.Text = "Username";
            // 
            // ProgressbarIndicator
            // 
            this.ProgressbarIndicator.animated = true;
            this.ProgressbarIndicator.animationIterval = 5;
            this.ProgressbarIndicator.animationSpeed = 300;
            this.ProgressbarIndicator.BackColor = System.Drawing.Color.White;
            this.ProgressbarIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressbarIndicator.BackgroundImage")));
            this.ProgressbarIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgressbarIndicator.ForeColor = System.Drawing.Color.White;
            this.ProgressbarIndicator.LabelVisible = false;
            this.ProgressbarIndicator.LineProgressThickness = 8;
            this.ProgressbarIndicator.LineThickness = 5;
            this.ProgressbarIndicator.Location = new System.Drawing.Point(686, 95);
            this.ProgressbarIndicator.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ProgressbarIndicator.MaxValue = 100;
            this.ProgressbarIndicator.Name = "ProgressbarIndicator";
            this.ProgressbarIndicator.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressbarIndicator.ProgressColor = System.Drawing.Color.SeaGreen;
            this.ProgressbarIndicator.Size = new System.Drawing.Size(70, 70);
            this.ProgressbarIndicator.TabIndex = 8;
            this.ProgressbarIndicator.Value = 0;
            this.ProgressbarIndicator.Visible = false;
            // 
            // ButtonStatus
            // 
            this.ButtonStatus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonStatus.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonStatus.BorderRadius = 0;
            this.ButtonStatus.ButtonText = "Log In";
            this.ButtonStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStatus.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonStatus.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonStatus.Iconimage = null;
            this.ButtonStatus.Iconimage_right = null;
            this.ButtonStatus.Iconimage_right_Selected = null;
            this.ButtonStatus.Iconimage_Selected = null;
            this.ButtonStatus.IconMarginLeft = 0;
            this.ButtonStatus.IconMarginRight = 0;
            this.ButtonStatus.IconRightVisible = true;
            this.ButtonStatus.IconRightZoom = 0D;
            this.ButtonStatus.IconVisible = true;
            this.ButtonStatus.IconZoom = 90D;
            this.ButtonStatus.IsTab = false;
            this.ButtonStatus.Location = new System.Drawing.Point(288, 6);
            this.ButtonStatus.Name = "ButtonStatus";
            this.ButtonStatus.Normalcolor = System.Drawing.Color.SeaGreen;
            this.ButtonStatus.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.ButtonStatus.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonStatus.selected = false;
            this.ButtonStatus.Size = new System.Drawing.Size(241, 48);
            this.ButtonStatus.TabIndex = 7;
            this.ButtonStatus.Text = "Log In";
            this.ButtonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonStatus.Textcolor = System.Drawing.Color.White;
            this.ButtonStatus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStatus.Visible = false;
            this.ButtonStatus.Click += new System.EventHandler(this.ButtonStatus_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonExit.BackColor = System.Drawing.Color.Navy;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExit.BorderRadius = 0;
            this.ButtonExit.ButtonText = "Close";
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonExit.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonExit.Iconimage = null;
            this.ButtonExit.Iconimage_right = null;
            this.ButtonExit.Iconimage_right_Selected = null;
            this.ButtonExit.Iconimage_Selected = null;
            this.ButtonExit.IconMarginLeft = 0;
            this.ButtonExit.IconMarginRight = 0;
            this.ButtonExit.IconRightVisible = true;
            this.ButtonExit.IconRightZoom = 0D;
            this.ButtonExit.IconVisible = true;
            this.ButtonExit.IconZoom = 90D;
            this.ButtonExit.IsTab = false;
            this.ButtonExit.Location = new System.Drawing.Point(713, 6);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Normalcolor = System.Drawing.Color.Navy;
            this.ButtonExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonExit.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonExit.selected = false;
            this.ButtonExit.Size = new System.Drawing.Size(84, 33);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "Close";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonExit.Textcolor = System.Drawing.Color.White;
            this.ButtonExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.bunifuFlatButton3);
            this.panelLogIn.Controls.Add(this.TextboxEmail);
            this.panelLogIn.Controls.Add(this.TextboxPassword);
            this.panelLogIn.Controls.Add(this.ButtonLogIn);
            this.panelLogIn.Controls.Add(this.bunifuCustomLabel1);
            this.panelLogIn.Controls.Add(this.bunifuCustomLabel2);
            this.panelLogIn.Location = new System.Drawing.Point(8, 60);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(405, 297);
            this.panelLogIn.TabIndex = 7;
            this.panelLogIn.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 8);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(111, 20);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Organization";
            // 
            // TextboxOrganization
            // 
            this.TextboxOrganization.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxOrganization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxOrganization.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxOrganization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxOrganization.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxOrganization.HintText = "";
            this.TextboxOrganization.isPassword = true;
            this.TextboxOrganization.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxOrganization.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxOrganization.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxOrganization.LineThickness = 3;
            this.TextboxOrganization.Location = new System.Drawing.Point(4, 32);
            this.TextboxOrganization.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxOrganization.Name = "TextboxOrganization";
            this.TextboxOrganization.Size = new System.Drawing.Size(370, 44);
            this.TextboxOrganization.TabIndex = 7;
            this.TextboxOrganization.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxEmail
            // 
            this.TextboxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxEmail.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxEmail.HintText = "";
            this.TextboxEmail.isPassword = false;
            this.TextboxEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxEmail.LineThickness = 3;
            this.TextboxEmail.Location = new System.Drawing.Point(14, 47);
            this.TextboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxEmail.Name = "TextboxEmail";
            this.TextboxEmail.Size = new System.Drawing.Size(370, 44);
            this.TextboxEmail.TabIndex = 2;
            this.TextboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxPassword.HintText = "";
            this.TextboxPassword.isPassword = true;
            this.TextboxPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxPassword.LineThickness = 3;
            this.TextboxPassword.Location = new System.Drawing.Point(14, 123);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(370, 44);
            this.TextboxPassword.TabIndex = 3;
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxPassword.OnValueChanged += new System.EventHandler(this.TextboxPassword_OnValueChanged);
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonLogIn.BackColor = System.Drawing.Color.Navy;
            this.ButtonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonLogIn.BorderRadius = 0;
            this.ButtonLogIn.ButtonText = "Log In";
            this.ButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogIn.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonLogIn.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonLogIn.Iconimage = null;
            this.ButtonLogIn.Iconimage_right = null;
            this.ButtonLogIn.Iconimage_right_Selected = null;
            this.ButtonLogIn.Iconimage_Selected = null;
            this.ButtonLogIn.IconMarginLeft = 0;
            this.ButtonLogIn.IconMarginRight = 0;
            this.ButtonLogIn.IconRightVisible = true;
            this.ButtonLogIn.IconRightZoom = 0D;
            this.ButtonLogIn.IconVisible = true;
            this.ButtonLogIn.IconZoom = 90D;
            this.ButtonLogIn.IsTab = false;
            this.ButtonLogIn.Location = new System.Drawing.Point(84, 190);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Normalcolor = System.Drawing.Color.Navy;
            this.ButtonLogIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonLogIn.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonLogIn.selected = false;
            this.ButtonLogIn.Size = new System.Drawing.Size(241, 48);
            this.ButtonLogIn.TabIndex = 4;
            this.ButtonLogIn.Text = "Log In";
            this.ButtonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogIn.Textcolor = System.Drawing.Color.White;
            this.ButtonLogIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 20);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 99);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(86, 20);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runOnStartUpToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 54);
            // 
            // runOnStartUpToolStripMenuItem
            // 
            this.runOnStartUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runOnStartUpToolStripMenuItem1,
            this.resetToolStripMenuItem});
            this.runOnStartUpToolStripMenuItem.Name = "runOnStartUpToolStripMenuItem";
            this.runOnStartUpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.runOnStartUpToolStripMenuItem.Text = "Settings";
            // 
            // runOnStartUpToolStripMenuItem1
            // 
            this.runOnStartUpToolStripMenuItem1.Name = "runOnStartUpToolStripMenuItem1";
            this.runOnStartUpToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.runOnStartUpToolStripMenuItem1.Text = "Run on start up";
            this.runOnStartUpToolStripMenuItem1.Click += new System.EventHandler(this.runOnStartUpToolStripMenuItem1_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem1.Text = "Close";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerIndecator
            // 
            this.timerIndecator.Tick += new System.EventHandler(this.timerIndecator_Tick);
            // 
            // panelOrganization
            // 
            this.panelOrganization.Controls.Add(this.bunifuFlatButton2);
            this.panelOrganization.Controls.Add(this.bunifuFlatButton1);
            this.panelOrganization.Controls.Add(this.bunifuCustomLabel3);
            this.panelOrganization.Controls.Add(this.TextboxOrganization);
            this.panelOrganization.Location = new System.Drawing.Point(419, 60);
            this.panelOrganization.Name = "panelOrganization";
            this.panelOrganization.Size = new System.Drawing.Size(381, 205);
            this.panelOrganization.TabIndex = 10;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Log In";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(74, 83);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "Log In";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Navy;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Password & Username";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(74, 137);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(241, 30);
            this.bunifuFlatButton2.TabIndex = 9;
            this.bunifuFlatButton2.Text = "Password & Username";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Navy;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Organization";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(84, 244);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(241, 30);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.Text = "Organization";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCards1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Worker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.panelNotify.ResumeLayout(false);
            this.panelNotify.PerformLayout();
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelOrganization.ResumeLayout(false);
            this.panelOrganization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ns1.BunifuFlatButton ButtonLogIn;
        private ns1.BunifuMaterialTextbox TextboxPassword;
        private ns1.BunifuMaterialTextbox TextboxEmail;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelLogIn;
        private ns1.BunifuFlatButton ButtonExit;
        private ns1.BunifuFlatButton ButtonStatus;
        private System.Windows.Forms.ToolStripMenuItem runOnStartUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runOnStartUpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuCircleProgressbar ProgressbarIndicator;
        private System.Windows.Forms.Timer timerIndecator;
        private System.Windows.Forms.Panel panelNotify;
        private ns1.BunifuCustomLabel LabelNotify;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMaterialTextbox TextboxOrganization;
        private System.Windows.Forms.Panel panelOrganization;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton bunifuFlatButton3;
    }
}

