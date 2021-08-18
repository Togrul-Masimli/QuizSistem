
namespace QuizSistem
{
    partial class StudentForm
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
            this.solvedQuizesBtn = new System.Windows.Forms.Button();
            this.quizBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logoutBox = new System.Windows.Forms.PictureBox();
            this.studentLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // solvedQuizesBtn
            // 
            this.solvedQuizesBtn.BackgroundImage = global::QuizSistem.Properties.Resources._3407037;
            this.solvedQuizesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.solvedQuizesBtn.FlatAppearance.BorderSize = 0;
            this.solvedQuizesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solvedQuizesBtn.Location = new System.Drawing.Point(237, 75);
            this.solvedQuizesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.solvedQuizesBtn.Name = "solvedQuizesBtn";
            this.solvedQuizesBtn.Size = new System.Drawing.Size(125, 100);
            this.solvedQuizesBtn.TabIndex = 3;
            this.solvedQuizesBtn.UseVisualStyleBackColor = true;
            this.solvedQuizesBtn.Click += new System.EventHandler(this.solvedQuizesBtn_Click);
            // 
            // quizBtn
            // 
            this.quizBtn.BackgroundImage = global::QuizSistem.Properties.Resources.solvequiz;
            this.quizBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quizBtn.FlatAppearance.BorderSize = 0;
            this.quizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizBtn.Location = new System.Drawing.Point(41, 75);
            this.quizBtn.Margin = new System.Windows.Forms.Padding(2);
            this.quizBtn.Name = "quizBtn";
            this.quizBtn.Size = new System.Drawing.Size(125, 100);
            this.quizBtn.TabIndex = 2;
            this.quizBtn.UseVisualStyleBackColor = true;
            this.quizBtn.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = global::QuizSistem.Properties.Resources.settings__1_;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(41, 243);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(125, 100);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Solve Quiz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(205, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 55;
            this.label3.Text = "Solved Quizes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 32);
            this.label4.TabIndex = 56;
            this.label4.Text = "Settings";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuizSistem.Properties.Resources.error;
            this.pictureBox2.Location = new System.Drawing.Point(361, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // logoutBox
            // 
            this.logoutBox.Image = global::QuizSistem.Properties.Resources.logout1;
            this.logoutBox.Location = new System.Drawing.Point(328, 12);
            this.logoutBox.Name = "logoutBox";
            this.logoutBox.Size = new System.Drawing.Size(27, 21);
            this.logoutBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutBox.TabIndex = 58;
            this.logoutBox.TabStop = false;
            this.logoutBox.Click += new System.EventHandler(this.logoutBox_Click);
            // 
            // studentLbl
            // 
            this.studentLbl.AutoSize = true;
            this.studentLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.studentLbl.Location = new System.Drawing.Point(254, 12);
            this.studentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(57, 21);
            this.studentLbl.TabIndex = 57;
            this.studentLbl.Text = "label5";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logoutBox);
            this.Controls.Add(this.studentLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.solvedQuizesBtn);
            this.Controls.Add(this.quizBtn);
            this.Controls.Add(this.updateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button quizBtn;
        private System.Windows.Forms.Button solvedQuizesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logoutBox;
        private System.Windows.Forms.Label studentLbl;
    }
}