namespace PDSA_22._2
{
    partial class form_FindShortestPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_FindShortestPath));
            label2 = new Label();
            label1 = new Label();
            panel_RandomNumbers = new Panel();
            groupBox2 = new GroupBox();
            textBox_SourceVertex = new TextBox();
            label4 = new Label();
            button_Add = new Button();
            textBox_Answer = new TextBox();
            listBox1 = new ListBox();
            button_Save = new Button();
            button_Check = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button_PlayAgain = new Button();
            button_Start = new Button();
            textBox_PlayerName = new TextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(275, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(440, 23);
            label2.TabIndex = 3;
            label2.Text = " Find the shortest path and distance for other cities";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(410, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 33);
            label1.TabIndex = 2;
            label1.Text = "Find Shortest Path";
            // 
            // panel_RandomNumbers
            // 
            panel_RandomNumbers.Location = new Point(20, 148);
            panel_RandomNumbers.Margin = new Padding(4, 3, 4, 3);
            panel_RandomNumbers.Name = "panel_RandomNumbers";
            panel_RandomNumbers.Size = new Size(543, 473);
            panel_RandomNumbers.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(textBox_SourceVertex);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button_Add);
            groupBox2.Controls.Add(textBox_Answer);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(button_Save);
            groupBox2.Controls.Add(button_Check);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(606, 274);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(373, 347);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox_SourceVertex
            // 
            textBox_SourceVertex.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_SourceVertex.Location = new Point(204, 18);
            textBox_SourceVertex.Margin = new Padding(2);
            textBox_SourceVertex.Name = "textBox_SourceVertex";
            textBox_SourceVertex.Size = new Size(145, 32);
            textBox_SourceVertex.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 27);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 19);
            label4.TabIndex = 56;
            label4.Text = "Source Vertex: ";
            // 
            // button_Add
            // 
            button_Add.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Add.Image = (Image)resources.GetObject("button_Add.Image");
            button_Add.ImageAlign = ContentAlignment.MiddleLeft;
            button_Add.Location = new Point(203, 91);
            button_Add.Margin = new Padding(2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(145, 52);
            button_Add.TabIndex = 55;
            button_Add.Text = "   Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // textBox_Answer
            // 
            textBox_Answer.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Answer.Location = new Point(119, 81);
            textBox_Answer.Margin = new Padding(2);
            textBox_Answer.Multiline = true;
            textBox_Answer.Name = "textBox_Answer";
            textBox_Answer.Size = new Size(50, 257);
            textBox_Answer.TabIndex = 54;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" });
            listBox1.Location = new Point(51, 81);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(45, 257);
            listBox1.TabIndex = 53;
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Save.Image = (Image)resources.GetObject("button_Save.Image");
            button_Save.ImageAlign = ContentAlignment.MiddleLeft;
            button_Save.Location = new Point(203, 265);
            button_Save.Margin = new Padding(2);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(145, 52);
            button_Save.TabIndex = 51;
            button_Save.Text = "   Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Check
            // 
            button_Check.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Check.Image = (Image)resources.GetObject("button_Check.Image");
            button_Check.ImageAlign = ContentAlignment.MiddleLeft;
            button_Check.Location = new Point(203, 177);
            button_Check.Margin = new Padding(2);
            button_Check.Name = "button_Check";
            button_Check.Size = new Size(145, 52);
            button_Check.TabIndex = 52;
            button_Check.Text = "   Check";
            button_Check.UseVisualStyleBackColor = true;
            button_Check.Click += button_Check_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(68, 53);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 49;
            label6.Text = "Answer";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(button_PlayAgain);
            groupBox1.Controls.Add(button_Start);
            groupBox1.Controls.Add(textBox_PlayerName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(606, 148);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(373, 120);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // button_PlayAgain
            // 
            button_PlayAgain.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_PlayAgain.Image = (Image)resources.GetObject("button_PlayAgain.Image");
            button_PlayAgain.ImageAlign = ContentAlignment.MiddleLeft;
            button_PlayAgain.Location = new Point(203, 57);
            button_PlayAgain.Margin = new Padding(2);
            button_PlayAgain.Name = "button_PlayAgain";
            button_PlayAgain.Size = new Size(145, 52);
            button_PlayAgain.TabIndex = 49;
            button_PlayAgain.Text = "   Restart";
            button_PlayAgain.UseVisualStyleBackColor = true;
            button_PlayAgain.Click += button_PlayAgain_Click;
            // 
            // button_Start
            // 
            button_Start.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Start.Image = (Image)resources.GetObject("button_Start.Image");
            button_Start.ImageAlign = ContentAlignment.MiddleLeft;
            button_Start.Location = new Point(30, 57);
            button_Start.Margin = new Padding(2);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(154, 52);
            button_Start.TabIndex = 50;
            button_Start.Text = "      Start Game";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += button_Start_Click;
            // 
            // textBox_PlayerName
            // 
            textBox_PlayerName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PlayerName.Location = new Point(204, 18);
            textBox_PlayerName.Margin = new Padding(2);
            textBox_PlayerName.Name = "textBox_PlayerName";
            textBox_PlayerName.Size = new Size(145, 32);
            textBox_PlayerName.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 19);
            label3.TabIndex = 47;
            label3.Text = "Enter Your Name :";
            // 
            // button1
            // 
            button1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(20, 25);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(139, 52);
            button1.TabIndex = 54;
            button1.Text = "   Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // form_FindShortestPath
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1005, 640);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel_RandomNumbers);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_FindShortestPath";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Shortest Path";
            FormClosing += form_FindShortestPath_FormClosing;
            Load += FindShortestPath_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_RandomNumbers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_PlayAgain;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.TextBox textBox_SourceVertex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}