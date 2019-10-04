namespace BeepPadUI
{
    partial class signin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.signinbutton = new System.Windows.Forms.Button();
            this.userbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.signupbutton = new System.Windows.Forms.Button();
            this.forgot = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.fadeout = new System.Windows.Forms.Timer(this.components);
            this.guest = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signinbutton
            // 
            this.signinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinbutton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.signinbutton.Location = new System.Drawing.Point(83, 204);
            this.signinbutton.Margin = new System.Windows.Forms.Padding(2);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(80, 31);
            this.signinbutton.TabIndex = 5;
            this.signinbutton.Text = "Sign In";
            this.signinbutton.UseVisualStyleBackColor = true;
            this.signinbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // userbox
            // 
            this.userbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.userbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.userbox.Location = new System.Drawing.Point(38, 89);
            this.userbox.Margin = new System.Windows.Forms.Padding(2);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(174, 19);
            this.userbox.TabIndex = 3;
            this.userbox.TextChanged += new System.EventHandler(this.Userbox_TextChanged);
            this.userbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Userbox_KeyDown);
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.passbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.passbox.Location = new System.Drawing.Point(38, 153);
            this.passbox.Margin = new System.Windows.Forms.Padding(2);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.Size = new System.Drawing.Size(174, 19);
            this.passbox.TabIndex = 4;
            this.passbox.TextChanged += new System.EventHandler(this.Passbox_TextChanged);
            this.passbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passbox_KeyDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.title.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(80, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 24);
            this.title.TabIndex = 7;
            this.title.Text = "BeepPad";
            this.title.Click += new System.EventHandler(this.Title_Click);
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.toppanel.Controls.Add(this.exit);
            this.toppanel.Controls.Add(this.title);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(251, 40);
            this.toppanel.TabIndex = 8;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint_1);
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedowndrag);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mousemovedrag);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Arial Black", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(228, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 20);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Button3_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.signupbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.signupbutton.FlatAppearance.BorderSize = 0;
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbutton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.White;
            this.signupbutton.Location = new System.Drawing.Point(0, 407);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(2);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(251, 24);
            this.signupbutton.TabIndex = 7;
            this.signupbutton.Text = "Sign up Here.";
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // forgot
            // 
            this.forgot.FlatAppearance.BorderSize = 0;
            this.forgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgot.Font = new System.Drawing.Font("Arial", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.forgot.Location = new System.Drawing.Point(83, 240);
            this.forgot.Margin = new System.Windows.Forms.Padding(2);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(80, 27);
            this.forgot.TabIndex = 6;
            this.forgot.Text = "Forgot your password?";
            this.forgot.UseVisualStyleBackColor = true;
            this.forgot.Click += new System.EventHandler(this.Forgot_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("Arial", 9F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.user.Location = new System.Drawing.Point(37, 72);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(66, 15);
            this.user.TabIndex = 5;
            this.user.Text = "Username";
            this.user.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Arial", 9F);
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pass.Location = new System.Drawing.Point(37, 135);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(63, 15);
            this.pass.TabIndex = 6;
            this.pass.Text = "Password";
            // 
            // fadeout
            // 
            this.fadeout.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // guest
            // 
            this.guest.FlatAppearance.BorderSize = 0;
            this.guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guest.Font = new System.Drawing.Font("Arial", 8F);
            this.guest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guest.Location = new System.Drawing.Point(84, 378);
            this.guest.Margin = new System.Windows.Forms.Padding(2);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(80, 27);
            this.guest.TabIndex = 6;
            this.guest.Text = "Guest Sign In";
            this.guest.UseVisualStyleBackColor = true;
            this.guest.Click += new System.EventHandler(this.Guest_Click);
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 431);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.signinbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeepPad - Sign In";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button forgot;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Timer fadeout;
        private System.Windows.Forms.Button guest;
    }
}