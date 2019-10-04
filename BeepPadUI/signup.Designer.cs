namespace BeepPadUI
{
    partial class signup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.userbox = new System.Windows.Forms.TextBox();
            this.passcon = new System.Windows.Forms.Label();
            this.passconbox = new System.Windows.Forms.TextBox();
            this.signupbutton = new System.Windows.Forms.Button();
            this.ques = new System.Windows.Forms.Label();
            this.questionbox = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.Label();
            this.answerbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 40);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Arial Black", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(228, 2);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 8;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.Title.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(80, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(90, 24);
            this.Title.TabIndex = 7;
            this.Title.Text = "BeepPad";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.downdrag);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.downmove);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Arial", 9F);
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pass.Location = new System.Drawing.Point(40, 118);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(63, 15);
            this.pass.TabIndex = 13;
            this.pass.Text = "Password";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("Arial", 9F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.user.Location = new System.Drawing.Point(40, 63);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(66, 15);
            this.user.TabIndex = 12;
            this.user.Text = "Username";
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.passbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.passbox.Location = new System.Drawing.Point(42, 136);
            this.passbox.Margin = new System.Windows.Forms.Padding(2);
            this.passbox.MaxLength = 20;
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(174, 19);
            this.passbox.TabIndex = 11;
            this.passbox.TextChanged += new System.EventHandler(this.Passbox_TextChanged);
            this.passbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passbox_KeyDown);
            // 
            // userbox
            // 
            this.userbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.userbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.userbox.Location = new System.Drawing.Point(42, 80);
            this.userbox.Margin = new System.Windows.Forms.Padding(2);
            this.userbox.MaxLength = 20;
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(174, 19);
            this.userbox.TabIndex = 10;
            this.userbox.TextChanged += new System.EventHandler(this.Userbox_TextChanged);
            this.userbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Userbox_KeyDown);
            // 
            // passcon
            // 
            this.passcon.AutoSize = true;
            this.passcon.Font = new System.Drawing.Font("Arial", 9F);
            this.passcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.passcon.Location = new System.Drawing.Point(39, 176);
            this.passcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passcon.Name = "passcon";
            this.passcon.Size = new System.Drawing.Size(110, 15);
            this.passcon.TabIndex = 15;
            this.passcon.Text = "Confirm Password";
            this.passcon.Click += new System.EventHandler(this.Label3_Click);
            // 
            // passconbox
            // 
            this.passconbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.passconbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passconbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.passconbox.Location = new System.Drawing.Point(42, 193);
            this.passconbox.Margin = new System.Windows.Forms.Padding(2);
            this.passconbox.MaxLength = 20;
            this.passconbox.Name = "passconbox";
            this.passconbox.Size = new System.Drawing.Size(174, 19);
            this.passconbox.TabIndex = 12;
            this.passconbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passconbox_KeyDown);
            // 
            // signupbutton
            // 
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbutton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.signupbutton.Location = new System.Drawing.Point(83, 356);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(2);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(80, 31);
            this.signupbutton.TabIndex = 15;
            this.signupbutton.Text = "Sign up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.Login_Click_1);
            // 
            // ques
            // 
            this.ques.AutoSize = true;
            this.ques.Font = new System.Drawing.Font("Arial", 9F);
            this.ques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ques.Location = new System.Drawing.Point(40, 235);
            this.ques.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(95, 15);
            this.ques.TabIndex = 18;
            this.ques.Text = "Secret Question";
            // 
            // questionbox
            // 
            this.questionbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.questionbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.questionbox.Location = new System.Drawing.Point(42, 251);
            this.questionbox.Margin = new System.Windows.Forms.Padding(2);
            this.questionbox.MaxLength = 50;
            this.questionbox.Name = "questionbox";
            this.questionbox.Size = new System.Drawing.Size(174, 19);
            this.questionbox.TabIndex = 13;
            this.questionbox.TextChanged += new System.EventHandler(this.Questionbox_TextChanged);
            this.questionbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Questionbox_KeyDown);
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Font = new System.Drawing.Font("Arial", 9F);
            this.ans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ans.Location = new System.Drawing.Point(40, 291);
            this.ans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(48, 15);
            this.ans.TabIndex = 20;
            this.ans.Text = "Answer";
            // 
            // answerbox
            // 
            this.answerbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.answerbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.answerbox.Location = new System.Drawing.Point(42, 307);
            this.answerbox.Margin = new System.Windows.Forms.Padding(2);
            this.answerbox.MaxLength = 20;
            this.answerbox.Name = "answerbox";
            this.answerbox.Size = new System.Drawing.Size(174, 19);
            this.answerbox.TabIndex = 14;
            this.answerbox.TextChanged += new System.EventHandler(this.Answerbox_TextChanged);
            this.answerbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Answerbox_KeyDown);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 431);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.answerbox);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.questionbox);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.passcon);
            this.Controls.Add(this.passconbox);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeepPad - Sign Up";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Label passcon;
        private System.Windows.Forms.TextBox passconbox;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Label ques;
        private System.Windows.Forms.TextBox questionbox;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.TextBox answerbox;
    }
}