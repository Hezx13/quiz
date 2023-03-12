using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class results : Form
    {
        public results()
        {
            InitializeComponent();
        }

        public void LoadStatistics(List<bool> answers)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                switch (answers[i])
                {
                    case true:
                        correctAnswBox.Items.Add(i + 1);
                        break;
                    case false:
                        wrongAnswBox.Items.Add(i + 1);
                        break;
                    default:
                        Application.Exit();
                        break;
                }
            }
        }

        private void results_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

