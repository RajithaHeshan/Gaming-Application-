using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using MySqlConnector;

namespace PDSA_22._2
{
    public partial class form_IdentifyMinimumConnectors : Form
    {
        DBconnection connection = new DBconnection();

        public form_IdentifyMinimumConnectors()
        {
            InitializeComponent();
        }

        private void genarateMatix()
        {
            //create random number object
            Random rand = new Random();

            //genarateMatix();
            var graph = new Graph();

            var a = graph.CreateRoot("A");
            var b = graph.CreateNode("B");
            var c = graph.CreateNode("C");
            var d = graph.CreateNode("D");
            var s = graph.CreateNode("E");  // s === e
            var f = graph.CreateNode("F");
            var g = graph.CreateNode("G");
            var h = graph.CreateNode("H");
            var i = graph.CreateNode("I");
            var j = graph.CreateNode("J");


            a.AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            b.AddArc(a, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            c.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            d.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));


            s.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            f.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            g.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            h.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            i.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            j.AddArc(a, rand.Next(10, 100))
                .AddArc(b, 1)
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100));

            int[,] adj = graph.CreateAdjMatrix();

            PrintMatrix(ref adj, graph.AllNodes.Count);

            Prim(adj, graph.AllNodes.Count);
        }


        private void PrintMatrix(ref int[,] matrix, int Count)
        {
            ListView listView = new ListView();

            listView.Location = new System.Drawing.Point(12, 12);
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(245, 200);
            listView.ForeColor = System.Drawing.Color.Black;
            listView.Dock = DockStyle.Fill;


            Console.Write("       ");
            listView.Items.Add("       ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ", (char)('A' + i));
                listView.Items.Add(((char)('A' + i)).ToString());
            }
            Console.WriteLine();
            listView.Items.Add("\n");

            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0} | [ ", (char)('A' + i));
                listView.Items.Add(((char)('A' + i)).ToString());
                for (int j = 0; j < Count; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" &,");
                        listView.Items.Add(" &,");
                    }
                    else if (matrix[i, j] == null)
                    {
                        Console.Write(" .,");
                        listView.Items.Add(" .,");
                    }
                    else
                    {
                        Console.Write(" {0},", matrix[i, j]);
                        listView.Items.Add(matrix[i, j].ToString());
                    }

                }
                Console.Write(" ]\r\n");
                listView.Items.Add("\r\n");
            }
            Console.Write("\r\n");
            listView.Items.Add("\r\n");

            panel_RandomNumbers.Controls.Add(listView);

        }

        private static int MinKey(int[] key, bool[] set, int verticesCount)
        {
            int min = int.MaxValue, minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (set[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }

        public static void Prim(int[,] graph, int verticesCount)
        {
            try
            {
                int[] parent = new int[verticesCount];
                int[] key = new int[verticesCount];
                bool[] mstSet = new bool[verticesCount];

                for (int i = 0; i < verticesCount; ++i)
                {
                    key[i] = int.MaxValue;
                    mstSet[i] = false;
                }

                key[0] = 0;
                parent[0] = -1;

                for (int count = 0; count < verticesCount - 1; ++count)
                {
                    int u = MinKey(key, mstSet, verticesCount);
                    mstSet[u] = true;

                    for (int v = 0; v < verticesCount; ++v)
                    {
                        if (Convert.ToBoolean(graph[u, v]) && mstSet[v] == false && graph[u, v] < key[v])
                        {
                            parent[v] = u;
                            key[v] = graph[u, v];
                        }
                    }
                }

                // Remove this when you submit this project
                int total = 0;
                Console.WriteLine("Edge     Weight");
                for (int i = 1; i < verticesCount; ++i)
                {
                    Console.WriteLine("{0} - {1}    {2}", parent[i], i, graph[i, parent[i]]);
                    total += graph[i, parent[i]];
                }

                System.Diagnostics.Debug.WriteLine("Total {0}", total);

                Values.parent = parent;
                Values.graph = graph;
                Values.verticesCount = verticesCount;
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            btn_Check.Enabled = true;
            genarateMatix();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_PlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            btn_Check.Enabled = true;
            genarateMatix();

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            Values.totalWeight = 0;
            if (string.IsNullOrEmpty(textBox_Distance.Text))
            {
                MessageBox.Show("Please provide your answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Values.userAnswer = int.Parse(textBox_Distance.Text);

                listBox_GameResults.Items.Clear();
                listBox_GameResults.Items.Add("    Vertex          Distance");

                for (int i = 1; i < Values.verticesCount; ++i)
                {
                    listBox_GameResults.Items.Add("    " + Values.parent[i] + " - " + i + "           " + Values.graph[i, Values.parent[i]]);
                    Values.totalWeight += Values.graph[i, Values.parent[i]];
                }

                listBox_GameResults.Items.Add("\n");
                listBox_GameResults.Items.Add("   Total Distance :  " + Values.totalWeight);

                if (Values.totalWeight == Values.userAnswer)
                {
                    label_AnswerResult.Text = "Valid";
                    button_Save.Enabled = true;
                }
                else
                {
                    label_AnswerResult.Text = "Wrong";
                    label_AnswerResult.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void saveDataInDatabase()
        {
            try
            {
                string query = "INSERT INTO `tbl_prims`(`player_name`, `answer`) VALUES ('" + Values.playerName + "','" + Values.userAnswer + "')";

                if (connection.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successfully", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.CloseConnection();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Database saving process failed" + ex.StackTrace, "Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_PlayerName.Text))
            {
                MessageBox.Show("Please enter player name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Values.playerName = textBox_PlayerName.Text;
                saveDataInDatabase();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_Home nxtform = new form_Home();
            nxtform.Show();
        }

        private void form_IdentifyMinimumConnectors_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Stop the program execution
                Environment.Exit(0);
            }
        }
    }
}
