using System.Data;
using MySql.Data.MySqlClient;

namespace Quiz_personal
{
    public partial class Form1 : Form
    {
        // MySQL connection string
        string connectionString = "Server=localhost;Port=3306;Database=quiz_db;Uid=root;Pwd=132456;";


        // Variables to store quiz data
        int questionIndex = 0;
        int score = 0;
        DataTable quizData;

        public Form1()
        {
            InitializeComponent(); // Call the async method to load quiz data
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
            if (questionIndex < quizData.Rows.Count)
            {
                DataRow row = quizData.Rows[questionIndex];
                lblQuestion.Text = row["question_text"].ToString();
                radioButton1.Text = row["option_1"].ToString();
                radioButton2.Text = row["option_2"].ToString();
                radioButton3.Text = row["option_3"].ToString();
                radioButton4.Text = row["option_4"].ToString();
            }
            else
            {
                MessageBox.Show("Quiz completed! Your score: " + score);
            }
        }

        // Asynchronous function to check the selected answer
        private async void btnNext_ClickAsync(object sender, EventArgs e)
        {
            await CheckAnswerAsync();  // Call the async method to check the answer
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
                MessageBox.Show("Quiz completed! Your score: " + score);
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
