namespace PDSA_22._2
{
    partial class form_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Home));
            button_Start = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Start
            // 
            button_Start.BackColor = Color.Transparent;
            button_Start.FlatAppearance.BorderSize = 0;
            button_Start.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Start.ForeColor = Color.Black;
            button_Start.Image = (Image)resources.GetObject("button_Start.Image");
            button_Start.ImageAlign = ContentAlignment.MiddleLeft;
            button_Start.Location = new Point(-3, 336);
            button_Start.Margin = new Padding(2);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(422, 85);
            button_Start.TabIndex = 51;
            button_Start.Text = "Tic-Tac-Toe";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 411);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(422, 85);
            button1.TabIndex = 52;
            button1.Text = "Shortest Path";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, 490);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(422, 85);
            button2.TabIndex = 53;
            button2.Text = "Minimum Connector";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 33);
            label1.TabIndex = 60;
            label1.Text = "THE GAME";
            label1.Click += label1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-3, 257);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(422, 85);
            button3.TabIndex = 64;
            button3.Text = "Secret Message";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-3, 181);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(422, 85);
            button4.TabIndex = 65;
            button4.Text = "Eight queens’ puzzle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(50, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 33);
            label2.TabIndex = 67;
            label2.Text = "   ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(6, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 33);
            label3.TabIndex = 68;
            label3.Text = "   ";
            label3.Click += label3_Click;
            // 
            // form_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(418, 575);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_Start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THE GAME";
            FormClosing += form_Home_FormClosing;
            Load += form_Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
    }
}