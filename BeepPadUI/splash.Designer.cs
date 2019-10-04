namespace BeepPadUI
{
    partial class splash
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
            this.Title = new System.Windows.Forms.Label();
            this.fadeout = new System.Windows.Forms.Timer(this.components);
            this.loadingbar = new System.Windows.Forms.ProgressBar();
            this.hold = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.Title.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(268, 156);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 34);
            this.Title.TabIndex = 8;
            this.Title.Text = "BeepPad";
            this.Title.UseWaitCursor = true;
            // 
            // fadeout
            // 
            this.fadeout.Tick += new System.EventHandler(this.Fadeout_Tick);
            // 
            // loadingbar
            // 
            this.loadingbar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loadingbar.Location = new System.Drawing.Point(203, 209);
            this.loadingbar.Margin = new System.Windows.Forms.Padding(2);
            this.loadingbar.Name = "loadingbar";
            this.loadingbar.Size = new System.Drawing.Size(253, 8);
            this.loadingbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingbar.TabIndex = 9;
            this.loadingbar.UseWaitCursor = true;
            this.loadingbar.Click += new System.EventHandler(this.Loadingbar_Click);
            // 
            // hold
            // 
            this.hold.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(660, 348);
            this.Controls.Add(this.loadingbar);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "splash";
            this.Text = "BeepPad - Initializing";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer fadeout;
        private System.Windows.Forms.ProgressBar loadingbar;
        private System.Windows.Forms.Timer hold;
    }
}