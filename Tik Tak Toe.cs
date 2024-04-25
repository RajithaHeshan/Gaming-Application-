using Microsoft.VisualBasic;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSA_22._2
{
    public partial class form_tiktaktoe : Form
    {

        string connectionString = "server =localhost; user = root ; database =PDSA_22._2;passwprd = ";
        string playerName = ""; // Player name variable

        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        int totalMoves = 0;
        List<Button> buttons;


        public form_tiktaktoe()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            try
            {
                if (buttons.Count > 0)
                {
                    // Use Minimax algorithm to determine the best move
                    int bestMoveIndex = GetBestMove();
                    buttons[bestMoveIndex].Enabled = false;
                    currentPlayer = Player.O;
                    buttons[bestMoveIndex].Text = currentPlayer.ToString();
                    buttons[bestMoveIndex].BackColor = Color.DarkSalmon;
                    buttons.RemoveAt(bestMoveIndex);
                    totalMoves++;
                    CheckGame();
                    CPUTimer.Stop();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                // You can display an error message or perform any other necessary actions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private int GetBestMove()
        {
            try
            {
                int bestScore = int.MinValue;
                int bestMove = -1;

                for (int i = 0; i < buttons.Count; i++)
                {
                    // Simulate the move
                    Button currentButton = buttons[i];
                    currentButton.Text = Player.O.ToString();
                    buttons.RemoveAt(i);

                    // Calculate the score using Minimax algorithm
                    int score = Minimax(0, false);

                    // Undo the move
                    currentButton.Text = "?";
                    buttons.Insert(i, currentButton);

                    // Update the best move and score
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                }

                return bestMove;
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message, log the exception)
                Console.WriteLine("An error occurred while determining the best move: " + ex.Message);
                return -1; // Return an invalid move or an appropriate default value
            }
        }


        private int Minimax(int depth, bool isMaximizing)
        {
            try
            {
                // Base cases: check if the game is over
                int score = Evaluate();
                if (score == 10) // AI wins
                    return score - depth;
                if (score == -10) // Player wins
                    return score + depth;
                if (buttons.Count == 0) // Draw
                    return 0;

                // Recursive cases
                if (isMaximizing)
                {
                    int bestScore = int.MinValue;
                    for (int i = 0; i < buttons.Count; i++)
                    {
                        Button currentButton = buttons[i];
                        currentButton.Text = Player.O.ToString();
                        buttons.RemoveAt(i);

                        int currentScore = Minimax(depth + 1, !isMaximizing);

                        currentButton.Text = "?";
                        buttons.Insert(i, currentButton);

                        bestScore = Math.Max(bestScore, currentScore);
                    }
                    return bestScore;
                }
                else
                {
                    int bestScore = int.MaxValue;
                    for (int i = 0; i < buttons.Count; i++)
                    {
                        Button currentButton = buttons[i];
                        currentButton.Text = Player.X.ToString();
                        buttons.RemoveAt(i);

                        int currentScore = Minimax(depth + 1, !isMaximizing);

                        currentButton.Text = "?";
                        buttons.Insert(i, currentButton);

                        bestScore = Math.Min(bestScore, currentScore);
                    }
                    return bestScore;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or rethrow if necessary
                Console.WriteLine("An error occurred in the Minimax function: " + ex.Message);
                throw;
            }
        }


        private int Evaluate()
        {
            try
            {
                // TODO: Implement your own evaluation logic here
                // Evaluate the current state of the board and return a score
                // Positive score means AI is winning, negative score means player is winning

                // Example evaluation logic: check for winning combinations
                // and assign a score based on the number of AI's and player's marks

                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                    || button6.Text == "O" && button5.Text == "O" && button4.Text == "O"
                    || button9.Text == "O" && button8.Text == "O" && button7.Text == "O"
                    || button1.Text == "O" && button6.Text == "O" && button9.Text == "O"
                    || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                    || button3.Text == "O" && button4.Text == "O" && button7.Text == "O"
                    || button1.Text == "O" && button5.Text == "O" && button7.Text == "O"
                    || button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    return 10; // AI wins
                }
                else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                         || button6.Text == "X" && button5.Text == "X" && button4.Text == "X"
                         || button9.Text == "X" && button8.Text == "X" && button7.Text == "X"
                         || button1.Text == "X" && button6.Text == "X" && button9.Text == "X"
                         || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                         || button3.Text == "X" && button4.Text == "X" && button7.Text == "X"
                         || button1.Text == "X" && button5.Text == "X" && button7.Text == "X"
                         || button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    return -10; // Player wins
                }

                return 0; // Draw or undecided
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred during evaluation: " + ex.Message);
                // Return a neutral score or handle the exception based on your requirements
                return 0;
            }
        }


        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            try
            {
                label3.Text = "Move " + totalMoves;

                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                   || button6.Text == "X" && button5.Text == "X" && button4.Text == "X"
                   || button9.Text == "X" && button8.Text == "X" && button7.Text == "X"
                   || button1.Text == "X" && button6.Text == "X" && button9.Text == "X"
                   || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                   || button3.Text == "X" && button4.Text == "X" && button7.Text == "X"
                   || button1.Text == "X" && button5.Text == "X" && button7.Text == "X"
                   || button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    CPUTimer.Stop();
                    MessageBox.Show("Player Wins");

                    playerName = Interaction.InputBox("Congratulations! You won! \n\n\n\n\n Enter your name:", "Player Name");
                    SavePlayerName(playerName);

                    playerWinCount++;
                    label1.Text = "Player Wins- " + playerWinCount;

                    RestartGame();
                }
                else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button6.Text == "O" && button5.Text == "O" && button4.Text == "O"
                || button9.Text == "O" && button8.Text == "O" && button7.Text == "O"
                || button1.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button7.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    CPUTimer.Stop();
                    MessageBox.Show("Computer Wins");



                    CPUWinCount++;
                    label2.Text = "PC Wins- " + CPUWinCount;
                    RestartGame();
                }
                else if (totalMoves == 9) // Assuming 9 buttons in total
                {
                    CPUTimer.Stop();
                    MessageBox.Show("Draw");
                    RestartGame();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the game
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void SavePlayerName(string playerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tic_tac_toe (PlayerName, date) VALUES (@playerName, @date)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@playerName", playerName);
                        command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));

                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle MySQL exceptions
                    MessageBox.Show("MySQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void RestartGame()
        {
            try
            {
                buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

                foreach (Button x in buttons)
                {
                    x.Enabled = true;
                    x.Text = "?";
                    x.BackColor = DefaultBackColor;
                }

                totalMoves = 0;
            }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void PlayerClickButton(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;

                if (button.Enabled)
                {
                    currentPlayer = Player.X;
                    button.Text = currentPlayer.ToString();
                    button.Enabled = false;
                    button.BackColor = Color.Cyan;
                    buttons.Remove(button);
                    totalMoves++;
                    CheckGame();
                    CPUTimer.Start();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void button11_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_Home nxtform = new form_Home();
            nxtform.Show();
        }

        private void form_tiktaktoe_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Stop the program execution
                Environment.Exit(0);
            }
        }

        private void form_tiktaktoe_Load(object sender, EventArgs e)
        {

        }
    }
}
