using Transitions;
using System.Reflection;

namespace quiz
{
    public partial class Quiz : Form
    {   
        public int questionsCount = 0;
        public int[] correctAnswers;
        RadioButton[] radioButtons;
        Questions questions;
        public Quiz()
        {
            InitializeComponent();
            radioButtons = InitializeArray<RadioButton>(4);
            radioButtons[0] = answer1;
            radioButtons[1] = answer2;
            radioButtons[2] = answer3;
            radioButtons[3] = answer4;
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Quiz_DragEnter);
            this.DragDrop += new DragEventHandler(Quiz_DragDrop);
        }

        T[] InitializeArray<T>(int length) where T : new()
        {
            T[] array = new T[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new T();
            }

            return array;
        }

        //
        // DRAG & DROP LOGIC
        //
        private void Quiz_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Quiz_DragDrop(object sender, DragEventArgs e)
        {
            Questions questions = new Questions();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] text = null;
            foreach (string file in files) text = System.IO.File.ReadAllLines(file);
            if (text != null)
            {
                questions.AddQuiz(text);
            }
            LoadQuestion(questions);
        }
        
        private void LoadQuestion(Questions data)
        {
            if (data.questions.Count >= questionsCount){
                question.Text = data.questions[questionsCount];
                string[] answers = data.GetAnswers(questionsCount);
                for (int i = 0; i < data.GetOptionsCount(questionsCount); i++){
                    try {
                    radioButtons[i].Text = answers[i];
                    radioButtons[i].Visible = true;
                    } catch (IndexOutOfRangeException){

                    }
                }
                questionsCount++;

            } else {}


        }

        //
        // ----------------------V I S U A L S---------------------- //
        //

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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}