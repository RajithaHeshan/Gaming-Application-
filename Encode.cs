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

namespace PDSA_22._2.Properties
{
    public partial class form_encode : Form
    {


        public string randomString;
        public string encodedString;

        // Database connection string
        string connectionString = "server =localhost; user = root ; database =PDSA_22._2;passwprd = ";
        string playerName = ""; // Player name variable

        public form_encode()
        {
            InitializeComponent();
        }

        private void huffmanBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_edHome nxtform = new form_edHome();
            nxtform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_Home nxtform = new form_Home();
            nxtform.Show();
        }

        private void form_encode_Load(object sender, EventArgs e)
        {
            try
            {
                controllers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        public void controllers()
        {
            try
            {
                GenerateRandomString();
                encodedString = HuffmanEncoder.Encode(randomString);
                DisplayRandomString();
                HuffmanEncoder.HuffmanNode rootNode = HuffmanEncoder.BuildHuffmanTree(HuffmanEncoder.CalculateFrequencies(randomString));
                string decodedString = HuffmanDecoder.Decode(encodedString, rootNode);


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void encode_Load(object sender, EventArgs e)
        {
            try
            {
                controllers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            form_edHome frm = new form_edHome();
            frm.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string answer = answertxt.Text;

            try
            {
                if (answer == encodedString)
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
            catch (Exception ex)
            {
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


        private void GenerateRandomString()
        {
            var random = new Random();
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var stringBuilder = new StringBuilder();
            int length = 30; // Set the desired length to 30
            //int length = random.Next(1, 31);

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(characters.Length);
                stringBuilder.Append(characters[randomIndex]);
            }

            randomString = stringBuilder.ToString();
        }

        private void DisplayRandomString()
        {
            randomcodeLbl.Text = randomString;
        }

        private void form_encode_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Stop the program execution
                Environment.Exit(0);
            }
        }
    }

    // Priority Queue implementation used by HuffmanEncoder
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> items;

        public int Count => items.Count;

        public PriorityQueue()
        {
            items = new List<T>();
        }

        public void Enqueue(T item)
        {
            items.Add(item);
            int index = items.Count - 1;

            while (index > 0 && items[index].CompareTo(items[(index - 1) / 2]) < 0)
            {
                Swap(index, (index - 1) / 2);
                index = (index - 1) / 2;
            }
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty.");
            }

            T item = items[0];
            items[0] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);

            int index = 0;
            int leftChildIndex, rightChildIndex;

            while (true)
            {
                leftChildIndex = 2 * index + 1;
                rightChildIndex = 2 * index + 2;

                if (leftChildIndex >= items.Count)
                {
                    break;
                }

                int smallerChildIndex = leftChildIndex;

                if (rightChildIndex < items.Count && items[rightChildIndex].CompareTo(items[leftChildIndex]) < 0)
                {
                    smallerChildIndex = rightChildIndex;
                }

                if (items[smallerChildIndex].CompareTo(items[index]) < 0)
                {
                    Swap(index, smallerChildIndex);
                    index = smallerChildIndex;
                }
                else
                {
                    break;
                }
            }

            return item;
        }

        private void Swap(int index1, int index2)
        {
            T temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
    }

    public static class HuffmanEncoder
    {
        public static string Encode(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string is null or empty.");
            }

            Dictionary<char, int> frequencies = CalculateFrequencies(input);
            HuffmanNode rootNode = BuildHuffmanTree(frequencies);
            Dictionary<char, string> encodingTable = BuildEncodingTable(rootNode);

            StringBuilder encodedString = new StringBuilder();

            foreach (char character in input)
            {
                encodedString.Append(encodingTable[character]);
            }

            //Console.WriteLine("Encoded string: " + encodedString.ToString());
            System.Diagnostics.Debug.WriteLine("Encoded string: " + encodedString.ToString());


            return encodedString.ToString();
        }

        public static Dictionary<char, int> CalculateFrequencies(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string is null or empty.");
            }

            Dictionary<char, int> frequencies = new Dictionary<char, int>();

            try
            {
                foreach (char character in input)
                {
                    if (frequencies.ContainsKey(character))
                    {
                        frequencies[character]++;
                    }
                    else
                    {
                        frequencies[character] = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, such as logging or displaying an error message
                //Console.WriteLine("An error occurred during frequency calculation: " + ex.Message);

                System.Diagnostics.Debug.WriteLine("An error occurred during frequency calculation: " + ex.Message);
                throw;
            }

            return frequencies;
        }

        public static HuffmanNode BuildHuffmanTree(Dictionary<char, int> frequencies)
        {
            if (frequencies == null)
            {
                throw new ArgumentNullException(nameof(frequencies));
            }

            PriorityQueue<HuffmanNode> priorityQueue = new PriorityQueue<HuffmanNode>();

            foreach (KeyValuePair<char, int> kvp in frequencies)
            {
                priorityQueue.Enqueue(new HuffmanNode(kvp.Key, kvp.Value));
            }

            while (priorityQueue.Count > 1)
            {
                HuffmanNode leftChild = priorityQueue.Dequeue();
                HuffmanNode rightChild = priorityQueue.Dequeue();
                HuffmanNode parent = new HuffmanNode('\0', leftChild.Frequency + rightChild.Frequency, leftChild, rightChild);
                priorityQueue.Enqueue(parent);
            }

            return priorityQueue.Dequeue();
        }

        public static Dictionary<char, string> BuildEncodingTable(HuffmanNode rootNode)
        {
            if (rootNode == null)
            {
                throw new ArgumentNullException(nameof(rootNode));
            }

            Dictionary<char, string> encodingTable = new Dictionary<char, string>();
            TraverseHuffmanTree(rootNode, string.Empty, encodingTable);
            return encodingTable;
        }

        private static void TraverseHuffmanTree(HuffmanNode node, string code, Dictionary<char, string> encodingTable)
        {
            if (node == null || encodingTable == null)
            {
                throw new ArgumentNullException();
            }

            if (node.IsLeafNode())
            {
                encodingTable[node.Character] = code;
                return;
            }

            TraverseHuffmanTree(node.LeftChild, code + "0", encodingTable);
            TraverseHuffmanTree(node.RightChild, code + "1", encodingTable);
        }

        public class HuffmanNode : IComparable<HuffmanNode>
        {
            public char Character { get; }
            public int Frequency { get; }
            public HuffmanNode LeftChild { get; }
            public HuffmanNode RightChild { get; }

            public HuffmanNode(char character, int frequency)
            {
                Character = character;
                Frequency = frequency;
            }

            public HuffmanNode(char character, int frequency, HuffmanNode leftChild, HuffmanNode rightChild)
                : this(character, frequency)
            {
                LeftChild = leftChild;
                RightChild = rightChild;
            }

            public bool IsLeafNode()
            {
                return LeftChild == null && RightChild == null;
            }

            public int CompareTo(HuffmanNode other)
            {
                return Frequency.CompareTo(other.Frequency);
            }
        }
    }

    public static class HuffmanDecoder
    {
        public static string Decode(string encodedString, HuffmanEncoder.HuffmanNode rootNode)
        {
            if (string.IsNullOrEmpty(encodedString))
            {
                throw new ArgumentException("Encoded string is null or empty.");
            }

            if (rootNode == null)
            {
                throw new ArgumentNullException(nameof(rootNode));
            }

            StringBuilder decodedString = new StringBuilder();
            HuffmanEncoder.HuffmanNode currentNode = rootNode;

            foreach (char bit in encodedString)
            {
                if (bit == '0')
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (bit == '1')
                {
                    currentNode = currentNode.RightChild;
                }

                if (currentNode.IsLeafNode())
                {
                    decodedString.Append(currentNode.Character);
                    currentNode = rootNode;
                }
            }

            //Console.WriteLine("Decoded string: " + decodedString.ToString());
            System.Diagnostics.Debug.WriteLine("Decoded string: " + decodedString.ToString());

            return decodedString.ToString();
        }
    }
}

