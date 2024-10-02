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
            lblScore.Text = $"Você acertou {score} de {totalQuestions} perguntas!";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o formulário
        }

        // Evento do botão Restart
        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Fecha o formulário de score e retorna ao StartForm
            this.DialogResult = DialogResult.Retry;
            this.Close();  // Fecha o formulário de score
        }
    }
}
