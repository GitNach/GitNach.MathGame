using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMath1.Controllers;

namespace WinFormsMath1
{
    public partial class SubtractForm : Form
    {
        private int _resultQuestions = 0;
        private static int s_numQuestions = 5;
        private (int a, int b)[] questions;
        private int currentQuestionIndex;

        public SubtractForm()
        {
            InitializeComponent();
            labelScoreSubtract.Hide();
            generateQuestions();
            showQuestions();

        }

        private void generateQuestions()
        {
            Random random = new Random();

            questions = new (int a, int b)[s_numQuestions];
            for (int i = 0; i < s_numQuestions; i++)
            {
                int a = random.Next(0, 100);
                int b = random.Next(0, 100);
                questions[i] = (a, b);
            }
        }

        private void showQuestions()
        {
            if (currentQuestionIndex < s_numQuestions)
            {
                var question = questions[currentQuestionIndex];

                labelQstnSubtract.Text = $"{question.a} - {question.b} = ?";
                textBoxSubtract.Text = "";
            }
            else
            {
                GameHistoryController.History.Add(new()
                {
                    Date = DateTime.Now,
                    Score = _resultQuestions,
                    Type = Model.GameHistory.GameType.Subtraction,

                });
                showResult();
            }

        }

        private void showResult()
        {
            labelScoreSubtract.Text = $"Results: {_resultQuestions}/{s_numQuestions}";
            labelScoreSubtract.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int userAnswer;
            var question = questions[currentQuestionIndex];
            if (int.TryParse(textBoxSubtract.Text, out userAnswer))
            {
                if (userAnswer == question.a - question.b)
                {
                    _resultQuestions++;
                }
                currentQuestionIndex++; 
                showQuestions();


            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSubtract.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
