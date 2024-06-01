using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMath1
{
    public partial class DivisionForm : Form
    {
        private int _resultQuestions = 0;
        private static int s_numQuestions = 5;
        private (int a, int b)[] questions;  
        private int currentQuestionIndex = 0;
        public DivisionForm()
        {
            InitializeComponent();
            labelScoreDivision.Hide();
            generateQuestions();
            ShowQuestion();
        }

        private void generateQuestions()
        {
            Random random = new Random();

            questions = new (int a, int b)[s_numQuestions];
            for (int i = 0; i < s_numQuestions; i++)
            {
                int a = random.Next(1, 100);
                int b = random.Next(1, 100);

                while (a % b != 0) 
                {
                    a = random.Next(1, 99);
                    b = random.Next(1, 99);
                }


                questions[i] = (a, b);
            }

        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex < s_numQuestions)
            {
                var question = questions[currentQuestionIndex];
                labelQstnDivision.Text = $"{question.a} / {question.b} = ?";
                textBoxDivision.Text = "";
            }
            else
            {
                ShowResults();

            }
        }




        private void ShowResults()
        {
            labelScoreDivision.Text = $"Results: {_resultQuestions}/{s_numQuestions}";
            labelScoreDivision.Visible = true;

        }


        public void checkAnswer(object sender, EventArgs e)
        {
            int userAnswer;
            var question = questions[currentQuestionIndex];
            if (int.TryParse(textBoxDivision.Text, out userAnswer))
            {
                if (userAnswer == question.a / question.b)
                {
                    _resultQuestions++;
                }
                currentQuestionIndex++;
                ShowQuestion();

            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDivision.Clear();

            }

        }


        private void DivisionForm_Load(object sender, EventArgs e)
        {

        }

        private void backToMenuDivision_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
