namespace BeepPadUI
{
    partial class Setting
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.settingT = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.duration = new System.Windows.Forms.Label();
            this.preference = new System.Windows.Forms.GroupBox();
            this.apply = new System.Windows.Forms.Button();
            this.durabox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.preference.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.toppanel.Controls.Add(this.settingT);
            this.toppanel.Controls.Add(this.close);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(200, 24);
            this.toppanel.TabIndex = 19;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move);
            // 
            // settingT
            // 
            this.settingT.AutoSize = true;
            this.settingT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingT.ForeColor = System.Drawing.Color.White;
            this.settingT.Location = new System.Drawing.Point(9, 4);
            this.settingT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingT.Name = "settingT";
            this.settingT.Size = new System.Drawing.Size(47, 15);
            this.settingT.TabIndex = 20;
            this.settingT.Text = "Setting";
            this.settingT.Click += new System.EventHandler(this.Label1_Click);
            this.settingT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.downdrag);
            this.settingT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movedrag);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Arial Black", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(179, 1);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Button17_Click);
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(59, 44);
            this.duration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(62, 16);
            this.duration.TabIndex = 20;
            this.duration.Text = "Duration";
            // 
            // preference
            // 
            this.preference.Controls.Add(this.apply);
            this.preference.Controls.Add(this.durabox);
            this.preference.Controls.Add(this.label1);
            this.preference.Controls.Add(this.duration);
            this.preference.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.preference.Location = new System.Drawing.Point(9, 38);
            this.preference.Margin = new System.Windows.Forms.Padding(2);
            this.preference.Name = "preference";
            this.preference.Padding = new System.Windows.Forms.Padding(2);
            this.preference.Size = new System.Drawing.Size(182, 192);
            this.preference.TabIndex = 1;
            this.preference.TabStop = false;
            this.preference.Text = "Keyboard preference";
            this.preference.Enter += new System.EventHandler(this.Preference_Enter);
            // 
            // apply
            // 
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(50, 145);
            this.apply.Margin = new System.Windows.Forms.Padding(2);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(80, 31);
            this.apply.TabIndex = 2;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // durabox
            // 
            this.durabox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.durabox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.durabox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.durabox.Location = new System.Drawing.Point(56, 77);
            this.durabox.Margin = new System.Windows.Forms.Padding(2);
            this.durabox.MaxLength = 4;
            this.durabox.Name = "durabox";
            this.durabox.Size = new System.Drawing.Size(66, 23);
            this.durabox.TabIndex = 23;
            this.durabox.Text = "250";
            this.durabox.TextChanged += new System.EventHandler(this.Durabox_TextChanged);
            this.durabox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Durabox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ms";
            this.label1.Click += new System.EventHandler(this.Duration_Click);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.Font = new System.Drawing.Font("Arial", 8F);
            this.help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.help.Location = new System.Drawing.Point(58, 239);
            this.help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(28, 14);
            this.help.TabIndex = 3;
            this.help.Text = "Help";
            this.help.Click += new System.EventHandler(this.Help_Click);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Font = new System.Drawing.Font("Arial", 8F);
            this.about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.about.Location = new System.Drawing.Point(103, 239);
            this.about.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(36, 14);
            this.about.TabIndex = 4;
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(200, 262);
            this.Controls.Add(this.preference);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.about);
            this.Controls.Add(this.help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeepPad - Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.preference.ResumeLayout(false);
            this.preference.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label settingT;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.GroupBox preference;
        private System.Windows.Forms.TextBox durabox;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label about;
    }
}