using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PDSA_22._2
{
    public partial class form_Home : Form
    {
        private SoundPlayer soundPlayer;



        public form_Home()
        {
            InitializeComponent();


            soundPlayer = new SoundPlayer("music.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_FindShortestPath nxtform = new form_FindShortestPath();
            nxtform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_IdentifyMinimumConnectors nxtform = new form_IdentifyMinimumConnectors();
            nxtform.Show();
        }


        private void button_Start_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_tiktaktoe nxtform = new form_tiktaktoe();
            nxtform.Show();
        }


        private void form_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Stop the program execution
                Environment.Exit(0);
            }

        }

        private void form_Home_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;


            soundPlayer.PlayLooping();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Eightqueen nxtform = new Eightqueen();
            nxtform.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            form_edHome nxtform = new form_edHome();
            nxtform.Show();
        }
    }
}
