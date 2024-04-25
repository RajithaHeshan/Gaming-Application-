namespace PDSA_22._2
{
    partial class form_tiktaktoe
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tiktaktoe));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button10 = new Button();
            label3 = new Label();
            button11 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 117);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 67;
            label1.Text = "Player wins";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(393, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 68;
            label2.Text = "PC wins";
            // 
            // button1
            // 
            button1.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(35, 173);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(142, 151);
            button1.TabIndex = 69;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(200, 173);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(142, 151);
            button2.TabIndex = 70;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(360, 173);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(142, 151);
            button3.TabIndex = 71;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(35, 340);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(142, 151);
            button6.TabIndex = 72;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(200, 340);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(142, 151);
            button5.TabIndex = 73;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(360, 340);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(142, 151);
            button4.TabIndex = 74;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(35, 507);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(142, 151);
            button9.TabIndex = 75;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(200, 507);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(142, 151);
            button8.TabIndex = 76;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(360, 507);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(142, 151);
            button7.TabIndex = 77;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(360, 690);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(139, 52);
            button10.TabIndex = 78;
            button10.Text = "   Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 706);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 79;
            label3.Text = "Move";
            // 
            // button11
            // 
            button11.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(35, 27);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(142, 52);
            button11.TabIndex = 80;
            button11.Text = "   Home";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // form_tiktaktoe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(539, 771);
            Controls.Add(button11);
            Controls.Add(label3);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_tiktaktoe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tik Tak Toe";
            FormClosing += form_tiktaktoe_FormClosing;
            Load += form_tiktaktoe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        /*private System.Windows.Forms.Timer CPUTimer;*/
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer CPUTimer;
    }
}