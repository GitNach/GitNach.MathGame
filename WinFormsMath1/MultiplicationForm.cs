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
    public partial class MultiplicationForm : Form
    {
        private int _resultQuestions = 0;
        private static int s_numQuestions = 5;
        private (int a, int b)[] questions;  //Create a method called getQuestions, so i don't have to write that long line all the time.
        private int currentQuestionIndex = 0;
        public MultiplicationForm()
        {
            InitializeComponent();
            labelScoreMultiplication.Visible = false;
            generateQuestions();
            ShowQuestion();
        }

        

        private void generateQuestions()
        {
            Random random = new Random();

            questions = new (int a, int b)[s_numQuestions];
            for (int i = 0; i < s_numQuestions; i++)
            {
                int a = random.Next(1, 15);
                int b = random.Next(1, 10);

                questions[i] = (a, b);
            }

        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex < s_numQuestions)
            {
                var question = questions[currentQuestionIndex];
                labelQstnMultiplication.Text = $"{question.a} * {question.b} = ?";
                textBoxMultiplication.Text = "";
            }
            else
            {
                ShowResults();

            }
        }




        private void ShowResults()
        {
            labelScoreMultiplication.Text = $"Results: {_resultQuestions}/{s_numQuestions}";
            labelScoreMultiplication.Visible = true;

        }




        

        private void checkAnswer(object sender, EventArgs e)
        {
            int userAnswer;
            var question = questions[currentQuestionIndex];
            if (int.TryParse(textBoxMultiplication.Text, out userAnswer))
            {
                if (userAnswer == question.a * question.b)
                {
                    _resultQuestions++;
                }
                currentQuestionIndex++;
                ShowQuestion();

            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMultiplication.Clear();

            }

        }

        

        public void btnBackToMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
