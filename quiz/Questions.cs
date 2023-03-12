using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Questions
    {
        public Dictionary<int, string> questions;
        Dictionary<int, List<string>> answers;
        List<string> correctAnswers;
        public Questions() { 
            questions = new Dictionary<int, string>();
            answers = new Dictionary<int, List<string>>();
            correctAnswers = new List<string>();
        }

        public void AddQuiz(string[] text)
        {
            List<string> tempAnswers = new List<string>();
            foreach (string line in text){
                if (line[0] == '#'){
                    questions.Add(Convert.ToInt32(line[1])-49, line.Substring(2));   
                }   
                if (line[0] == '\t' && questions.Count > 0){
                    tempAnswers.Add(line.Substring(1));
                }
                if (line[0] == '-'){
                    correctAnswers.Add(line.Substring(1));
                    answers.Add(questions.Count -1,new List<string>(tempAnswers));
                    tempAnswers.Clear();
                }
        }
        
        }

        private void RemoveQuiz(string text) { }

        public int GetCorrectAnswer(int key) {
            return Convert.ToInt32(correctAnswers[key]);
        }

        public void GetQuestion(int key) {

        }

        public int GetOptionsCount(int key) { 
            if (key < answers.Count)
                return answers[key].Count;

            return 0;    
            }
        public string[] GetAnswers(int key) {
            if (key < answers.Count){
                List<string> list = answers[key];
                return list.ToArray();
                }
            return null;
        }
    }
}
