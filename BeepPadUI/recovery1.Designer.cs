namespace BeepPadUI
{
    partial class recovery1
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
            this.user = new System.Windows.Forms.Label();
            this.userbox = new System.Windows.Forms.TextBox();
            this.toppanel = new System.Windows.Forms.Panel();
            this.recoveryT = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("Arial", 9F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.user.Location = new System.Drawing.Point(38, 64);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(66, 15);
            this.user.TabIndex = 7;
            this.user.Text = "Username";
            // 
            // userbox
            // 
            this.userbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.userbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.userbox.Location = new System.Drawing.Point(38, 81);
            this.userbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userbox.MaxLength = 20;
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(174, 19);
            this.userbox.TabIndex = 1;
            this.userbox.TextChanged += new System.EventHandler(this.Userbox_TextChanged);
            this.userbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Userbox_KeyDown);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.toppanel.Controls.Add(this.recoveryT);
            this.toppanel.Controls.Add(this.close);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(251, 24);
            this.toppanel.TabIndex = 20;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Toppanel_Paint);
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toppanel_MouseMove);
            // 
            // recoveryT
            // 
            this.recoveryT.AutoSize = true;
            this.recoveryT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryT.ForeColor = System.Drawing.Color.White;
            this.recoveryT.Location = new System.Drawing.Point(9, 6);
            this.recoveryT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recoveryT.Name = "recoveryT";
            this.recoveryT.Size = new System.Drawing.Size(121, 15);
            this.recoveryT.TabIndex = 20;
            this.recoveryT.Text = "Password Recovery";
            this.recoveryT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecoveryT_MouseDown);
            this.recoveryT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RecoveryT_MouseMove);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Arial Black", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(230, 0);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // confirm
            // 
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.confirm.Location = new System.Drawing.Point(82, 140);
            this.confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(80, 31);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // recovery1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 431);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.user);
            this.Controls.Add(this.userbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "recovery1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeepPad - Recovery";
            this.Load += new System.EventHandler(this.Recovery1_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label recoveryT;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button confirm;
    }
}