
namespace QuizSistem
{
    partial class SelectQuizForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.selectQuiz = new System.Windows.Forms.ComboBox();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectQuiz
            // 
            this.selectQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.selectQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectQuiz.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.selectQuiz.FormattingEnabled = true;
            this.selectQuiz.Location = new System.Drawing.Point(37, 122);
            this.selectQuiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectQuiz.Name = "selectQuiz";
            this.selectQuiz.Size = new System.Drawing.Size(253, 45);
            this.selectQuiz.TabIndex = 1;
            // 
            // exitBox
            // 
            this.exitBox.Image = global::QuizSistem.Properties.Resources.error;
            this.exitBox.Location = new System.Drawing.Point(281, 12);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(27, 21);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 39;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(85, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Select Quiz";
            // 
            // backBox
            // 
            this.backBox.Image = global::QuizSistem.Properties.Resources._2794686;
            this.backBox.Location = new System.Drawing.Point(12, 12);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(27, 21);
            this.backBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBox.TabIndex = 76;
            this.backBox.TabStop = false;
            this.backBox.Click += new System.EventHandler(this.backBox_Click);
            // 
            // SelectQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.selectQuiz);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelectQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectQuizForm";
            this.Load += new System.EventHandler(this.SelectQuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox selectQuiz;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox backBox;
    }
}