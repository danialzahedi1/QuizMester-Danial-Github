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

namespace QuizMester_Danial
{
    public partial class Form1 : Form
    {
        bool started = false;
        private string loggedInUsername;

        public Form1()
        {
            InitializeComponent();
            tcQuiz.Appearance = TabAppearance.Normal;
            tcQuiz.ItemSize = new Size(0, 1);
            tcQuiz.SizeMode = TabSizeMode.Fixed;
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
            string query = "INSERT INTO login (playerName, playerPassword) VALUES (@PlayerName, @PlayerPassword)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlayerName", playerName);
                        cmd.Parameters.AddWithValue("@PlayerPassword", playerPassword);

                        int result = cmd.ExecuteNonQuery();
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

        public bool SaveHighScore(string playerName, int newHighScore)
        {
            string connectionString = "Server=localhost;Database=quizmester;Uid=root;Pwd=;";
            string query = @"
                INSERT INTO login (playerName, playerHighscore)
                VALUES (@PlayerName, @NewHighScore)
                ON DUPLICATE KEY UPDATE playerHighscore = GREATEST(playerHighscore, @NewHighScore);";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlayerName", playerName);
                        cmd.Parameters.AddWithValue("@NewHighScore", newHighScore);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0; // Return true if the insert/update succeeded
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the high score: {ex.Message}");
                return false;
            }
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            // Cast the sender to a Button so you can access its properties
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.White; // Change this to any color you prefer

                lbSelector.Text = btn.Text;


            }
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            // Cast the sender to a Button so you can access its properties
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Silver; // Change this to the original color

                lbSelector.Text = "Ready?";

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
            if (started)
            {

            }
            else
            {
                //started = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (started)
            {

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
            if (started)
            {

            }
            else
            {
                tcQuiz.SelectedIndex = 4;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (started)
            {

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
    }
}
