namespace PDSA_22._2
{
    partial class form_edHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_edHome));
            Encode = new Button();
            Decode = new Button();
            label5 = new Label();
            huffmanBack = new Button();
            SuspendLayout();
            // 
            // Encode
            // 
            Encode.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Encode.Location = new Point(78, 177);
            Encode.Margin = new Padding(2);
            Encode.Name = "Encode";
            Encode.Size = new Size(139, 52);
            Encode.TabIndex = 60;
            Encode.Text = "Encode";
            Encode.UseVisualStyleBackColor = true;
            Encode.Click += Encode_Click;
            // 
            // Decode
            // 
            Decode.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Decode.Location = new Point(299, 177);
            Decode.Margin = new Padding(2);
            Decode.Name = "Decode";
            Decode.Size = new Size(139, 52);
            Decode.TabIndex = 61;
            Decode.Text = "Decode";
            Decode.UseVisualStyleBackColor = true;
            Decode.Click += Decode_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(139, 88);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(244, 33);
            label5.TabIndex = 72;
            label5.Text = "SECRET MESSAGE";
            // 
            // huffmanBack
            // 
            huffmanBack.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            huffmanBack.Image = (Image)resources.GetObject("huffmanBack.Image");
            huffmanBack.ImageAlign = ContentAlignment.MiddleLeft;
            huffmanBack.Location = new Point(13, 13);
            huffmanBack.Margin = new Padding(2);
            huffmanBack.Name = "huffmanBack";
            huffmanBack.Size = new Size(107, 52);
            huffmanBack.TabIndex = 73;
            huffmanBack.Text = "       Home";
            huffmanBack.UseVisualStyleBackColor = true;
            huffmanBack.Click += huffmanBack_Click;
            // 
            // form_edHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(564, 272);
            Controls.Add(huffmanBack);
            Controls.Add(label5);
            Controls.Add(Decode);
            Controls.Add(Encode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_edHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encode Decode Home";
            FormClosing += form_edHome_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button huffmanBack;
    }
}