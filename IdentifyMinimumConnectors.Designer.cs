namespace PDSA_22._2
{
    partial class form_IdentifyMinimumConnectors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_IdentifyMinimumConnectors));
            label1 = new Label();
            label2 = new Label();
            panel_RandomNumbers = new Panel();
            listBox_GameResults = new ListBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button_PlayAgain = new Button();
            button_Start = new Button();
            textBox_PlayerName = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button_Save = new Button();
            btn_Check = new Button();
            textBox_Distance = new TextBox();
            label_AnswerResult = new Label();
            label7 = new Label();
            label9 = new Label();
            label6 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(460, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 33);
            label1.TabIndex = 0;
            label1.Text = "Identify Minimum Connecters";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(326, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(577, 23);
            label2.TabIndex = 1;
            label2.Text = "Identify the minimum connectors & distance to connect all the cities ";
            label2.Click += label2_Click_1;
            // 
            // panel_RandomNumbers
            // 
            panel_RandomNumbers.Location = new Point(19, 165);
            panel_RandomNumbers.Margin = new Padding(4, 3, 4, 3);
            panel_RandomNumbers.Name = "panel_RandomNumbers";
            panel_RandomNumbers.Size = new Size(543, 473);
            panel_RandomNumbers.TabIndex = 2;
            // 
            // listBox_GameResults
            // 
            listBox_GameResults.Font = new Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_GameResults.FormattingEnabled = true;
            listBox_GameResults.ItemHeight = 25;
            listBox_GameResults.Location = new Point(590, 165);
            listBox_GameResults.Margin = new Padding(4, 3, 4, 3);
            listBox_GameResults.Name = "listBox_GameResults";
            listBox_GameResults.Size = new Size(313, 479);
            listBox_GameResults.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(700, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 1;
            label4.Text = "Results";
            label4.Click += label2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(135, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(263, 25);
            label5.TabIndex = 1;
            label5.Text = "Random Distance Matrix";
            label5.Click += label2_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(button_PlayAgain);
            groupBox1.Controls.Add(button_Start);
            groupBox1.Controls.Add(textBox_PlayerName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(927, 165);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(373, 195);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button_PlayAgain
            // 
            button_PlayAgain.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_PlayAgain.Image = (Image)resources.GetObject("button_PlayAgain.Image");
            button_PlayAgain.ImageAlign = ContentAlignment.MiddleLeft;
            button_PlayAgain.Location = new Point(203, 123);
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
            button_Start.Location = new Point(30, 123);
            button_Start.Margin = new Padding(2);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(153, 52);
            button_Start.TabIndex = 50;
            button_Start.Text = "       Start Game";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += button_Start_Click;
            // 
            // textBox_PlayerName
            // 
            textBox_PlayerName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PlayerName.Location = new Point(203, 41);
            textBox_PlayerName.Margin = new Padding(2);
            textBox_PlayerName.Name = "textBox_PlayerName";
            textBox_PlayerName.Size = new Size(145, 32);
            textBox_PlayerName.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 51);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 19);
            label3.TabIndex = 47;
            label3.Text = "Enter Your Name :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(button_Save);
            groupBox2.Controls.Add(btn_Check);
            groupBox2.Controls.Add(textBox_Distance);
            groupBox2.Controls.Add(label_AnswerResult);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(927, 366);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(373, 278);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox1_Enter;
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Save.Image = (Image)resources.GetObject("button_Save.Image");
            button_Save.ImageAlign = ContentAlignment.MiddleLeft;
            button_Save.Location = new Point(204, 145);
            button_Save.Margin = new Padding(2);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(145, 52);
            button_Save.TabIndex = 51;
            button_Save.Text = "   Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // btn_Check
            // 
            btn_Check.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Check.Image = (Image)resources.GetObject("btn_Check.Image");
            btn_Check.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Check.Location = new Point(30, 145);
            btn_Check.Margin = new Padding(2);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new Size(139, 52);
            btn_Check.TabIndex = 52;
            btn_Check.Text = "   Check";
            btn_Check.UseVisualStyleBackColor = true;
            btn_Check.Click += btn_Check_Click;
            // 
            // textBox_Distance
            // 
            textBox_Distance.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Distance.Location = new Point(204, 81);
            textBox_Distance.Margin = new Padding(2);
            textBox_Distance.Name = "textBox_Distance";
            textBox_Distance.Size = new Size(145, 32);
            textBox_Distance.TabIndex = 50;
            // 
            // label_AnswerResult
            // 
            label_AnswerResult.AutoSize = true;
            label_AnswerResult.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_AnswerResult.Location = new Point(234, 232);
            label_AnswerResult.Margin = new Padding(4, 0, 4, 0);
            label_AnswerResult.Name = "label_AnswerResult";
            label_AnswerResult.Size = new Size(65, 19);
            label_AnswerResult.TabIndex = 47;
            label_AnswerResult.Text = "_______";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(98, 228);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 48;
            label7.Text = "Awnser :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(113, 30);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(132, 19);
            label9.TabIndex = 49;
            label9.Text = "Submit Answer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 90);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 19);
            label6.TabIndex = 49;
            label6.Text = "Enter Distance :";
            // 
            // button1
            // 
            button1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(19, 27);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(139, 52);
            button1.TabIndex = 55;
            button1.Text = "   Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // form_IdentifyMinimumConnectors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1324, 665);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBox_GameResults);
            Controls.Add(panel_RandomNumbers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_IdentifyMinimumConnectors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Identify Minimum Connectors";
            FormClosing += form_IdentifyMinimumConnectors_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_RandomNumbers;
        private System.Windows.Forms.ListBox listBox_GameResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_PlayAgain;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.TextBox textBox_Distance;
        private System.Windows.Forms.Label label_AnswerResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

