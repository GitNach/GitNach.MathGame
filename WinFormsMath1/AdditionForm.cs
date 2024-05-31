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
    public partial class AdditionForm : Form
        
    {
        private int _resultQuestions = 0;
        private static int s_questions = 5;
        private int _correctAnswer;
        private (int a, int b)[] questions;
        private int currentQuestionIndex = 0;

        public AdditionForm()
        {
            InitializeComponent();
            labelResult.Visible = false;
            backMenu.Visible = false;   
            generateQuestions();
            ShowQuestion();
        }

        private void generateQuestions()
        {
            Random random = new Random();

            questions = new (int a, int b)[s_questions];
            for (int i = 0; i < s_questions; i++)
            {
                int a = random.Next(1, 100); 
                int b = random.Next(1, 100);
                
                questions[i] = (a, b);
            }

        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex < s_questions)
            {
                var question = questions[currentQuestionIndex];
                labelQstn.Text = $"{question.a} + {question.b} = ?";
                textBoxAnswer.Text = "";
            }
            else { 
                ShowResults();
                backMenu.Visible = true;    
            }
        }




        private void ShowResults()
        {
            labelResult.Text = $"Results: {_resultQuestions}/{s_questions}" ;
            labelResult.Visible = true;
            
        }

        public void checkAnswer(object sender, EventArgs e)
        {
            int userAnswer;
            var question = questions[currentQuestionIndex];
            if (int.TryParse(textBoxAnswer.Text, out userAnswer))
            {   
                if (userAnswer == question.a + question.b) { 
                    _resultQuestions++;
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAnswer.Clear();
            }
            currentQuestionIndex++;
            ShowQuestion();
        }


        public void btnBackToMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
