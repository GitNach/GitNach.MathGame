namespace WinFormsMath1
{
    public partial class MathGame : Form
    {
        public MathGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciamos la nueva form
            AdditionForm additionForm = new AdditionForm();

            //Ocultamos la anterior form (el menu)
            this.Hide();

            //Mostramos la nueva form (el addition game)
            additionForm.ShowDialog();

            //Cerramos la nueva form
            this.Show();
        }

        private void MathGame_Load(object sender, EventArgs e)
        {

        }
    }
}
