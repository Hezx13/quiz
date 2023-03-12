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
            answer1 = new RadioButton();
            answer3 = new RadioButton();
            answer4 = new RadioButton();
            answer2 = new RadioButton();
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
            button1.Location = new Point(98, 514);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(289, 73);
            button1.TabIndex = 0;
            button1.Text = "Answer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button3.Location = new Point(520, 514);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(289, 73);
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
            question.Location = new Point(98, 62);
            question.Margin = new Padding(4, 0, 4, 0);
            question.Name = "question";
            question.Size = new Size(356, 41);
            question.TabIndex = 3;
            question.Text = "Drag file with questions";
            question.Click += question_Click;
            // 
            // answer1
            // 
            answer1.AutoSize = true;
            answer1.FlatStyle = FlatStyle.Flat;
            answer1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            answer1.ForeColor = SystemColors.ButtonFace;
            answer1.Location = new Point(98, 240);
            answer1.Margin = new Padding(4);
            answer1.Name = "answer1";
            answer1.Size = new Size(193, 41);
            answer1.TabIndex = 4;
            answer1.TabStop = true;
            answer1.Text = "radioButton1";
            answer1.UseVisualStyleBackColor = true;
            answer1.Visible = false;
            // 
            // answer3
            // 
            answer3.AutoSize = true;
            answer3.FlatStyle = FlatStyle.Flat;
            answer3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            answer3.ForeColor = SystemColors.ButtonFace;
            answer3.Location = new Point(98, 324);
            answer3.Margin = new Padding(4);
            answer3.Name = "answer3";
            answer3.Size = new Size(193, 41);
            answer3.TabIndex = 5;
            answer3.TabStop = true;
            answer3.Text = "radioButton3";
            answer3.UseVisualStyleBackColor = true;
            answer3.Visible = false;
            // 
            // answer4
            // 
            answer4.AutoSize = true;
            answer4.FlatStyle = FlatStyle.Flat;
            answer4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            answer4.ForeColor = SystemColors.ButtonFace;
            answer4.Location = new Point(98, 366);
            answer4.Margin = new Padding(4);
            answer4.Name = "answer4";
            answer4.Size = new Size(193, 41);
            answer4.TabIndex = 6;
            answer4.TabStop = true;
            answer4.Text = "radioButton4";
            answer4.UseVisualStyleBackColor = true;
            answer4.Visible = false;
            // 
            // answer2
            // 
            answer2.AutoSize = true;
            answer2.FlatStyle = FlatStyle.Flat;
            answer2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            answer2.ForeColor = SystemColors.ButtonFace;
            answer2.Location = new Point(98, 282);
            answer2.Margin = new Padding(4);
            answer2.Name = "answer2";
            answer2.Size = new Size(193, 41);
            answer2.TabIndex = 7;
            answer2.TabStop = true;
            answer2.Text = "radioButton2";
            answer2.UseVisualStyleBackColor = true;
            answer2.Visible = false;
            answer2.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(16, 40, 48);
            ClientSize = new Size(914, 682);
            Controls.Add(answer2);
            Controls.Add(answer4);
            Controls.Add(answer3);
            Controls.Add(answer1);
            Controls.Add(question);
            Controls.Add(button3);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(932, 729);
            MinimumSize = new Size(932, 729);
            Name = "Quiz";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label question;
        private RadioButton answer1;
        private RadioButton answer3;
        private RadioButton answer4;
        private RadioButton answer2;
    }
}