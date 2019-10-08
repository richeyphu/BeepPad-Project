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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
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

        private void movedrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void downdrag(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Label1_Click(object sender, EventArgs e)
        {


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Beat_Click(object sender, EventArgs e)
        {

        }

        private void Beatbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Durabox_TextChanged(object sender, EventArgs e) //Setting
        {
            try
            {
                //durabox.Text = Math.Round(Convert.ToDecimal(durabox.Text)).ToString();
                if (Math.Round(Convert.ToDecimal(durabox.Text)) > 1500)
                {
                    durabox.Text = "1500";
                    durabox.SelectionStart = durabox.Text.Length;
                    durabox.SelectionLength = 0;
                }
                else if (Math.Round(Convert.ToDecimal(durabox.Text)) <= 0)
                {
                    durabox.Text = "1";
                    durabox.SelectionStart = durabox.Text.Length;
                    durabox.SelectionLength = 0;
                }
            }
            catch (FormatException) //เกิดข้อผิดพลาดขึ้นใน Text box
            {
                if (durabox.Text.Length == 0)
                {
                    durabox.Text = null;
                }
                else
                {
                    durabox.Text = durabox.Text.Substring(0, durabox.Text.Length - 1);
                    durabox.SelectionStart = durabox.Text.Length;
                    durabox.SelectionLength = 0;
                }
            }
            catch (Exception)
            {

            }
        }

        public static int dura = 250;  //Default Beep Duration
        private void Apply_Click(object sender, EventArgs e)
        {
            if (!durabox.Text.Equals(""))
            {
                try
                {
                    dura = int.Parse(durabox.Text);
                    this.Close();
                }
                catch (FormatException)
                {
                    durabox.Text = durabox.Text.Split('.')[0];
                    dura = int.Parse(durabox.Text);
                    this.Close();
                }
            }
        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void Durabox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Apply_Click(sender, e);
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to\n\"BeepPad 1.0.3 Beta\"\nMake your PC sings\n\nDevelopers :\n1.) Korndanai (1913110019)\n2.) Phurit (1913110027)\n3.) Pongpanot (1913110035)\n4.) Patiparn (1913110183)\n\nIT62@TNI INT-102 Group 3", "About BeepPad");
        }

        private void Preference_Enter(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut Key\n - CTRL + P = Setting\n - CTRL + O = Open File\n - CTRL + S  = Save File\n - CTRL + SHIFT + S = Save File as\n - SHIFT + KEY = High Note", "BeepPad - Help");
        }
    }
}