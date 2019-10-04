using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeepPadUI
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //FileCheck();
            hold.Start();
            
            
        }

        private void Fadeout_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                fadeout.Stop();
                this.Hide();
            }
        }

        private void Loadingbar_Click(object sender, EventArgs e)
        {

        }

        public static bool FileCheck()
        {   
            //string file = "C:/code/account.txt";
            //string file = "account.txt"

            if (!File.Exists(signin.fileAcc))
            {
                string message = "Error : \"" + signin.fileAcc + "\" not found!";
                string title = "Unexpected ERROR";
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.Abort)
                {
                    return false;
                }
                else if (result == DialogResult.Retry)
                {
                    // Do nothing  
                    return true;
                }
                else
                {
                    // Do something 
                    return true;
                }
            }
            return true;
        }

        private int _ticks;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 8)
            {
                hold.Stop();
                fadeout.Start();
            }
            loadingbar.PerformStep();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}