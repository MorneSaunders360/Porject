
namespace Worker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCards1 = new ns1.BunifuCards();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TextboxEmail = new ns1.BunifuMaterialTextbox();
            this.TextboxPassword = new ns1.BunifuMaterialTextbox();
            this.ButtonLogIn = new ns1.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Navy;
            this.bunifuCards1.Controls.Add(this.ButtonLogIn);
            this.bunifuCards1.Controls.Add(this.TextboxPassword);
            this.bunifuCards1.Controls.Add(this.TextboxEmail);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(800, 450);
            this.bunifuCards1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 76);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Exit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Reset";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
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
            this.TextboxEmail.Location = new System.Drawing.Point(209, 50);
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
            this.TextboxPassword.Location = new System.Drawing.Point(209, 114);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(370, 44);
            this.TextboxPassword.TabIndex = 3;
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.ButtonLogIn.Location = new System.Drawing.Point(275, 202);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCards1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ns1.BunifuFlatButton ButtonLogIn;
        private ns1.BunifuMaterialTextbox TextboxPassword;
        private ns1.BunifuMaterialTextbox TextboxEmail;
    }
}

