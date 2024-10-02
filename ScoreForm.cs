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
    public partial class ScoreForm : Form
    {
        public ScoreForm(int score, int totalQuestions)
        {
            InitializeComponent();
            lblScore.Text = $"You got {score} out of {totalQuestions} questions correct";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close(); 
        }
    }
}
