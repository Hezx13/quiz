using System.Drawing;
using Transitions;

namespace quiz
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Quiz_DragEnter);
            this.DragDrop += new DragEventHandler(Quiz_DragDrop);
        }

        void Quiz_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Quiz_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) question.Text = file;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            var t = new Transition(new TransitionType_EaseInEaseOut(300));
            t.add(button1, "BackColor", Color.FromArgb(255, 187, 162, 247));
            t.add(button1, "ForeColor", Color.Black);
            t.run();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            var t = new Transition(new TransitionType_EaseInEaseOut(300));
            t.add(button1, "BackColor", Color.FromArgb(255, 113, 214, 142));
            t.add(button1, "ForeColor", Color.White);
            t.run();
            button1.BackColor = Color.FromArgb(1, 113, 214, 142);
            button1.ForeColor = Color.White;

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            var t = new Transition(new TransitionType_EaseInEaseOut(300));
            t.add(button3, "BackColor", Color.FromArgb(255, 187, 162, 247));
            t.add(button3, "ForeColor", Color.Black);
            t.run();

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            var t = new Transition(new TransitionType_EaseInEaseOut(300));
            t.add(button3, "BackColor", Color.FromArgb(255, 113, 214, 142));
            t.add(button3, "ForeColor", Color.White);
            t.run();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void question_Click(object sender, EventArgs e)
        {

        }
    }
}