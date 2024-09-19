using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

namespace QuizMester_Danial
{
    public class QuestionManager
    {
        private readonly string connectionString = "Server=localhost;Database=quizmester;Uid=root;Pwd=;";
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = -1; // Start with -1 so the first call to GetNextQuestion gives index 0

        public void LoadQuestions(string category)
        {
            questions.Clear();
            currentQuestionIndex = -1; // Reset index when loading new questions

            string query = @"
        SELECT QuestionId, Question, Correct, False1, False2, False3
        FROM quiz
        WHERE QuestionCategory = @Category
        ORDER BY RAND()
        LIMIT 10";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Category", category);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string correctAnswer = reader.GetString("Correct");
                            List<string> answers = new List<string>
                    {
                        correctAnswer,
                        reader.GetString("False1"),
                        reader.GetString("False2"),
                        reader.GetString("False3")
                    };
                            answers = answers.OrderBy(a => Guid.NewGuid()).ToList(); // Shuffle answers

                            questions.Add(new Question
                            {
                                QuestionId = reader.GetInt32("QuestionId"),
                                Text = reader.GetString("Question"),
                                CorrectAnswer = correctAnswer,
                                Answers = answers
                            });
                        }
                    }
                }
            }
        }


        public Question GetNextQuestion()
        {
            currentQuestionIndex++;
            if (currentQuestionIndex >= questions.Count)
            {
                return null; // No more questions
            }
            return questions[currentQuestionIndex];
        }

        public bool CheckAnswer(string answer, Question question)
        {
            return question.CorrectAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase);
        }

        // Private class to represent a Question
        public class Question
        {
            public int QuestionId { get; set; }
            public string Text { get; set; }
            public string CorrectAnswer { get; set; }
            public List<string> Answers { get; set; }
        }
    }
}
