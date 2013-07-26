namespace WMD
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
            this.domain = new System.Windows.Forms.TextBox();
            this.mainlabel = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.savelogbutton = new System.Windows.Forms.Button();
            this.clearlogbutton = new System.Windows.Forms.Button();
            this.tmplog = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tASKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pASTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oNLINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sITEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_online = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // domain
            // 
            this.domain.BackColor = System.Drawing.Color.SandyBrown;
            this.domain.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domain.Location = new System.Drawing.Point(101, 67);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(414, 28);
            this.domain.TabIndex = 0;
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainlabel.Location = new System.Drawing.Point(96, 38);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(247, 26);
            this.mainlabel.TabIndex = 1;
            this.mainlabel.Text = "Enter domain name:";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(521, 67);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 28);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.Green;
            this.log.Location = new System.Drawing.Point(13, 150);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(746, 288);
            this.log.TabIndex = 4;
            this.log.Text = " ";
            // 
            // savelogbutton
            // 
            this.savelogbutton.Location = new System.Drawing.Point(13, 444);
            this.savelogbutton.Name = "savelogbutton";
            this.savelogbutton.Size = new System.Drawing.Size(75, 23);
            this.savelogbutton.TabIndex = 5;
            this.savelogbutton.Text = "Save logs";
            this.savelogbutton.UseVisualStyleBackColor = true;
            // 
            // clearlogbutton
            // 
            this.clearlogbutton.Location = new System.Drawing.Point(94, 444);
            this.clearlogbutton.Name = "clearlogbutton";
            this.clearlogbutton.Size = new System.Drawing.Size(75, 23);
            this.clearlogbutton.TabIndex = 6;
            this.clearlogbutton.Text = "clear logs";
            this.clearlogbutton.UseVisualStyleBackColor = true;
            this.clearlogbutton.Click += new System.EventHandler(this.clearlogbutton_Click);
            // 
            // tmplog
            // 
            this.tmplog.AutoSize = true;
            this.tmplog.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplog.ForeColor = System.Drawing.Color.Red;
            this.tmplog.Location = new System.Drawing.Point(349, 43);
            this.tmplog.Name = "tmplog";
            this.tmplog.Size = new System.Drawing.Size(0, 22);
            this.tmplog.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.tASKSToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.rESETToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.eXITToolStripMenuItem1});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nEWToolStripMenuItem.Text = "NEW";
            // 
            // rESETToolStripMenuItem
            // 
            this.rESETToolStripMenuItem.Name = "rESETToolStripMenuItem";
            this.rESETToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.rESETToolStripMenuItem.Text = "RESET";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.eXITToolStripMenuItem.Text = "RECENT SEARCHES";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUTToolStripMenuItem,
            this.cOPYToolStripMenuItem,
            this.pASTEToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // tASKSToolStripMenuItem
            // 
            this.tASKSToolStripMenuItem.Name = "tASKSToolStripMenuItem";
            this.tASKSToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tASKSToolStripMenuItem.Text = "TASKS";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem1,
            this.oNLINEToolStripMenuItem,
            this.sITEToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // eXITToolStripMenuItem1
            // 
            this.eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            this.eXITToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.eXITToolStripMenuItem1.Text = "EXIT";
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cUTToolStripMenuItem.Text = "CUT";
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOPYToolStripMenuItem.Text = "COPY";
            // 
            // pASTEToolStripMenuItem
            // 
            this.pASTEToolStripMenuItem.Name = "pASTEToolStripMenuItem";
            this.pASTEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pASTEToolStripMenuItem.Text = "PASTE";
            // 
            // aBOUTToolStripMenuItem1
            // 
            this.aBOUTToolStripMenuItem1.Name = "aBOUTToolStripMenuItem1";
            this.aBOUTToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aBOUTToolStripMenuItem1.Text = "ABOUT";
            // 
            // oNLINEToolStripMenuItem
            // 
            this.oNLINEToolStripMenuItem.Name = "oNLINEToolStripMenuItem";
            this.oNLINEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oNLINEToolStripMenuItem.Text = "ONLINE";
            // 
            // sITEToolStripMenuItem
            // 
            this.sITEToolStripMenuItem.Name = "sITEToolStripMenuItem";
            this.sITEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sITEToolStripMenuItem.Text = "SITE";
            // 
            // label_online
            // 
            this.label_online.AutoSize = true;
            this.label_online.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_online.ForeColor = System.Drawing.Color.Gray;
            this.label_online.Location = new System.Drawing.Point(175, 439);
            this.label_online.Name = "label_online";
            this.label_online.Size = new System.Drawing.Size(109, 26);
            this.label_online.TabIndex = 9;
            this.label_online.Text = "You are online";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(771, 471);
            this.Controls.Add(this.label_online);
            this.Controls.Add(this.tmplog);
            this.Controls.Add(this.clearlogbutton);
            this.Controls.Add(this.savelogbutton);
            this.Controls.Add(this.log);
            this.Controls.Add(this.button);
            this.Controls.Add(this.mainlabel);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WMD: Web Media Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button savelogbutton;
        private System.Windows.Forms.Button clearlogbutton;
        private System.Windows.Forms.Label tmplog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tASKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pASTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oNLINEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sITEToolStripMenuItem;
        private System.Windows.Forms.Label label_online;
    }
}

