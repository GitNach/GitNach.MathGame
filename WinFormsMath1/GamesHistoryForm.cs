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

    public partial class GamesHistoryForm : Form
    {

        



        public GamesHistoryForm()
        {   
            InitializeComponent();
            dataGridHistory.DataSource = GameHistoryController.History;


        }


        private void showHistory()
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridHistory.DataSource = GameHistoryController.History;

        }

        private void labelHistory_Click(object sender, EventArgs e)
        {

        }
    }

}
