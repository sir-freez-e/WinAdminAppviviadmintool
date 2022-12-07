using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Diagnostics;
=======
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
using System.Windows.Forms;

namespace WinAdminApp
{
    public partial class Mainapp : Form
    {
        public Mainapp()
        {
            InitializeComponent();
            
        }

       

        private void Mainapp_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
<<<<<<< HEAD

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("onedrivefix.reg");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ResetNetwork.bat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ResetWinUpdate.bat");
        }
=======
>>>>>>> 92bfaf1fe102e7dbd4e0209ba183823b9a7a81ca
    }
}