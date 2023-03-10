namespace quiz
{
    partial class Quiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button3 = new Button();
            question = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(113, 214, 142);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(113, 214, 142);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(71, 470);
            button1.Name = "button1";
            button1.Size = new Size(210, 52);
            button1.TabIndex = 0;
            button1.Text = "Answer";
            button1.UseVisualStyleBackColor = false;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(113, 214, 142);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(113, 214, 142);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(384, 470);
            button3.Name = "button3";
            button3.Size = new Size(210, 52);
            button3.TabIndex = 2;
            button3.Text = "Show Answer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // question
            // 
            question.AutoSize = true;
            question.BackColor = Color.Transparent;
            question.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            question.ForeColor = Color.FromArgb(187, 162, 247);
            question.Location = new Point(71, 44);
            question.Name = "question";
            question.Size = new Size(141, 41);
            question.TabIndex = 3;
            question.Text = "question";
            question.Click += question_Click;
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 40, 48);
            ClientSize = new Size(665, 586);
            Controls.Add(question);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Quiz";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label question;
    }
}