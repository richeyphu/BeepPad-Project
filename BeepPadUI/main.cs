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
using System.Threading;

namespace BeepPadUI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                StreamReader sr = new StreamReader(signin.username + "\\" + "temp_" + signin.username + ".rec");
                string temp = "";
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (data[0].Equals(signin.username))
                    {
                        melody.Text = data[1];
                        break;
                    }

                }
                sr.Close();
            }
            catch (IOException)
            {
                string path = signin.username;
                if (path == null)
                {

                }
                else if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);

                    StreamWriter sw = new StreamWriter(signin.username + "\\" + "temp_" + signin.username + ".rec", false);
                    sw.Close();
                }

                
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e) //Exit Program
        {
            checkStop = true;
            Thread.Sleep(300);

            bool check = false;

            if (signin.username != null)
            {
                while (!check)
                {
                    try
                    {
                        check = true;

                        StreamWriter sw = new StreamWriter(signin.username + "\\" + "temp_" + signin.username + ".rec", false);

                        sw.WriteLine(signin.username + "," + melody.Text);

                        sw.Close();
                    }
                    catch (DirectoryNotFoundException)
                    {
                        check = false;

                        string path = signin.username;
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                    }
                }
            }

            Application.Exit();
        }

        private void down(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

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


        private void Button21_Click(object sender, EventArgs e) //Settings Button
        {
            bool openned = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "BeepPad - Setting")
                {
                    openned = true;
                    form.BringToFront();
                    break;
                }
            }
            if (openned == false)
            {
                Setting set = new Setting();
                set.Show();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Signout_Click(object sender, EventArgs e) //Sign Out Button
        {
            checkStop = true;
            melody.Text = null;
            signin.username = null;
            signin signinn = new signin();
            signinn.Show();
            Setting set = new Setting();
            set.Close();
            this.Hide();
        }
        
        public static class Note //Beep Systems
        {
            public static void Freq(int i)
            {
                int[] note = { 262, 277, 294, 311, 330, 349, 367, 392, 415, 440, 466, 494,/**/ 523, 554, 587, 622, 659, 698, 740, 784, 831, 880, 932, 987 };
                // Octave 4 (0-11) : C, C#, D, D#, E, F, F#, G, G#, A, A#, B
                // Octave 5 (12-23): C, C#, D, D#, E, F, F#, G, G#, A, A#, B
                Beep(note[i]);

            }
            public static void Beep(int freq)
            {
                
                Console.Beep(freq, Setting.dura);
            }
        }

        //Keyboard
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "a";
                //Note.Freq(0);
                Thread beep = new Thread(new ThreadStart(Beep0));
                beep.Start();
            }
            else
            {
                melody.Text += "A";
                Thread beep = new Thread(new ThreadStart(Beep12));
                beep.Start();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "w";
                //Note.Freq(1);
                Thread beep = new Thread(new ThreadStart(Beep1));
                beep.Start();
            }
            else
            {
                melody.Text += "W";
                Thread beep = new Thread(new ThreadStart(Beep13));
                beep.Start();
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "s";
                //Note.Freq(2);
                Thread beep = new Thread(new ThreadStart(Beep2));
                beep.Start();
            }
            else
            {
                melody.Text += "S";
                Thread beep = new Thread(new ThreadStart(Beep14));
                beep.Start();
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "e";
                //Note.Freq(3);
                Thread beep = new Thread(new ThreadStart(Beep3));
                beep.Start();
            }
            else
            {
                melody.Text += "E";
                Thread beep = new Thread(new ThreadStart(Beep15));
                beep.Start();
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "d";
                //Note.Freq(4);
                Thread beep = new Thread(new ThreadStart(Beep4));
                beep.Start();
            }
            else
            {
                melody.Text += "D";
                Thread beep = new Thread(new ThreadStart(Beep16));
                beep.Start();
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "f";
                //Note.Freq(5);
                Thread beep = new Thread(new ThreadStart(Beep5));
                beep.Start();
            }
            else
            {
                melody.Text += "F";
                Thread beep = new Thread(new ThreadStart(Beep17));
                beep.Start();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "t";
                //Note.Freq(6);
                Thread beep = new Thread(new ThreadStart(Beep6));
                beep.Start();
            }
            else
            {
                melody.Text += "T";
                Thread beep = new Thread(new ThreadStart(Beep18));
                beep.Start();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "g";
                //Note.Freq(7);
                Thread beep = new Thread(new ThreadStart(Beep7));
                beep.Start();
            }
            else
            {
                melody.Text += "G";
                Thread beep = new Thread(new ThreadStart(Beep19));
                beep.Start();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "y";
                //Note.Freq(8);
                Thread beep = new Thread(new ThreadStart(Beep8));
                beep.Start();
            }
            else
            {
                melody.Text += "Y";
                Thread beep = new Thread(new ThreadStart(Beep20));
                beep.Start();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "h";
                //Note.Freq(9);
                Thread beep = new Thread(new ThreadStart(Beep9));
                beep.Start();
            }
            else
            {
                melody.Text += "H";
                Thread beep = new Thread(new ThreadStart(Beep21));
                beep.Start();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "u";
                //Note.Freq(10);
                Thread beep = new Thread(new ThreadStart(Beep10));
                beep.Start();
            }
            else
            {
                melody.Text += "U";
                Thread beep = new Thread(new ThreadStart(Beep22));
                beep.Start();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (page.Text.Equals("Page 1"))
            {
                melody.Text += "j";
                //Note.Freq(11);
                Thread beep = new Thread(new ThreadStart(Beep11));
                beep.Start();
            }
            else
            {
                melody.Text += "J";
                Thread beep = new Thread(new ThreadStart(Beep23));
                beep.Start();
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            melody.Text += " ";
        }
        
        private void keydown(object sender, KeyEventArgs e)
        {
            Thread kd0 = new Thread(new ThreadStart(Beep0));
            Thread kd1 = new Thread(new ThreadStart(Beep1));
            Thread kd2 = new Thread(new ThreadStart(Beep2));
            Thread kd3 = new Thread(new ThreadStart(Beep3));
            Thread kd4 = new Thread(new ThreadStart(Beep4));
            Thread kd5 = new Thread(new ThreadStart(Beep5));
            Thread kd6 = new Thread(new ThreadStart(Beep6));
            Thread kd7 = new Thread(new ThreadStart(Beep7));
            Thread kd8 = new Thread(new ThreadStart(Beep8));
            Thread kd9 = new Thread(new ThreadStart(Beep9));
            Thread kd10 = new Thread(new ThreadStart(Beep10));
            Thread kd11 = new Thread(new ThreadStart(Beep11));

            Thread kd12 = new Thread(new ThreadStart(Beep12));
            Thread kd13 = new Thread(new ThreadStart(Beep13));
            Thread kd14 = new Thread(new ThreadStart(Beep14));
            Thread kd15 = new Thread(new ThreadStart(Beep15));
            Thread kd16 = new Thread(new ThreadStart(Beep16));
            Thread kd17 = new Thread(new ThreadStart(Beep17));
            Thread kd18 = new Thread(new ThreadStart(Beep18));
            Thread kd19 = new Thread(new ThreadStart(Beep19));
            Thread kd20 = new Thread(new ThreadStart(Beep20));
            Thread kd21 = new Thread(new ThreadStart(Beep21));
            Thread kd22 = new Thread(new ThreadStart(Beep22));
            Thread kd23 = new Thread(new ThreadStart(Beep23));

            //Thread kd10 = new Thread(new ThreadStart(Beep10));
            //Thread kd10 = new Thread(new ThreadStart(Beep10));

            //Thread.CurrentThread.Priority = ThreadPriority.Highest;

            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                Button19_Click(sender, e);
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                Save_Click(sender, e);
                if (signin.username != null)
                {
                    MessageBox.Show("Project has been saved!", "Project Saved!");
                }
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                Saveas_Click(sender, e);
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
            {
                Button21_Click(sender, e);
            }
            else
            {
                if (e.Modifiers == Keys.Shift)
                {
                    ButtonToUpper();
                }

                //And
                switch (e.KeyCode) //Thread Mode 
                {
                    //Octave 4
                    case Keys.A: if (e.Modifiers == Keys.Shift) { kd12.Start(); } else { kd0.Start(); }; break;
                    case Keys.W: if (e.Modifiers == Keys.Shift) { kd13.Start(); } else { kd1.Start(); }; break;
                    case Keys.S: if (e.Modifiers == Keys.Shift) { kd14.Start(); } else { kd2.Start(); }; break;
                    case Keys.E: if (e.Modifiers == Keys.Shift) { kd15.Start(); } else { kd3.Start(); }; break;
                    case Keys.D: if (e.Modifiers == Keys.Shift) { kd16.Start(); } else { kd4.Start(); }; break;
                    case Keys.F: if (e.Modifiers == Keys.Shift) { kd17.Start(); } else { kd5.Start(); }; break;
                    case Keys.T: if (e.Modifiers == Keys.Shift) { kd18.Start(); } else { kd6.Start(); }; break;
                    case Keys.G: if (e.Modifiers == Keys.Shift) { kd19.Start(); } else { kd7.Start(); }; break;
                    case Keys.Y: if (e.Modifiers == Keys.Shift) { kd20.Start(); } else { kd8.Start(); }; break;
                    case Keys.H: if (e.Modifiers == Keys.Shift) { kd21.Start(); } else { kd9.Start(); }; break;
                    case Keys.U: if (e.Modifiers == Keys.Shift) { kd22.Start(); } else { kd10.Start(); }; break;
                    case Keys.J: if (e.Modifiers == Keys.Shift) { kd23.Start(); } else { kd11.Start(); }; break;
                        //Octave 5 
                        /*
                        case Keys.A | Keys.Shift: kd12.Start(); break;
                        case Keys.W | Keys.Shift: kd13.Start(); break;
                        case Keys.S | Keys.Shift: kd14.Start(); break;
                        case Keys.E | Keys.Shift: kd15.Start(); break;
                        case Keys.D | Keys.Shift: kd16.Start(); break;
                        case Keys.F | Keys.Shift: kd17.Start(); break;
                        case Keys.T | Keys.Shift: kd18.Start(); break;
                        case Keys.G | Keys.Shift: kd19.Start(); break;
                        case Keys.Y | Keys.Shift: kd20.Start(); break;
                        case Keys.H | Keys.Shift: kd21.Start(); break;
                        case Keys.U | Keys.Shift: kd22.Start(); break;
                        case Keys.J | Keys.Shift: kd23.Start(); break;*/
                }
            }

            /*switch (e.KeyCode)
            {
                case Keys.A: Note.Freq(0); break;
                case Keys.W: Note.Freq(1); break;
                case Keys.S: Note.Freq(2); break;
                case Keys.E: Note.Freq(3); break;
                case Keys.D: Note.Freq(4); break;
                case Keys.F: Note.Freq(5); break;
                case Keys.T: Note.Freq(6); break;
                case Keys.G: Note.Freq(7); break;
                case Keys.Y: Note.Freq(8); break;
                case Keys.H: Note.Freq(9); break;
                case Keys.U: Note.Freq(10); break;
                case Keys.J: Note.Freq(11); break;
            }
            */
            /*
            if (e.KeyCode == Keys.A) 
            {
                Note.Freq(0);
            }
            else if (e.KeyCode == Keys.W)
            {
                Note.Freq(1);
            }
            else if (e.KeyCode == Keys.S)
            {
                Note.Freq(2);
            }
            else if (e.KeyCode == Keys.E)
            {
                Note.Freq(3);
            }
            else if (e.KeyCode == Keys.D)
            {
                Note.Freq(4);
            }
            else if (e.KeyCode == Keys.F)
            {
                Note.Freq(5);
            }
            else if (e.KeyCode == Keys.T)
            {
                Note.Freq(6);
            }
            else if (e.KeyCode == Keys.G)
            {
                Note.Freq(7);
            }
            else if (e.KeyCode == Keys.Y)
            {
                Note.Freq(8);
            }
            else if (e.KeyCode == Keys.H)
            {
                Note.Freq(9);
            }
            else if (e.KeyCode == Keys.U)
            {
                Note.Freq(10);
            }
            else if (e.KeyCode == Keys.J)
            {
                Note.Freq(11);
            }
            */
        }
        //Thread Beeps System
        void Beep0() //Octave 4
        {
            Note.Freq(0);
        }
        void Beep1()
        {
            Note.Freq(1);
        }
        void Beep2()
        {
            Note.Freq(2);
        }
        void Beep3()
        {
            Note.Freq(3);
        }
        void Beep4()
        {
            Note.Freq(4);
        }
        void Beep5()
        {
            Note.Freq(5);
        }
        void Beep6()
        {
            Note.Freq(6);
        }
        void Beep7()
        {
            Note.Freq(7);
        }
        void Beep8()
        {
            Note.Freq(8);
        }
        void Beep9()
        {
            Note.Freq(9);
        }
        void Beep10()
        {
            Note.Freq(10);
        }
        void Beep11() //Octave 5
        {
            Note.Freq(11);
        }
        void Beep12()
        {
            Note.Freq(12);
        }
        void Beep13()
        {
            Note.Freq(13);
        }
        void Beep14()
        {
            Note.Freq(14);
        }
        void Beep15()
        {
            Note.Freq(15);
        }
        void Beep16()
        {
            Note.Freq(16);
        }
        void Beep17()
        {
            Note.Freq(17);
        }
        void Beep18()
        {
            Note.Freq(18);
        }
        void Beep19()
        {
            Note.Freq(19);
        }
        void Beep20()
        {
            Note.Freq(20);
        }
        void Beep21()
        {
            Note.Freq(21);
        }
        void Beep22()
        {
            Note.Freq(22);
        }
        void Beep23()
        {
            Note.Freq(23);
        }

        private void Button19_Click(object sender, EventArgs e) //Open File Click
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(), signin.username);
                open.InitialDirectory = CombinedPath;
                open.Title = "Open a Project";
                open.Filter = "BeepPad Project File|*.bpad"; //|All files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(open.FileName);

                    melody.Text = null;

                    string temp = "";
                    while ((temp = read.ReadLine()) != null)
                    {
                        melody.Text += temp;
                    }

                    string[] projNameData = open.FileName.Split('\\');
                    string projName = projNameData[projNameData.Length - 1];
                    projectname.Text = projName.Substring(0, projName.Length - 5);

                    read.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Sign In before openning a file...", "Error!");
            }
        }

        private void Saveas_Click(object sender, EventArgs e) //Save as Click
        {
            //using (var fbd = new FolderBrowserDialog())
            {
                // Displays a SaveFileDialog so the user can save the Project
                // assigned to Button2.
                try
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(), signin.username);
                    saveFileDialog1.InitialDirectory = CombinedPath;
                    saveFileDialog1.Filter = "BeepPad Project File|*.bpad"; //|All files (*.*)|*.*";
                    saveFileDialog1.Title = "Save as a Project";
                    saveFileDialog1.FileName = String.Format("{0}.bpad", projectname.Text);

                    saveFileDialog1.ShowDialog();

                    // If the file name is not an empty string open it for saving.
                    if (saveFileDialog1.FileName != "")
                    {
                        string[] projNameData = saveFileDialog1.FileName.Split('\\');
                        string projName = projNameData[projNameData.Length - 1];
                        projectname.Text = projName.Substring(0, projName.Length - 5);

                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                        sw.WriteLine(melody.Text);

                        sw.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Sign In before saving...", "Error!");
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (signin.username == null)
            {
                MessageBox.Show("Please Sign In before saving...", "Error!");
            }
            else
            {
                StreamWriter sw = new StreamWriter(signin.username + "\\" + projectname.Text + ".bpad", false);
                sw.WriteLine(melody.Text);

                sw.Close();
            }
        }

        private void Melody_TextChanged(object sender, EventArgs e) //Check last character is a note key?
        {
            try
            {
                char lastKey = melody.Text.Last();

                switch (lastKey)
                {
                    case ' ':
                    case 'a':
                    case 'w':
                    case 's':
                    case 'e':
                    case 'd':
                    case 'f':
                    case 't':
                    case 'g':
                    case 'y':
                    case 'h':
                    case 'u':
                    case 'j':
                    
                    case 'A':
                    case 'W':
                    case 'S':
                    case 'E':
                    case 'D':
                    case 'F':
                    case 'T':
                    case 'G':
                    case 'Y':
                    case 'H':
                    case 'U':
                    case 'J':
                        break;
                    default:
                        melody.Text = melody.Text.Substring(0, melody.Text.Length - 1);
                        melody.SelectionStart = melody.Text.Length;
                        melody.SelectionLength = 0;
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        bool checkPlay = false;
        bool checkPause = false;
        private void Play_Click(object sender, EventArgs e) //Play Button
        {
            Thread _play = new Thread(new ThreadStart(Play));
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            //play.Priority = ThreadPriority.Highest;

            if (checkPause) //Pause clicked
            {
                _play.Start();
                play.Text = "Pause";
            }
            else if (!checkPlay) //first Play or after Stop clicked
            {
                _play.Start();
                checkPlay = true; //Played - prevent iteration play

                play.Text = "Pause";
                checkPause = false;
            }
            else //first Pause clicked
            {
                checkStop = true; //Stop playing the melody
                checkPause = true; //Pause Clicked
                play.Text = "Play";
            }

            //Play();

            /*
            int select = 0;
            string noteScore = melody.Text;
            foreach (char note in noteScore)
            {
                if (checkStop)
                {
                    break;
                }

                melody.HideSelection = false;
                melody.Select(select, 1);
                select++;

                Thread.Sleep(100);
            }
            */
        }

        /*
        void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            int select = 0;
            string noteScore = melody.Text;
            foreach (char note in noteScore)
            {
                if (checkStop)
                {
                    break;
                }

                melody.HideSelection = false;
                melody.Select(select, 1);
                select++;

                Thread.Sleep(100);
            }
        }
        */
        int pausePos;
        void Play()
        {
            checkStop = false; //Prevent duplicate Pause
            checkPlay = true; //Prevent duplicate Play

            int select = 0;
            string noteScore = "";

            if (!checkPause) //First Play or after Stop clicked
            {
                noteScore = melody.Text;
            }
            else //Play after Pause clicked
            {
                select = pausePos;
                noteScore = melody.Text.Substring(pausePos, melody.Text.Length - pausePos);
                checkPause = false;
            }
            //AppendTextBox();

            foreach (char note in noteScore)
            {
                if (checkStop)
                {
                    break;
                }

                //melody.HideSelection = false;
                //melody.Select(select, 1);
                //select++;

                this.Invoke((MethodInvoker)delegate ()
                {
                    melody.HideSelection = false;
                    melody.Select(select, 1);
                    select++;
                });

                switch (note)
                {
                    //Octave 4
                    case 'a': Note.Freq(0); break;
                    case 'w': Note.Freq(1); break;
                    case 's': Note.Freq(2); break;
                    case 'e': Note.Freq(3); break;
                    case 'd': Note.Freq(4); break;
                    case 'f': Note.Freq(5); break;
                    case 't': Note.Freq(6); break;
                    case 'g': Note.Freq(7); break;
                    case 'y': Note.Freq(8); break;
                    case 'h': Note.Freq(9); break;
                    case 'u': Note.Freq(10); break;
                    case 'j': Note.Freq(11); break;
                    //Octave 5
                    case 'A': Note.Freq(12); break;
                    case 'W': Note.Freq(13); break;
                    case 'S': Note.Freq(14); break;
                    case 'E': Note.Freq(15); break;
                    case 'D': Note.Freq(16); break;
                    case 'F': Note.Freq(17); break;
                    case 'T': Note.Freq(18); break;
                    case 'G': Note.Freq(19); break;
                    case 'Y': Note.Freq(20); break;
                    case 'H': Note.Freq(21); break;
                    case 'U': Note.Freq(22); break;
                    case 'J': Note.Freq(23); break;

                    default: Thread.Sleep(Setting.dura); break;
                }

                Thread.Sleep(100);
            }

            this.Invoke((MethodInvoker)delegate ()
            {
                play.Text = "Play";

                if (checkPause)
                {
                    melody.HideSelection = false;
                    pausePos = select;
                }
                else
                {
                    melody.HideSelection = true;
                }
            });

            checkPlay = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Projectname_DoubleClick(object sender, EventArgs e)
        {
            changeName.Text = projectname.Text;
            changeName.Show();
        }

        private void ChangeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && !changeName.Text.Equals(""))
            {
                projectname.Text = changeName.Text;
                changeName.Hide();
            }
        }

        private void ChangeName_Click(object sender, EventArgs e)
        {
            changeName.SelectAll();
        }

        bool checkStop = false;
        private void Pause_Click(object sender, EventArgs e)
        {
            melody.HideSelection = true;
            checkStop = true;
            checkPause = false;
        }

        private void Button16_Click(object sender, EventArgs e) //Previous Page
        {
            page.Text = "Page 1";
            ButtonToLower();
        }

        private void Button15_Click_1(object sender, EventArgs e) //Next Page
        {
            page.Text = "Page 2";
            ButtonToUpper();
        }

        private void ButtonToLower()
        {
            button1.Text = button1.Text.ToLower(); //a
            button3.Text = button3.Text.ToLower(); //w
            button12.Text = button12.Text.ToLower(); //s
            button11.Text = button11.Text.ToLower(); //e
            button10.Text = button10.Text.ToLower(); //d
            button9.Text = button9.Text.ToLower(); //f
            button8.Text = button8.Text.ToLower(); //t
            button7.Text = button7.Text.ToLower(); //g
            button6.Text = button6.Text.ToLower(); //y
            button5.Text = button5.Text.ToLower(); //h
            button4.Text = button4.Text.ToLower(); //u
            button2.Text = button2.Text.ToLower(); //j
        }
        private void ButtonToUpper()
        {
            button1.Text = button1.Text.ToUpper(); //A
            button3.Text = button3.Text.ToUpper(); //W
            button12.Text = button12.Text.ToUpper(); //S
            button11.Text = button11.Text.ToUpper(); //E
            button10.Text = button10.Text.ToUpper(); //D
            button9.Text = button9.Text.ToUpper(); //F
            button8.Text = button8.Text.ToUpper(); //T
            button7.Text = button7.Text.ToUpper(); //G
            button6.Text = button6.Text.ToUpper(); //Y
            button5.Text = button5.Text.ToUpper(); //H
            button4.Text = button4.Text.ToUpper(); //U
            button2.Text = button2.Text.ToUpper(); //J
        }

        private void Melody_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers != Keys.Shift)
            {
                ButtonToLower();
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Newproject_Click(object sender, EventArgs e) //Clear clicked
        {
            melody.Text = null;
        }
    }
}