using System.Data;
using MySql.Data.MySqlClient;

namespace Quiz_personal
{
    public partial class Form1 : Form
    {
        // MySQL connection string
        string connectionString = "Server=localhost;Port=3306;Database=quiz_db;Uid=root;Pwd=132456;";


        // Variables to store quiz data
        private int totalQuestions;
        int questionIndex = 0;
        int score = 0;
        DataTable quizData;

        public Form1(int questionCount)
        {
            InitializeComponent();
            totalQuestions = questionCount;
        }

        // Asynchronous function to load quiz data from the MySQL database
        private async Task LoadQuizDataAsync()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM questions";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                {
                    quizData = new DataTable();
                    quizData.Load(reader);
                }
            }

            // Shuffle the questions
            var random = new Random();
            quizData = quizData.AsEnumerable()
                               .OrderBy(r => random.Next())
                               .CopyToDataTable();

            DisplayNextQuestion();  // Display the first question
        }

        // Function to display the next question
        private void DisplayNextQuestion()
        {
            if (questionIndex < totalQuestions && questionIndex < quizData.Rows.Count)
            {
                // Load the current question
                DataRow currentQuestion = quizData.Rows[questionIndex];

                lblQuestion.Text = currentQuestion["question_text"].ToString();
                radioButton1.Text = currentQuestion["option_1"].ToString();
                radioButton2.Text = currentQuestion["option_2"].ToString();
                radioButton3.Text = currentQuestion["option_3"].ToString();
                radioButton4.Text = currentQuestion["option_4"].ToString();

                // Clear the previous selection
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else
            {
                ShowScoreForm();
            }
        }

        // Asynchronous method to check if the answer is correct
        private async Task CheckAnswerAsync()
        {
            if (questionIndex < quizData.Rows.Count)
            {
                DataRow row = quizData.Rows[questionIndex];
                int correctAnswer = Convert.ToInt32(row["correct_option"]);

                int selectedOption = 0;
                if (radioButton1.Checked) selectedOption = 1;
                if (radioButton2.Checked) selectedOption = 2;
                if (radioButton3.Checked) selectedOption = 3;
                if (radioButton4.Checked) selectedOption = 4;

                if (selectedOption == correctAnswer)
                {
                    score++;
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Wrong! The correct answer was Option " + correctAnswer);
                }

                questionIndex++;
                await Task.Delay(200);  
                DisplayNextQuestion();  
            }
            else
            {
                ShowScoreForm();
            }
        }

        private void ShowScoreForm()
        {
            // It opens the ScoreForm and displays the final score
            ScoreForm scoreForm = new ScoreForm(score, totalQuestions);

            if (scoreForm.ShowDialog() == DialogResult.Retry)
            {
                // Restar the game and return to the StartForm
                this.Close();
                StartForm startForm = new StartForm();
                startForm.Show();
            }
            else
            {
                this.Close();
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            await CheckAnswerAsync();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadQuizDataAsync();
        }
    }
}

