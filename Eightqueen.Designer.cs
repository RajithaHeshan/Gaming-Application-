using System.Drawing;
using System.Windows.Forms;


namespace PDSA_22._2
{
    partial class Eightqueen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eightqueen));
            chessboardLayoutPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // chessboardLayoutPanel
            // 
            chessboardLayoutPanel.BackColor = SystemColors.Control;
            chessboardLayoutPanel.ColumnCount = 8;
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.06349F));
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.93651F));
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            chessboardLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            chessboardLayoutPanel.Dock = DockStyle.Fill;
            chessboardLayoutPanel.Location = new Point(0, 0);
            chessboardLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            chessboardLayoutPanel.Name = "chessboardLayoutPanel";
            chessboardLayoutPanel.RowCount = 8;
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            chessboardLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            chessboardLayoutPanel.Size = new Size(780, 615);
            chessboardLayoutPanel.TabIndex = 0;
            chessboardLayoutPanel.Paint += chessboardLayoutPanel_Paint;
            // 
            // Eightqueen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(780, 615);
            Controls.Add(chessboardLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Eightqueen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eightqueen";
            FormClosing += Eightqueen_FormClosing;
            Load += Eightqueen_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel chessboardLayoutPanel;
    }
}