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
using System.Security.Cryptography;

namespace BeepPadUI
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void down(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void downdrag(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void downmove(object sender, MouseEventArgs e)
        {

                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastPoint.X;
                    this.Top += e.Y - lastPoint.Y;
                }

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

       

        private void Questionbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Answerbox_TextChanged(object sender, EventArgs e)
        {

        }

        public static class Account
        {
            public static void SignUp(string user, string pass, string question, string ans)
            {
                StreamWriter sw = new StreamWriter(signin.fileAcc, true);
                //string passEnc = signin.Encrypt.EncryptString(pass, signin.Encrypt.Key);
                //string ansEnc = signin.Encrypt.EncryptString(ans, signin.Encrypt.Key);
                sw.WriteLine(user + "," + pass + "," + question + "," + ans); //Secure Login DISABLE
                //sw.WriteLine(user + "," + passEnc + "," + question + "," + ansEnc); //Secure Login ENABLE
                sw.Close();

                //Create a User Folder
                string path = user;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            string user, pass, passCon, question, ans;
            user = userbox.Text.ToLower();
            pass = passbox.Text;
            passCon = passconbox.Text;
            question = this.questionbox.Text;
            ans = answerbox.Text;

            string title = "Please try again...";

            bool check = false;

            while (!check)
            {
                try
                {
                    check = true;
                    StreamReader sr = new StreamReader(signin.fileAcc);
                    string temp = "";
                    bool dupUser = false;
                    while ((temp = sr.ReadLine()) != null)
                    {
                        string userCheck = temp.Split(',')[0];
                        if (userCheck.Equals(user))
                        {
                            dupUser = true;
                            break;
                        }
                    }
                    sr.Close();

                    if (user.Equals("") || pass.Equals("") || question.Equals("") || ans.Equals(""))
                    {
                        MessageBox.Show("Please fill in your information completely", title);
                    }
                    else if (user.Contains(",") || pass.Contains(",") || question.Contains(",") || ans.Contains(","))
                    {
                        MessageBox.Show("Field must not contain any special character : ','", title);
                    }
                    else if (dupUser)
                    {
                        MessageBox.Show("Username has been already taken...", title);
                    }
                    else if (!pass.Equals(passCon))
                    {
                        MessageBox.Show("Password is not matched...", title);
                    }
                    else
                    {
                        Account.SignUp(user, pass, question, ans);
                        MessageBox.Show("Account created!", "Completed");
                        this.Close();
                    }
                }
                catch (IOException)
                {
                    check = false;
                    StreamWriter sw = new StreamWriter(signin.fileAcc);
                    sw.Close();
                }
            }
        }

        private void Userbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click_1(sender, e);
            }
        }

        private void Passbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click_1(sender, e);
            }
        }

        private void Passconbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click_1(sender, e);
            }
        }

        private void Questionbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click_1(sender, e);
            }
        }

        private void Answerbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click_1(sender, e);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}