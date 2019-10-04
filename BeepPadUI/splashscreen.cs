using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeepPadUI
{
    public partial class splashscreen : UserControl
    {
        public splashscreen()
        {
            InitializeComponent();

            quesbox.Text = recovery1.quesRecovery;
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            /*if (this.Opacity > 0.00)
                this.Opacity -= 0.01;
            else
            {
                this.Close();
            }*/
        }

        

        private void Ansbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool check = false;
            StreamReader sr = new StreamReader(signin.fileAcc);
            string temp = "";
            while ((temp = sr.ReadLine()) != null)
            {
                string[] data = temp.Split(',');
                string username = data[0];
                //string ans = signin.Encrypt.DecryptString(data[3], signin.Encrypt.Key).ToLower();
                string ans = data[3].ToLower();
                if (username.Equals(recovery1.userRecovery))
                { 
                    if (ans.Equals(ansbox.Text.ToLower()))
                    {
                        //string pass = signin.Encrypt.DecryptString(data[1], signin.Encrypt.Key).ToLower();
                        string pass = data[1].ToLower();
                        check = true;
                        MessageBox.Show($"Your password is \n\n{pass}", "Recovery Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        ((Form)this.TopLevelControl).Close();

                        break;
                    }
                }

            }
            sr.Close();
            if(!check)
            {
                MessageBox.Show("Answer is not correct");
            }  
        }

        private void Quesbox_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(signin.fileAcc);

        }

        private void Ansbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Confirm_Click(sender, e);
            }
        }
    }
}