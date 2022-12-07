namespace WinAdminApp
{
    partial class Mainapp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainapp));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Show = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
=======
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
<<<<<<< HEAD
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
=======
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit,
            this.Show});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
<<<<<<< HEAD
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 52);
=======
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
<<<<<<< HEAD
            this.Exit.Size = new System.Drawing.Size(114, 24);
=======
            this.Exit.Size = new System.Drawing.Size(103, 22);
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Show
            // 
            this.Show.Name = "Show";
<<<<<<< HEAD
            this.Show.Size = new System.Drawing.Size(114, 24);
            this.Show.Text = "Show";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reset Network";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset OneDrive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "GP Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "WMI Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(179, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "MS Outook Fix";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(179, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 29);
            this.button6.TabIndex = 1;
            this.button6.Text = "Clear Creds";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(179, 277);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 29);
            this.button7.TabIndex = 1;
            this.button7.Text = "Clear Cache";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(179, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 29);
            this.button8.TabIndex = 1;
            this.button8.Text = "Reset WinUpdate";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mainapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 318);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
=======
            this.Show.Size = new System.Drawing.Size(103, 22);
            this.Show.Text = "Show";
            // 
            // Mainapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 382);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
            this.Name = "Mainapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vivid Admin Tool";
            this.Load += new System.EventHandler(this.Mainapp_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem Show;
<<<<<<< HEAD
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
=======
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
    }
}