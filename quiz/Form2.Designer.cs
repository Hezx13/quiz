namespace quiz
{
    partial class results
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
            label1 = new Label();
            label2 = new Label();
            correctAnswBox = new ListBox();
            wrongAnswBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(187, 162, 247);
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(244, 41);
            label1.TabIndex = 0;
            label1.Text = "correct answers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(187, 162, 247);
            label2.Location = new Point(12, 244);
            label2.Name = "label2";
            label2.Size = new Size(237, 41);
            label2.TabIndex = 1;
            label2.Text = "wrong answers:";
            // 
            // correctAnswBox
            // 
            correctAnswBox.BackColor = Color.FromArgb(59, 78, 85);
            correctAnswBox.BorderStyle = BorderStyle.None;
            correctAnswBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            correctAnswBox.ForeColor = Color.FromArgb(113, 214, 142);
            correctAnswBox.FormattingEnabled = true;
            correctAnswBox.ItemHeight = 28;
            correctAnswBox.Location = new Point(305, 88);
            correctAnswBox.Name = "correctAnswBox";
            correctAnswBox.Size = new Size(273, 84);
            correctAnswBox.TabIndex = 2;
            // 
            // wrongAnswBox
            // 
            wrongAnswBox.BackColor = Color.FromArgb(59, 78, 85);
            wrongAnswBox.BorderStyle = BorderStyle.None;
            wrongAnswBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            wrongAnswBox.ForeColor = Color.FromArgb(113, 214, 142);
            wrongAnswBox.FormattingEnabled = true;
            wrongAnswBox.ItemHeight = 28;
            wrongAnswBox.Location = new Point(305, 226);
            wrongAnswBox.Name = "wrongAnswBox";
            wrongAnswBox.Size = new Size(273, 84);
            wrongAnswBox.TabIndex = 3;
            // 
            // results
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(16, 40, 48);
            ClientSize = new Size(619, 413);
            Controls.Add(wrongAnswBox);
            Controls.Add(correctAnswBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(637, 460);
            MinimumSize = new Size(637, 460);
            Name = "results";
            Text = "results";
            FormClosed += results_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox correctAnswBox;
        private ListBox wrongAnswBox;
    }
}