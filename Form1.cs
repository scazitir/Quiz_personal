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
            InitializeComponent();
            _ = LoadQuizDataAsync();  // Call the async method to load quiz data
        }

        // Asynchronous function to load quiz data from the MySQL database
        private async Task LoadQuizDataAsync()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();  // Open the MySQL connection asynchronously
                    string query = "SELECT * FROM questions";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())  // Execute the query asynchronously
                    {
                        quizData = new DataTable();
                        quizData.Load(reader);  // Load the quiz data into the DataTable
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading quiz data: " + ex.Message);
                    return;
                }
            }

            // After loading data, display the first question
            DisplayNextQuestion();
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
                await Task.Delay(200);  // Add a small delay to simulate async task completion
                DisplayNextQuestion();  // Display the next question
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
    }
}
