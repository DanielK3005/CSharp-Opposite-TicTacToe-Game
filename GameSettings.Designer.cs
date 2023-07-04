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
            this.playersLabel = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player1TB = new System.Windows.Forms.TextBox();
            this.player2CB = new System.Windows.Forms.CheckBox();
            this.player2TB = new System.Windows.Forms.TextBox();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.colsLabel = new System.Windows.Forms.Label();
            this.rowsNumeric = new System.Windows.Forms.NumericUpDown();
            this.colsNumeric = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // playersLabel
            // 
            this.playersLabel.Location = new System.Drawing.Point(35, 32);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(74, 28);
            this.playersLabel.TabIndex = 0;
            this.playersLabel.Text = "Players:";
            this.playersLabel.UseMnemonic = false;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(59, 75);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(64, 20);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Player 1:";
            // 
            // player1TB
            // 
            this.player1TB.Location = new System.Drawing.Point(144, 72);
            this.player1TB.Name = "player1TB";
            this.player1TB.Size = new System.Drawing.Size(165, 27);
            this.player1TB.TabIndex = 2;
            // 
            // player2CB
            // 
            this.player2CB.AutoSize = true;
            this.player2CB.Location = new System.Drawing.Point(37, 124);
            this.player2CB.Name = "player2CB";
            this.player2CB.Size = new System.Drawing.Size(86, 24);
            this.player2CB.TabIndex = 3;
            this.player2CB.Text = "Player 2:";
            this.player2CB.UseVisualStyleBackColor = true;
            this.player2CB.CheckedChanged += new System.EventHandler(this.player2CB_CheckedChanged);
            // 
            // player2TB
            // 
            this.player2TB.Enabled = false;
            this.player2TB.Location = new System.Drawing.Point(144, 124);
            this.player2TB.Name = "player2TB";
            this.player2TB.Size = new System.Drawing.Size(165, 27);
            this.player2TB.TabIndex = 4;
            this.player2TB.Text = "Computer";
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(37, 215);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(83, 20);
            this.boardSizeLabel.TabIndex = 5;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(70, 253);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(47, 20);
            this.rowsLabel.TabIndex = 6;
            this.rowsLabel.Text = "Rows:";
            // 
            // colsLabel
            // 
            this.colsLabel.AutoSize = true;
            this.colsLabel.Location = new System.Drawing.Point(230, 253);
            this.colsLabel.Name = "colsLabel";
            this.colsLabel.Size = new System.Drawing.Size(40, 20);
            this.colsLabel.TabIndex = 7;
            this.colsLabel.Text = "Cols:";
            // 
            // rowsNumeric
            // 
            this.rowsNumeric.Location = new System.Drawing.Point(123, 251);
            this.rowsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowsNumeric.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowsNumeric.Name = "rowsNumeric";
            this.rowsNumeric.Size = new System.Drawing.Size(44, 27);
            this.rowsNumeric.TabIndex = 8;
            this.rowsNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // colsNumeric
            // 
            this.colsNumeric.Location = new System.Drawing.Point(276, 251);
            this.colsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colsNumeric.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colsNumeric.Name = "colsNumeric";
            this.colsNumeric.Size = new System.Drawing.Size(43, 27);
            this.colsNumeric.TabIndex = 9;
            this.colsNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(37, 309);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(293, 29);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(366, 380);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.colsNumeric);
            this.Controls.Add(this.rowsNumeric);
            this.Controls.Add(this.colsLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.player2TB);
            this.Controls.Add(this.player2CB);
            this.Controls.Add(this.player1TB);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.playersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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