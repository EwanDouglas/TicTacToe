namespace TicTacToe
{
    partial class Form1
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            lbl8 = new Label();
            lbl9 = new Label();
            lblWin = new Label();
            lstOutput = new ListBox();
            btnPlay = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(205, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "label1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(294, 24);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(38, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "label1";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(398, 24);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(38, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "label1";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(205, 100);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(38, 15);
            lbl4.TabIndex = 3;
            lbl4.Text = "label1";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(294, 100);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(38, 15);
            lbl5.TabIndex = 4;
            lbl5.Text = "label1";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(398, 100);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(38, 15);
            lbl6.TabIndex = 5;
            lbl6.Text = "label1";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(205, 168);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(38, 15);
            lbl7.TabIndex = 6;
            lbl7.Text = "label1";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Location = new Point(294, 168);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(38, 15);
            lbl8.TabIndex = 7;
            lbl8.Text = "label1";
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Location = new Point(398, 168);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(38, 15);
            lbl9.TabIndex = 8;
            lbl9.Text = "label1";
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.Location = new Point(294, 246);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(38, 15);
            lblWin.TabIndex = 9;
            lblWin.Text = "label1";
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(559, 17);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(71, 244);
            lstOutput.TabIndex = 10;
            lstOutput.Visible = false;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(128, 255, 128);
            btnPlay.Location = new Point(255, 300);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(131, 46);
            btnPlay.TabIndex = 11;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(559, 353);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 46);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 446);
            Controls.Add(btnExit);
            Controls.Add(btnPlay);
            Controls.Add(lstOutput);
            Controls.Add(lblWin);
            Controls.Add(lbl9);
            Controls.Add(lbl8);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;
        private Label lbl7;
        private Label lbl8;
        private Label lbl9;
        private Label lblWin;
        private ListBox lstOutput;
        private Button btnPlay;
        private Button btnExit;
    }
}