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
using System.Threading;

namespace BeepPadUI
{
    public partial class signin : Form
    {
        public signin()
        {
           
            InitializeComponent();
        }

        public static string username;
        public void Button1_Click(object sender, EventArgs e)
        {
            string user = userbox.Text.ToLower();
            string pass = passbox.Text;
            username = userbox.Text;

            string title = "Please try again...";

            if (Account.SignIn(user, pass))
            {
                fadeout.Start();

                //this.Hide();


                foreach (Form form in Application.OpenForms)
                {
                    if (form.Text == "signup")
                    {
                        form.Hide();
                        break;
                    }
                }
            }

            
            //MessageBox.Show("Welcome to BeepPad");

            else if (user.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Please enter your Username and Password...", title);
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect...", title);
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*main piano = new main();
            piano.Hide();*/
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void mousemovedrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        Point lastPoint;
        private void mousedowndrag(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void down(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            bool openned = false;
            foreach(Form form in Application.OpenForms)
            {
                if (form.Text == "BeepPad - Sign Up")
                {
                    openned = true;
                    form.BringToFront();
                    break;
                }
            }
            if (openned == false)
            {
                signup reg = new signup();
                reg.Show();
            }
        }

        public void Userbox_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void Passbox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.5;
            }
            else
            {
                fadeout.Stop();

                main form = new main();
                splash splash = new splash();
        
                form.Show();
                splash.Show();

                /*notification noti = new notification();
                noti.Show();*/
                this.Hide();
            }
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            bool openned = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text=="BeepPad - Recovery")
                {
                    openned = true;
                    form.BringToFront();
                    break;
                }
            }
            if (openned == false)
            {
                recovery1 recovery = new recovery1();
                recovery.Show();
            }
        }

        //panel1.BackColor = Color.FromArgb(255, 192, 192);
        //Text 255, 192, 192 
        //Text input 254, 226, 254
        //piano buttom 254, 233, 254

        //Default 'Account' file location
        public static string fileAcc = "account.acc"; 
        public static class Account
        {
            //private string Key = "Phu"
            public static bool SignIn(string user,string pass)
            {
                bool check = false;

                try
                {
                    StreamReader sr = new StreamReader(fileAcc);
                    string temp = "";
                    while ((temp = sr.ReadLine()) != null)
                    {
                        string[] data = temp.Split(',');
                        if (data[0].Equals(user) && data[1].Equals(pass)) //Secure Login DISABLE
                        //string passDec = Encrypt.DecryptString(data[1], Encrypt.Key); //Secure Login ENABLE
                        //if (data[0].Equals(user) && passDec.Equals(pass))
                        {
                            check = true;
                            break;
                        }

                    }
                    sr.Close();
                }
                catch (IOException)
                {
                    StreamWriter createFile = new StreamWriter(fileAcc);
                    createFile.Close();
                }
                return check;
            }     
        }

        private void Passbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, e);
            }
        }

        private void Userbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, e);
            }
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            username = userbox.Text = null;
            fadeout.Start();
        }

        public static class Encrypt
        {
            public static string EncryptString(string plainText)
            {
                string textShift = "";
                foreach (char t in plainText)
                {
                    if (t <= 90)
                    {
                        textShift += (t + 24);
                    }
                    if (t > 90)
                    {
                        textShift += (t - 24);
                    }
                }
                return textShift;
            }
            public static string DecryptString(string cipherText)
            {
                string textShift = "";
                foreach (char t in cipherText)
                {
                    if (t <= 114)
                    {
                        textShift += (t - 24);
                    }
                    if (t > 66)
                    {
                        textShift += (t + 24);
                    }
                }
                return textShift;
            }
        }

        //Encryption Decryption Algorithms (Rijindael)
        /*
        public static class Encrypt
        {
            //Secret Key
            public static string Key = "PhuritStangFah-INT-102-Sec1-2019";

            // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
            // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
            private const string initVector = "i8WoRy4NakJD7ey2";
            // This constant is used to determine the keysize of the encryption algorithm
            private const int keysize = 256;
            //Encrypt
            public static string EncryptString(string plainText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return Convert.ToBase64String(cipherTextBytes);
            }
            //Decrypt
            public static string DecryptString(string cipherText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
        }
        */
    }
}