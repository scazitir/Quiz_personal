using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_personal
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnFiveQuestions_Click(object sender, EventArgs e)
        {
            // Open the QuizForm with 5 questions
            Form1 quizForm = new Form1(5);
            quizForm.Show();
            this.Hide();  // Optionally hide the StartForm
        }

        private void btnTenQuestions_Click(object sender, EventArgs e)
        {
            // Open the QuizForm with 10 questions
            Form1 quizForm = new Form1(10);
            quizForm.Show();
            this.Hide();  // Optionally hide the StartForm
        }
    }
}
