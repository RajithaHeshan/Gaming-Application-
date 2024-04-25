using Microsoft.VisualBasic;
using MySqlConnector;
using PDSA_22._2.Properties;
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
    public partial class form_decode : Form
    {

        public string randomString;
        public string decodedValue;
        public string encodedString;

        // Database connection string
        string connectionString = "server =localhost; user = root ; database =PDSA_22._2;passwprd = ";
        string playerName = ""; // Player name variable

        public form_decode()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_Home nxtform = new form_Home();
            nxtform.Show();
        }

        private void huffmanBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_edHome nxtform = new form_edHome();
            nxtform.Show();

        }

        private void form_decode_Load(object sender, EventArgs e)
        {
            form_encode encoder = new form_encode(); // Create an instance of the encode class
            encoder.controllers();
            decodedValue = encoder.randomString;
            encodedString = encoder.encodedString;
            DisplayEncodedString();

        }

        private void decode_Load(object sender, EventArgs e)
        {
            form_encode encoder = new form_encode(); // Create an instance of the encode class
            encoder.controllers();
            decodedValue = encoder.randomString;
            encodedString = encoder.encodedString;
            DisplayEncodedString();
        }

        private void DisplayEncodedString()
        {
            randomcodeLbl2.Text = encodedString;
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            string answer = answertxt2.Text;

            if (answer == decodedValue)
            {
                MessageBox.Show("Correct answer!");
                playerName = Interaction.InputBox("Congratulations! You won! \n\n\n\n\nEnter your name:", "Player Name");
                SavePlayerName(playerName);
            }
            else
            {
                MessageBox.Show("Wrong answer!");
            }
        }

        private void SavePlayerName(string playerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_huffman (PlayerName, date) VALUES (@playerName, @date)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@playerName", playerName);
                        command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));

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

        private void form_decode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
