namespace BeepPadUI
{
    partial class recovery2
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
            this.recoveryT = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Label();
            this.ansbox = new System.Windows.Forms.TextBox();
            this.quesbox = new System.Windows.Forms.Label();
            this.ques = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
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
            this.toppanel.Size = new System.Drawing.Size(274, 24);
            this.toppanel.TabIndex = 21;
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
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Arial Black", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(254, 0);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 19;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.confirm.Location = new System.Drawing.Point(98, 155);
            this.confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(80, 31);
            this.confirm.TabIndex = 22;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.BackColor = System.Drawing.Color.White;
            this.ans.Font = new System.Drawing.Font("Arial", 9F);
            this.ans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ans.Location = new System.Drawing.Point(54, 98);
            this.ans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(48, 15);
            this.ans.TabIndex = 26;
            this.ans.Text = "Answer";
            // 
            // ansbox
            // 
            this.ansbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ansbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.ansbox.Location = new System.Drawing.Point(55, 115);
            this.ansbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ansbox.MaxLength = 20;
            this.ansbox.Name = "ansbox";
            this.ansbox.Size = new System.Drawing.Size(174, 19);
            this.ansbox.TabIndex = 25;
            // 
            // quesbox
            // 
            this.quesbox.AutoSize = true;
            this.quesbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesbox.ForeColor = System.Drawing.Color.Black;
            this.quesbox.Location = new System.Drawing.Point(88, 69);
            this.quesbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quesbox.Name = "quesbox";
            this.quesbox.Size = new System.Drawing.Size(100, 14);
            this.quesbox.TabIndex = 27;
            this.quesbox.Text = "What\'s your name?";
            // 
            // ques
            // 
            this.ques.AutoSize = true;
            this.ques.BackColor = System.Drawing.Color.White;
            this.ques.Font = new System.Drawing.Font("Arial", 9F);
            this.ques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ques.Location = new System.Drawing.Point(54, 45);
            this.ques.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(57, 15);
            this.ques.TabIndex = 24;
            this.ques.Text = "Question";
            // 
            // recovery2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 206);
            this.Controls.Add(this.quesbox);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.ansbox);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "recovery2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Recovery2_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label recoveryT;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.TextBox ansbox;
        private System.Windows.Forms.Label quesbox;
        private System.Windows.Forms.Label ques;
    }
}