namespace PDSA_22._2
{
    partial class form_decode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_decode));
            huffmanBack = new Button();
            button1 = new Button();
            btnSubmit2 = new Button();
            answertxt2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            randomcodeLbl2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // huffmanBack
            // 
            huffmanBack.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            huffmanBack.Image = (Image)resources.GetObject("huffmanBack.Image");
            huffmanBack.ImageAlign = ContentAlignment.MiddleLeft;
            huffmanBack.Location = new Point(29, 107);
            huffmanBack.Margin = new Padding(2);
            huffmanBack.Name = "huffmanBack";
            huffmanBack.Size = new Size(139, 52);
            huffmanBack.TabIndex = 55;
            huffmanBack.Text = "   Back";
            huffmanBack.UseVisualStyleBackColor = true;
            huffmanBack.Click += huffmanBack_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(29, 39);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(139, 52);
            button1.TabIndex = 56;
            button1.Text = "   Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSubmit2
            // 
            btnSubmit2.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit2.Image = (Image)resources.GetObject("btnSubmit2.Image");
            btnSubmit2.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit2.Location = new Point(539, 344);
            btnSubmit2.Margin = new Padding(2);
            btnSubmit2.Name = "btnSubmit2";
            btnSubmit2.Size = new Size(139, 52);
            btnSubmit2.TabIndex = 59;
            btnSubmit2.Text = "   Submit";
            btnSubmit2.UseVisualStyleBackColor = true;
            btnSubmit2.Click += btnSubmit2_Click;
            // 
            // answertxt2
            // 
            answertxt2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            answertxt2.Location = new Point(373, 274);
            answertxt2.Margin = new Padding(2);
            answertxt2.Name = "answertxt2";
            answertxt2.Size = new Size(593, 32);
            answertxt2.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(235, 283);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 57;
            label3.Text = "Answer :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(607, 176);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 19);
            label1.TabIndex = 60;
            label1.Text = "Encoded Message :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(447, 95);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(356, 23);
            label4.TabIndex = 63;
            label4.Text = "Provide the decoded value as the Answer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(421, 44);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(399, 33);
            label5.TabIndex = 62;
            label5.Text = "Encode /Decode using Huffman";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(randomcodeLbl2);
            groupBox1.Location = new Point(29, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1282, 48);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            // 
            // randomcodeLbl2
            // 
            randomcodeLbl2.AutoSize = true;
            randomcodeLbl2.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            randomcodeLbl2.Location = new Point(18, 19);
            randomcodeLbl2.Margin = new Padding(4, 0, 4, 0);
            randomcodeLbl2.Name = "randomcodeLbl2";
            randomcodeLbl2.Size = new Size(0, 19);
            randomcodeLbl2.TabIndex = 62;
            // 
            // form_decode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1320, 486);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnSubmit2);
            Controls.Add(answertxt2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(huffmanBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_decode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Decode";
            FormClosing += form_decode_FormClosing;
            Load += form_decode_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button huffmanBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubmit2;
        private System.Windows.Forms.TextBox answertxt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private GroupBox groupBox1;
        private Label randomcodeLbl2;
    }
}