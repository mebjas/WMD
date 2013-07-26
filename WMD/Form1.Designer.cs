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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domain
            // 
            this.domain.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(521, 67);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 28);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(723, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(771, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tmplog);
            this.Controls.Add(this.clearlogbutton);
            this.Controls.Add(this.savelogbutton);
            this.Controls.Add(this.log);
            this.Controls.Add(this.button);
            this.Controls.Add(this.mainlabel);
            this.Controls.Add(this.domain);
            this.Name = "Form1";
            this.Text = "WMD: Web Media Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button1;
    }
}

