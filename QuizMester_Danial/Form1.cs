using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static QuizMester_Danial.QuestionManager;

namespace QuizMester_Danial
{
    public partial class Form1 : Form
    {
        private string loggedInUsername;

        bool started = false;
        bool choose = false;

        private QuestionManager questionManager = new QuestionManager();
        private Question currentQuestion;

        private int totalPointsQuestion = 100;
        private int totalScore = 0;
        private double timeLeftQuestion = 10; // in seconds
        private double timeLeftTotal = 60;
        private Timer timerQuiz;

        private int currentQuestionIndex = 0;
        private int totalQuestions = 20; // Update with the actual total number of questions


        public Form1()
        {
            InitializeComponent();
            tcQuiz.Appearance = TabAppearance.Normal;
            tcQuiz.ItemSize = new Size(0, 1);
            tcQuiz.SizeMode = TabSizeMode.Fixed;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerQuiz = new Timer();
            timerQuiz.Interval = 100; // 100 miliseconds
            timerQuiz.Tick += TimerQuizTime_Tick;
            LoadLeaderboard();
        }

        private void TimerQuizTime_Tick(object sender, EventArgs e)
        {
            if (timeLeftQuestion > 0)
            {
                timeLeftQuestion -= timerQuiz.Interval / 1000.0; // Calculate elapsed time
                totalPointsQuestion = CalculateGradualPoints(100, 10 - timeLeftQuestion); // Update points

                pgbTimeLeftQuestion.Value = (int)((timeLeftQuestion / 10) * 100); // Update ProgressBar

                if(pgbTimeLeftQuestion.Value < 40)
                {
                    pgbTimeLeftQuestion.ForeColor = Color.Red;
                }
                else
                {
                    pgbTimeLeftQuestion.ForeColor = Color.Green;
                }

                if (timeLeftQuestion <= 0)
                {
                    // Time's up, show next question
                    timerQuiz.Stop();
                    MessageBox.Show("Time's up for this quesrtion!");
                    ShowNextQuestion();
                }
            }

            if (timeLeftTotal > 0)
            {
                timeLeftTotal -= timerQuiz.Interval / 1000.0; // Calculate elapsed time

                pgbTimeLeftTotal.Value = (int)((timeLeftTotal / 60) * 100); // Update ProgressBar

                if (timeLeftTotal <= 0)
                {
                    // Time's up, show next question
                    MessageBox.Show("Time's up! end of quiz!");
                    EndQuiz();
                }
            }
        }

        private int CalculateGradualPoints(int maxPoints, double elapsedSeconds)
        {
            double maxDeduction = maxPoints;
            double deduction = Math.Max(0, maxDeduction - (elapsedSeconds / 10.0) * maxDeduction);

            return (int)Math.Round(deduction);
        }

        private void btnStartLogin_Click(object sender, EventArgs e)
        {
            tcQuiz.SelectedIndex = 1;
        }

        private void btnStartRegister_Click(object sender, EventArgs e)
        {
            tcQuiz.SelectedIndex = 2;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbRegisterUsername.Text;
                string password = txbRegisterPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                bool isRegistered = RegisterUser(username, password);
                if (isRegistered)
                {
                    loggedInUsername = username;  // Store the logged-in username
                    lblUsername.Text = $"Logged in as: {loggedInUsername}";  // Update the label with the username

                    DialogResult result = MessageBox.Show("User registered successfully!", "Registered", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        // Code to execute when OK is clicked
                        tcQuiz.SelectedIndex = 3;
                    }
                }
                else
                {
                    MessageBox.Show("Registration failed. Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbLoginUsername.Text;
                string password = txbLoginPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                bool isLoggedIn = LoginUser(username, password);
                if (isLoggedIn)
                {
                    loggedInUsername = username;  // Store the logged-in username
                    lblUsername.Text = $"Logged in as: {loggedInUsername}";  // Update the label with the username

                    DialogResult result = MessageBox.Show("Login succesful!", "Logged in", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        // Code to execute when OK is clicked
                        tcQuiz.SelectedIndex = 3;
                    }
                }
                else
                {
                    MessageBox.Show("Login failed. Check your username and password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }


        public bool RegisterUser(string playerName, string playerPassword)
        {
            // Connection string for localhost
            string connectionString = "Server=localhost;Database=quizmester;Uid=root;Pwd=;";

            // Query to check if the username already exists
            string checkQuery = "SELECT COUNT(*) FROM login WHERE playerName = @PlayerName";
            string insertQuery = "INSERT INTO login (playerName, playerPassword) VALUES (@PlayerName, @PlayerPassword)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the username is already taken
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@PlayerName", playerName);
                        int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username is already taken. Please choose a different username.");
                            return false; // Username is already taken
                        }
                    }

                    // If the username is available, proceed to insert
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@PlayerName", playerName);
                        insertCmd.Parameters.AddWithValue("@PlayerPassword", playerPassword);

                        int result = insertCmd.ExecuteNonQuery();
                        return result > 0; // Return true if the insert succeeded
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while registering: {ex.Message}");
                return false;
            }
        }




        public bool LoginUser(string playerName, string playerPassword)
        {
            // Connection string for localhost
            string connectionString = "Server=localhost;Database=quizmester;Uid=root;Pwd=;";
            string query = "SELECT COUNT(*) FROM login WHERE playerName = @PlayerName AND playerPassword = @PlayerPassword";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlayerName", playerName);
                        cmd.Parameters.AddWithValue("@PlayerPassword", playerPassword);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Return true if the user exists
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while logging in: {ex.Message}");
                return false;
            }
        }


        public string GetQuestion(int questionId)
        {
            string connectionString = "Server=localhost;Database=quizmester;Uid=root;Pwd=;";
            string query = "SELECT Question FROM quiz WHERE QuestionId = @QuestionId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@QuestionId", questionId);

                        object result = cmd.ExecuteScalar();
                        return result != null ? result.ToString() : "Question not found";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the question: {ex.Message}");
                return "Error";
            }
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            // Cast the sender to a Button so you can access its properties
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.White; // Change this to any color you prefer


                lblSelector.Text = btn.Text;


            }
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            // Cast the sender to a Button so you can access its properties
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Silver; // Change this to the original color

                if (started)
                {
                    lblSelector.Text = "?";

                }
                else
                {
                    lblSelector.Text = "Ready?";
                }
            }
        }



        public void Logout()
        {
            // Clear any user-related data if necessary
            txbLoginUsername.Text = string.Empty;
            txbLoginPassword.Text = string.Empty;

            // Redirect to the login tab (assuming login is at tab index 1)
            tcQuiz.SelectedIndex = 1;  // Redirects to the login tab control

            MessageBox.Show("You have been logged out.");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (choose)
            {
                btnCategory_Click(sender, e);
            }
            else if (started)
            {
                AnswerButton_Click(sender, e);
            }
            else
            {
                choose = true;
                btn1.Text = "Minecraft";
                btn2.Text = "Geography";
                btn3.Text = "General-Knowledge";
                btn4.Text = "Trick-Question";

                AdjustButtonFontSize(btn1);
                AdjustButtonFontSize(btn2);
                AdjustButtonFontSize(btn3);
                AdjustButtonFontSize(btn4);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (choose)
            {
                btnCategory_Click(sender, e);

            }
            else if (started)
            {
                AnswerButton_Click(sender, e);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    UseWaitCursor = true;
                    Form2 newform = new Form2();
                    newform.ShowDialog();
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (choose)
            {
                btnCategory_Click(sender, e);

            }
            else if (started)
            {
                AnswerButton_Click(sender, e);
            }
            else
            {
                tcQuiz.SelectedIndex = 4;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (choose)
            {
                btnCategory_Click(sender, e);

            }
            else if (started)
            {
                AnswerButton_Click(sender, e);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    Logout();
                }
            }
        }

        private void Back(object sender, EventArgs e)
        {
            tcQuiz.SelectedIndex = 0;
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            tcQuiz.SelectedIndex = 3;

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string selectedCategory = clickedButton.Text; // Or use Tag property for categories
                questionManager.LoadQuestions(selectedCategory);

                choose = false;
                started = true;
                ShowNextQuestion(); // Show the first question
            }
        }



        private void ShowNextQuestion()
        {
            var question = questionManager.GetNextQuestion();
            if (question != null)
            {
                lblQuestion.Text = question.Text;
                AdjustLabelFontSize(lblQuestion);

                btn1.Text = question.Answers[0];
                btn2.Text = question.Answers[1];
                btn3.Text = question.Answers[2];
                btn4.Text = question.Answers[3];

                AdjustButtonFontSize(btn1);
                AdjustButtonFontSize(btn2);
                AdjustButtonFontSize(btn3);
                AdjustButtonFontSize(btn4);

                // Initialize points and time
                totalPointsQuestion = 100;
                timeLeftQuestion = 10;
                pgbTimeLeftQuestion.Value = 100;
                timerQuiz.Start();

                currentQuestionIndex++;
                lblQuestionNumber.Text = $"Question: {currentQuestionIndex} of {totalQuestions}";

                currentQuestion = question;
            }
            else
            {
                MessageBox.Show("No more questions.");
                EndQuiz();
                // Optionally, reset or end the quiz
            }
        }




        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && currentQuestion != null)
            {
                string selectedAnswer = clickedButton.Text;
                if (questionManager.CheckAnswer(selectedAnswer, currentQuestion))
                {
                    timerQuiz.Stop();
                    totalScore += totalPointsQuestion; // Add points for correct answer
                    MessageBox.Show($"Correct! Points: {totalPointsQuestion}");
                    ShowNextQuestion(); // Load the next question automatically
                }
                else
                {
                    MessageBox.Show("Incorrect, try again.");
                }
            }
        }



        private void AdjustLabelFontSize(Label label)
        {
            // Define the minimum and maximum font size
            float minFontSize = 8;
            float maxFontSize = 28; // Adjust as necessary
            float fontSize = maxFontSize;
            SizeF textSize;

            using (Graphics g = label.CreateGraphics())
            {
                // Try to increase font size first
                do
                {
                    using (Font font = new Font("Gadugi", fontSize, FontStyle.Bold))
                    {
                        textSize = g.MeasureString(label.Text, font, label.Width);

                        // If text height exceeds twice the label's height, decrease the font size
                        if (textSize.Height > label.Height * 2)
                        {
                            fontSize -= 1;
                        }
                    }
                } while (textSize.Width > label.Width || textSize.Height > label.Height * 2 && fontSize > minFontSize);

                // If the text is too small, increase the font size (if possible)
                fontSize = minFontSize;
                do
                {
                    using (Font font = new Font("Gadugi", fontSize, FontStyle.Bold))
                    {
                        textSize = g.MeasureString(label.Text, font, label.Width);

                        // Increase the font size as long as it fits within the label
                        if (textSize.Width <= label.Width && textSize.Height <= label.Height * 2)
                        {
                            fontSize += 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                } while (fontSize <= maxFontSize);

                // Use the largest fitting font size
                label.Font = new Font("Gadugi", fontSize - 1, FontStyle.Bold); // Subtract 1 to ensure it fits
            }
        }

        private void AdjustButtonFontSize(Button button)
        {
            // Define the minimum and maximum font size
            float minFontSize = 8;
            float maxFontSize = 22; // Adjust as necessary
            float fontSize = maxFontSize;
            SizeF textSize;

            using (Graphics g = button.CreateGraphics())
            {
                // Try to increase font size first
                do
                {
                    using (Font font = new Font("Gadugi", fontSize, FontStyle.Bold))
                    {
                        textSize = g.MeasureString(button.Text, font, button.Width);

                        // If text height exceeds button height, decrease the font size
                        if (textSize.Height > button.Height)
                        {
                            fontSize -= 1;
                        }
                    }
                } while (textSize.Width > button.Width || textSize.Height > button.Height && fontSize > minFontSize);

                // If the text is too small, increase the font size (if possible)
                fontSize = minFontSize;
                do
                {
                    using (Font font = new Font("Gadugi", fontSize, FontStyle.Bold))
                    {
                        textSize = g.MeasureString(button.Text, font, button.Width);

                        // Increase the font size as long as it fits within the button
                        if (textSize.Width <= button.Width && textSize.Height <= button.Height)
                        {
                            fontSize += 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                } while (fontSize <= maxFontSize);

                // Use the largest fitting font size
                button.Font = new Font("Gadugi", fontSize - 1, FontStyle.Bold); // Subtract 1 to ensure it fits
            }
        }

        private void ResetQuiz()
        {
            // Reset quiz state
            totalPointsQuestion = 100;
            timeLeftQuestion = 10;
            timeLeftTotal = 60;
            currentQuestionIndex = 0;
            questionManager = new QuestionManager(); // Create a new instance to load new questions
            lblQuestion.Text = "QuizMester!"; // Clear the question label
            pgbTimeLeftQuestion.Value = 100; // Reset question progress bar
            pgbTimeLeftTotal.Value = 100; // Reset total progress bar
            lblYourScore.Text = ""; // Clear the score label

            started = false;
            choose = false;

            // Clear previous button texts
            btn1.Text = "Yes";
            btn2.Text = "No";
            btn3.Text = "Leaderboard";
            btn4.Text = "Logout";

            // Reset UI elements if necessary
            lblQuestionNumber.Text = "Question: 0 of " + totalQuestions;
            lblUsername.Text = $"Logged in as: {loggedInUsername}"; // Keep username displayed if logged in

            // Redirect to category selection
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetQuiz();
            tcQuiz.SelectedIndex = 3;
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            ResetQuiz();
            tcQuiz.SelectedIndex = 4;
        }

        public void UpdateHighScore(string playerName, int newScore)
        {
            string connectionString = "Server=localhost;Database=quizmester;Uid=root;Pwd=;";
            string query = "UPDATE login SET playerHighscore = @NewScore WHERE playerName = @PlayerName AND playerHighscore < @NewScore";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewScore", newScore);
                        cmd.Parameters.AddWithValue("@PlayerName", playerName);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating high score: {ex.Message}");
            }
        }


        public void LoadLeaderboard()
        {
            string connectionString = "Server=localhost;Database=quizmester;Uid=root;Pwd=;";
            string query = "SELECT playerName, playerHighscore FROM login ORDER BY playerHighscore DESC LIMIT 10";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        rtbLeaderboard.Clear(); // Clear existing entries

                        while (reader.Read())
                        {
                            string name = reader["playerName"].ToString();
                            string score = reader["playerHighscore"].ToString();
                            rtbLeaderboard.AppendText($"{name}:     ---     {score}\n"); // Display in the RichTextBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading leaderboard: {ex.Message}");
            }
        }

        private void EndQuiz()
        {
            timerQuiz.Stop();
            UpdateHighScore(loggedInUsername, totalScore);
            LoadLeaderboard();
            lblYourScore.Text = totalScore.ToString();
            tcQuiz.SelectedIndex = 5;
        }

    }
}
