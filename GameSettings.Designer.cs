namespace B23_Ex05_Daniel_208063362_Lior_207899469
{
    partial class GameSettings
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
            playersLabel = new Label();
            player1Label = new Label();
            player1TB = new TextBox();
            player2CB = new CheckBox();
            player2TB = new TextBox();
            boardSizeLabel = new Label();
            rowsLabel = new Label();
            colsLabel = new Label();
            rowsNumeric = new NumericUpDown();
            colsNumeric = new NumericUpDown();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)rowsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colsNumeric).BeginInit();
            SuspendLayout();
            // 
            // playersLabel
            // 
            playersLabel.Location = new Point(31, 24);
            playersLabel.Name = "playersLabel";
            playersLabel.Size = new Size(65, 21);
            playersLabel.TabIndex = 0;
            playersLabel.Text = "Players:";
            playersLabel.UseMnemonic = false;
            // 
            // player1Label
            // 
            player1Label.AutoSize = true;
            player1Label.Location = new Point(52, 56);
            player1Label.Name = "player1Label";
            player1Label.Size = new Size(51, 15);
            player1Label.TabIndex = 1;
            player1Label.Text = "Player 1:";
            // 
            // player1TB
            // 
            player1TB.Location = new Point(126, 54);
            player1TB.Margin = new Padding(3, 2, 3, 2);
            player1TB.Name = "player1TB";
            player1TB.Size = new Size(145, 23);
            player1TB.TabIndex = 2;
            // 
            // player2CB
            // 
            player2CB.AutoSize = true;
            player2CB.Location = new Point(32, 93);
            player2CB.Margin = new Padding(3, 2, 3, 2);
            player2CB.Name = "player2CB";
            player2CB.Size = new Size(70, 19);
            player2CB.TabIndex = 3;
            player2CB.Text = "Player 2:";
            player2CB.UseVisualStyleBackColor = true;
            player2CB.CheckedChanged += player2CB_CheckedChanged;
            // 
            // player2TB
            // 
            player2TB.Enabled = false;
            player2TB.Location = new Point(126, 93);
            player2TB.Margin = new Padding(3, 2, 3, 2);
            player2TB.Name = "player2TB";
            player2TB.Size = new Size(145, 23);
            player2TB.TabIndex = 4;
            player2TB.Text = "Computer";
            // 
            // boardSizeLabel
            // 
            boardSizeLabel.AutoSize = true;
            boardSizeLabel.Location = new Point(32, 161);
            boardSizeLabel.Name = "boardSizeLabel";
            boardSizeLabel.Size = new Size(64, 15);
            boardSizeLabel.TabIndex = 5;
            boardSizeLabel.Text = "Board Size:";
            // 
            // rowsLabel
            // 
            rowsLabel.AutoSize = true;
            rowsLabel.Location = new Point(61, 190);
            rowsLabel.Name = "rowsLabel";
            rowsLabel.Size = new Size(38, 15);
            rowsLabel.TabIndex = 6;
            rowsLabel.Text = "Rows:";
            // 
            // colsLabel
            // 
            colsLabel.AutoSize = true;
            colsLabel.Location = new Point(201, 190);
            colsLabel.Name = "colsLabel";
            colsLabel.Size = new Size(33, 15);
            colsLabel.TabIndex = 7;
            colsLabel.Text = "Cols:";
            // 
            // rowsNumeric
            // 
            rowsNumeric.Location = new Point(108, 188);
            rowsNumeric.Margin = new Padding(3, 2, 3, 2);
            rowsNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            rowsNumeric.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            rowsNumeric.Name = "rowsNumeric";
            rowsNumeric.Size = new Size(38, 23);
            rowsNumeric.TabIndex = 8;
            rowsNumeric.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // colsNumeric
            // 
            colsNumeric.Location = new Point(242, 188);
            colsNumeric.Margin = new Padding(3, 2, 3, 2);
            colsNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            colsNumeric.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            colsNumeric.Name = "colsNumeric";
            colsNumeric.Size = new Size(38, 23);
            colsNumeric.TabIndex = 9;
            colsNumeric.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.ButtonFace;
            startButton.Location = new Point(32, 232);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(256, 22);
            startButton.TabIndex = 10;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // GameSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(320, 285);
            Controls.Add(startButton);
            Controls.Add(colsNumeric);
            Controls.Add(rowsNumeric);
            Controls.Add(colsLabel);
            Controls.Add(rowsLabel);
            Controls.Add(boardSizeLabel);
            Controls.Add(player2TB);
            Controls.Add(player2CB);
            Controls.Add(player1TB);
            Controls.Add(player1Label);
            Controls.Add(playersLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "GameSettings";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)rowsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)colsNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playersLabel;
        private Label player1Label;
        private TextBox player1TB;
        private CheckBox player2CB;
        private TextBox player2TB;
        private Label boardSizeLabel;
        private Label rowsLabel;
        private Label colsLabel;
        private NumericUpDown rowsNumeric;
        private NumericUpDown colsNumeric;
        private Button startButton;
    }
}