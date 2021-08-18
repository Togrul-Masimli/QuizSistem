
namespace QuizSistem
{
    partial class SolveTestForm
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
            this.quizName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerDCheck = new System.Windows.Forms.CheckBox();
            this.answerBCheck = new System.Windows.Forms.CheckBox();
            this.answerCCheck = new System.Windows.Forms.CheckBox();
            this.answerACheck = new System.Windows.Forms.CheckBox();
            this.testBody = new System.Windows.Forms.Label();
            this.testTitle = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.backBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quizName
            // 
            this.quizName.AutoSize = true;
            this.quizName.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizName.Location = new System.Drawing.Point(325, 40);
            this.quizName.Name = "quizName";
            this.quizName.Size = new System.Drawing.Size(144, 27);
            this.quizName.TabIndex = 0;
            this.quizName.Text = "Quiz Name";
            this.quizName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.answerDCheck);
            this.panel1.Controls.Add(this.answerBCheck);
            this.panel1.Controls.Add(this.answerCCheck);
            this.panel1.Controls.Add(this.answerACheck);
            this.panel1.Controls.Add(this.testBody);
            this.panel1.Controls.Add(this.testTitle);
            this.panel1.Location = new System.Drawing.Point(81, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 298);
            this.panel1.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(545, 247);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(85, 35);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            // 
            // answerDCheck
            // 
            this.answerDCheck.AutoSize = true;
            this.answerDCheck.Location = new System.Drawing.Point(349, 163);
            this.answerDCheck.Name = "answerDCheck";
            this.answerDCheck.Size = new System.Drawing.Size(116, 21);
            this.answerDCheck.TabIndex = 5;
            this.answerDCheck.Text = "answerDCheck";
            this.answerDCheck.UseVisualStyleBackColor = true;
            this.answerDCheck.CheckedChanged += new System.EventHandler(this.answerDCheck_CheckedChanged);
            // 
            // answerBCheck
            // 
            this.answerBCheck.AutoSize = true;
            this.answerBCheck.Location = new System.Drawing.Point(347, 107);
            this.answerBCheck.Name = "answerBCheck";
            this.answerBCheck.Size = new System.Drawing.Size(114, 21);
            this.answerBCheck.TabIndex = 4;
            this.answerBCheck.Text = "answerBCheck";
            this.answerBCheck.UseVisualStyleBackColor = true;
            this.answerBCheck.CheckedChanged += new System.EventHandler(this.answerBCheck_CheckedChanged);
            // 
            // answerCCheck
            // 
            this.answerCCheck.AutoSize = true;
            this.answerCCheck.Location = new System.Drawing.Point(39, 163);
            this.answerCCheck.Name = "answerCCheck";
            this.answerCCheck.Size = new System.Drawing.Size(114, 21);
            this.answerCCheck.TabIndex = 3;
            this.answerCCheck.Text = "answerCCheck";
            this.answerCCheck.UseVisualStyleBackColor = true;
            this.answerCCheck.CheckedChanged += new System.EventHandler(this.answerCCheck_CheckedChanged);
            // 
            // answerACheck
            // 
            this.answerACheck.AutoSize = true;
            this.answerACheck.Location = new System.Drawing.Point(40, 106);
            this.answerACheck.Name = "answerACheck";
            this.answerACheck.Size = new System.Drawing.Size(115, 21);
            this.answerACheck.TabIndex = 2;
            this.answerACheck.Text = "answerACheck";
            this.answerACheck.UseVisualStyleBackColor = true;
            this.answerACheck.CheckedChanged += new System.EventHandler(this.answerACheck_CheckedChanged);
            // 
            // testBody
            // 
            this.testBody.AutoSize = true;
            this.testBody.Location = new System.Drawing.Point(17, 59);
            this.testBody.Name = "testBody";
            this.testBody.Size = new System.Drawing.Size(68, 17);
            this.testBody.TabIndex = 1;
            this.testBody.Text = "Test Body";
            // 
            // testTitle
            // 
            this.testTitle.AutoSize = true;
            this.testTitle.Location = new System.Drawing.Point(17, 20);
            this.testTitle.Name = "testTitle";
            this.testTitle.Size = new System.Drawing.Size(65, 17);
            this.testTitle.TabIndex = 0;
            this.testTitle.Text = "Test Title";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(272, 388);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(246, 46);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // exitBox
            // 
            this.exitBox.Image = global::QuizSistem.Properties.Resources.error;
            this.exitBox.Location = new System.Drawing.Point(761, 12);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(27, 21);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 73;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // backBox
            // 
            this.backBox.Image = global::QuizSistem.Properties.Resources._2794686;
            this.backBox.Location = new System.Drawing.Point(12, 12);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(27, 21);
            this.backBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBox.TabIndex = 74;
            this.backBox.TabStop = false;
            this.backBox.Click += new System.EventHandler(this.backBox_Click);
            // 
            // SolveTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quizName);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolveTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolveTestForm";
            this.Load += new System.EventHandler(this.SolveTestForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quizName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox answerDCheck;
        private System.Windows.Forms.CheckBox answerBCheck;
        private System.Windows.Forms.CheckBox answerCCheck;
        private System.Windows.Forms.CheckBox answerACheck;
        private System.Windows.Forms.Label testBody;
        private System.Windows.Forms.Label testTitle;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox backBox;
    }
}