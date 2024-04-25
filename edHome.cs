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
    public partial class form_edHome : Form
    {
        public form_edHome()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_encode nxtform = new form_encode();
            nxtform.Show();
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_decode nxtform = new form_decode();
            nxtform.Show();
        }

        private void huffmanBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_Home nxtform = new form_Home();
            nxtform.Show();
        }

        private void form_edHome_FormClosing(object sender, FormClosingEventArgs e)
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
