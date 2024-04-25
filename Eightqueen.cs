using System.CodeDom;
using System.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using System.IO;


namespace PDSA_22._2
{
    public partial class Eightqueen : Form
    {
        private const int ChessboardSize = 8;

        private const int MaxQueens = 8;
        private int recognizedSolutions = 0;
        private bool solutionsRecognized = false;
        private int placedQueens = 0;
        private List<string> solutionsList = new List<string>();
        private string connectionString = "server =localhost; user = root ; database =PDSA_22._2;passwprd = ";
        private string playerName = "";
        private int totalSolutions = 0;


        public Eightqueen()
        {



            InitializeComponent();

            ControlBox = true;

            playerName = PromptPlayerName();
            totalSolutions = CalculateMaxSolutions();
            MessageBox.Show($"Maximum Solutions: {totalSolutions}");
            if (CheckAllSolutionsFound())
            {
                ClearSolutionsTable();
            }
            else
            {
                DialogResult result = MessageBox.Show("Maximum solutions not found you can try:", "Player Name  Good Luck", MessageBoxButtons.OKCancel);
            }
            CreateChessboard();


        }
        private void CreateChessboard()
        {
            chessboardLayoutPanel.ColumnStyles.Clear();
            chessboardLayoutPanel.RowStyles.Clear();
            chessboardLayoutPanel.Controls.Clear();

            for (int row = 0; row < ChessboardSize; row++)
            {
                chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / ChessboardSize));
                chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / ChessboardSize));

                for (int col = 0; col < ChessboardSize; col++)
                {
                    Button button = new Button();
                    button.Name = $"button_{row}_{col}";
                    button.Dock = DockStyle.Fill;
                    button.Click += ChessboardButton_Click;
                    button.UseVisualStyleBackColor = true;
                    chessboardLayoutPanel.Controls.Add(button, col, row);
                }
            }
        }

        public string PromptPlayerName()
        {
            string playerName = "";
            DialogResult result = MessageBox.Show("Please enter your name:", "Player Name", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                playerName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "Player Name");
            }
            return playerName;
        }



        private void ChessboardButton_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.Transparent;
                placedQueens--;
                button.BackgroundImage = null;

            }
            else
            {
                if (placedQueens < MaxQueens)
                {
                    button.BackColor = Color.Red;
                    placedQueens++;
                    // Load the original image
                    Image originalImage = Image.FromFile(@"Z:\Projects\VS\PDSA 22.2\PDSA 22.2\Images\kindpng_971641.png");

                    // Define the desired width and height for the resized image
                    int desiredWidth = 75;
                    int desiredHeight = 75;

                    // Resize the image
                    Image resizedImage = new Bitmap(originalImage, desiredWidth, desiredHeight);

                    // Assign the resized image as the button's background image
                    button.BackgroundImage = resizedImage;

                    // Set the background image layout to center
                    button.BackgroundImageLayout = ImageLayout.Center;

                }
                else
                {
                    MessageBox.Show($"You can only place a maximum of {MaxQueens} queens on the chessboard.");
                    return;
                }
            }

            bool isValid = IsQueenPlacementValid();
            if (isValid)
            {
                if (placedQueens == MaxQueens)
                {
                    string solution = GetSolution();

                    if (CheckIfPatternExists(solution))
                    {
                        MessageBox.Show("Pattern already available!");
                        RestartGame();
                    }
                    else
                    {
                        SavePattern(playerName, solution);
                        totalSolutions++;
                        MessageBox.Show("Congratulations! You found a new pattern!");
                        RestartGame();
                    }

                    solutionsRecognized = true;
                }
                //else
                //{
                //    MessageBox.Show("Correct move!");
                //}
            }
            else
            {
                MessageBox.Show("Invalid queen placement. Queens are threatening each other.");
                button.BackColor = Color.Transparent;
                button.BackgroundImage = null;

                placedQueens--;
            }
        }
        private int CalculateMaxSolutions()
        {
            int[] queens = new int[ChessboardSize];
            CalculateQueens(queens, 0);
            return totalSolutions;
        }

        private void CalculateQueens(int[] queens, int row)
        {
            if (row == ChessboardSize)
            {
                totalSolutions++;
                return;
            }

            for (int col = 0; col < ChessboardSize; col++)
            {
                if (IsQueenSafe(queens, row, col))
                {
                    queens[row] = col;
                    CalculateQueens(queens, row + 1);
                }
            }
        }

        private bool IsQueenSafe(int[] queens, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (queens[i] == col || queens[i] - col == i - row || queens[i] - col == row - i)
                    return false;
            }

            return true;
        }

        private bool IsQueenPlacementValid()
        {
            List<(int, int)> queenPositions = new List<(int, int)>();

            foreach (Button button in chessboardLayoutPanel.Controls)
            {
                if (button.BackColor == Color.Red)
                {
                    string[] nameParts = button.Name.Split('_');
                    int row = int.Parse(nameParts[1]);
                    int col = int.Parse(nameParts[2]);
                    queenPositions.Add((row, col));
                }
            }

            foreach (var position1 in queenPositions)
            {
                foreach (var position2 in queenPositions)
                {
                    if (position1 != position2)
                    {
                        if (position1.Item1 == position2.Item1 || position1.Item2 == position2.Item2 ||
                            Math.Abs(position1.Item1 - position2.Item1) == Math.Abs(position1.Item2 - position2.Item2))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private string GetSolution()
        {
            string solution = "";

            foreach (Button button in chessboardLayoutPanel.Controls)
            {
                if (button.BackColor == Color.Red)
                {
                    string[] nameParts = button.Name.Split('_');
                    int row = int.Parse(nameParts[1]);
                    int col = int.Parse(nameParts[2]);
                    solution += $"{row},{col};";
                }
            }

            return solution;
        }

        private bool CheckIfPatternExists(string solution)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Pattern WHERE Solution = @solution";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@solution", solution);

                    long count = (long)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        /*        private void SavePattern(string playerName, string solution)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO Pattern (PlayerName, Solution) VALUES (@playerName, @solution)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@playerName", playerName);
                            command.Parameters.AddWithValue("@solution", solution);

                            command.ExecuteNonQuery();
                        }
                    }
                }*/

        private void SavePattern(string playerName, string solution)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Pattern (PlayerName, Solution) VALUES (@playerName, @solution)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@playerName", playerName);
                        command.Parameters.AddWithValue("@solution", solution);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the pattern: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalSolutions = CalculateMaxSolutions();
            MessageBox.Show($"Maximum Solutions: {totalSolutions}");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = "solutions.txt";
            File.WriteAllText(filePath, totalSolutions.ToString());

            MessageBox.Show("Thanks for playing! The total solutions value has been saved.");
            MessageBox.Show("Thanks for playing!");
        }
        private bool CheckAllSolutionsFound()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Pattern";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    long count = (long)command.ExecuteScalar();
                    return count == totalSolutions;
                }
            }
        }

        private void ClearSolutionsTable()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Pattern";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("All possible solutions have been found. The table has been reset.");
        }




        private void RestartGame()
        {
            MessageBox.Show($"Total Solutions: {totalSolutions}");

            foreach (Button button in chessboardLayoutPanel.Controls)
            {
                button.BackColor = Color.Transparent;
                button.BackgroundImage = null;
            }

            placedQueens = 0;
            //ClearSolutionsRecognizedFlag();
            playerName = PromptPlayerName();

            // Check if all solutions have been found
            if (CheckAllSolutionsFound())
            {
                ClearSolutionsTable();
            }
        }

        private void eightqueen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Eightqueen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Stop the program execution
                Environment.Exit(0);
            }
        }

        private void Eightqueen_Load_1(object sender, EventArgs e)
        {

        }

        private void chessboardLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}