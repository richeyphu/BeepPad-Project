namespace BeepPadUI
{
    partial class splashscreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quesbox = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.ansbox = new System.Windows.Forms.TextBox();
            this.ques = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quesbox
            // 
            this.quesbox.AutoSize = true;
            this.quesbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesbox.ForeColor = System.Drawing.Color.Black;
            this.quesbox.Location = new System.Drawing.Point(96, 106);
            this.quesbox.Name = "quesbox";
            this.quesbox.Size = new System.Drawing.Size(130, 16);
            this.quesbox.TabIndex = 37;
            this.quesbox.Text = "What\'s your name?";
            this.quesbox.Click += new System.EventHandler(this.Quesbox_Click);
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.BackColor = System.Drawing.Color.White;
            this.ans.Font = new System.Drawing.Font("Arial", 9F);
            this.ans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ans.Location = new System.Drawing.Point(51, 142);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(57, 17);
            this.ans.TabIndex = 36;
            this.ans.Text = "Answer";
            // 
            // ansbox
            // 
            this.ansbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ansbox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.ansbox.Location = new System.Drawing.Point(52, 163);
            this.ansbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansbox.MaxLength = 20;
            this.ansbox.Name = "ansbox";
            this.ansbox.Size = new System.Drawing.Size(231, 22);
            this.ansbox.TabIndex = 1;
            this.ansbox.TextChanged += new System.EventHandler(this.Ansbox_TextChanged);
            this.ansbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ansbox_KeyDown);
            // 
            // ques
            // 
            this.ques.AutoSize = true;
            this.ques.BackColor = System.Drawing.Color.White;
            this.ques.Font = new System.Drawing.Font("Arial", 9F);
            this.ques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ques.Location = new System.Drawing.Point(51, 76);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(67, 17);
            this.ques.TabIndex = 34;
            this.ques.Text = "Question";
            // 
            // confirm
            // 
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.confirm.Location = new System.Drawing.Point(110, 212);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(107, 38);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.quesbox);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.ansbox);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.confirm);
            this.Name = "splashscreen";
            this.Size = new System.Drawing.Size(335, 530);
            this.Load += new System.EventHandler(this.Splashscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quesbox;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.TextBox ansbox;
        private System.Windows.Forms.Label ques;
        private System.Windows.Forms.Button confirm;
    }
}
