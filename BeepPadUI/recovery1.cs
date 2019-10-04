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
    public partial class recovery1 : Form
    {
        public recovery1()
        {
            InitializeComponent();

            
        }

        private void Recovery1_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public static string userRecovery, quesRecovery;
        private void Confirm_Click(object sender, EventArgs e)
        {
            bool checkfile = false;
            while (!checkfile)
            {
                try
                {
                    checkfile = true;
                    bool check = false;
                    StreamReader sr = new StreamReader(signin.fileAcc);
                    string temp = "";
                    while ((temp = sr.ReadLine()) != null)
                    {
                        string[] data = temp.Split(',');
                        if (data[0].Equals(userbox.Text.ToLower()))
                        {
                            userRecovery = data[0].ToLower();
                            quesRecovery = data[2];

                            user.Hide();
                            userbox.Hide();
                            confirm.Hide();

                            splashscreen uc = new splashscreen();

                            this.Controls.Add(uc);
                            check = true;


                            break;

                        }

                    }
                    sr.Close();
                    if (!check)
                    {
                        MessageBox.Show("Username is not found");
                    }
                }
                catch (IOException)
                {
                    checkfile = false;
                    StreamWriter sw = new StreamWriter(signin.fileAcc);
                    sw.Close();
                }
            }
        }

        private void Toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        Point lastPoint;
        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RecoveryT_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RecoveryT_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Userbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Confirm_Click(sender, e);
            }
        }

        private void Userbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
