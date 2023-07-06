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
            this.m_PlayersLabel = new System.Windows.Forms.Label();
            this.m_Player1Label = new System.Windows.Forms.Label();
            this.m_Player1TB = new System.Windows.Forms.TextBox();
            this.m_Player2CB = new System.Windows.Forms.CheckBox();
            this.m_Player2TB = new System.Windows.Forms.TextBox();
            this.m_BoardSizeLabel = new System.Windows.Forms.Label();
            this.m_RowsLabel = new System.Windows.Forms.Label();
            this.m_ColsLabel = new System.Windows.Forms.Label();
            this.m_RowsNumeric = new System.Windows.Forms.NumericUpDown();
            this.m_ColsNumeric = new System.Windows.Forms.NumericUpDown();
            this.m_StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_RowsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ColsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PlayersLabel
            // 
            this.m_PlayersLabel.Location = new System.Drawing.Point(35, 32);
            this.m_PlayersLabel.Name = "m_PlayersLabel";
            this.m_PlayersLabel.Size = new System.Drawing.Size(74, 28);
            this.m_PlayersLabel.TabIndex = 0;
            this.m_PlayersLabel.Text = "Players:";
            this.m_PlayersLabel.UseMnemonic = false;
            // 
            // m_Player1Label
            // 
            this.m_Player1Label.AutoSize = true;
            this.m_Player1Label.Location = new System.Drawing.Point(59, 75);
            this.m_Player1Label.Name = "m_Player1Label";
            this.m_Player1Label.Size = new System.Drawing.Size(64, 20);
            this.m_Player1Label.TabIndex = 1;
            this.m_Player1Label.Text = "Player 1:";
            // 
            // m_Player1TB
            // 
            this.m_Player1TB.Location = new System.Drawing.Point(144, 72);
            this.m_Player1TB.Name = "m_Player1TB";
            this.m_Player1TB.Size = new System.Drawing.Size(165, 27);
            this.m_Player1TB.TabIndex = 2;
            // 
            // m_Player2CB
            // 
            this.m_Player2CB.AutoSize = true;
            this.m_Player2CB.Location = new System.Drawing.Point(37, 124);
            this.m_Player2CB.Name = "m_Player2CB";
            this.m_Player2CB.Size = new System.Drawing.Size(86, 24);
            this.m_Player2CB.TabIndex = 3;
            this.m_Player2CB.Text = "Player 2:";
            this.m_Player2CB.UseVisualStyleBackColor = true;
            this.m_Player2CB.CheckedChanged += new System.EventHandler(this.player2CB_CheckedChanged);
            // 
            // m_Player2TB
            // 
            this.m_Player2TB.Enabled = false;
            this.m_Player2TB.Location = new System.Drawing.Point(144, 124);
            this.m_Player2TB.Name = "m_Player2TB";
            this.m_Player2TB.Size = new System.Drawing.Size(165, 27);
            this.m_Player2TB.TabIndex = 4;
            this.m_Player2TB.Text = "Computer";
            // 
            // m_BoardSizeLabel
            // 
            this.m_BoardSizeLabel.AutoSize = true;
            this.m_BoardSizeLabel.Location = new System.Drawing.Point(37, 215);
            this.m_BoardSizeLabel.Name = "m_BoardSizeLabel";
            this.m_BoardSizeLabel.Size = new System.Drawing.Size(83, 20);
            this.m_BoardSizeLabel.TabIndex = 5;
            this.m_BoardSizeLabel.Text = "Board Size:";
            // 
            // m_RowsLabel
            // 
            this.m_RowsLabel.AutoSize = true;
            this.m_RowsLabel.Location = new System.Drawing.Point(70, 253);
            this.m_RowsLabel.Name = "m_RowsLabel";
            this.m_RowsLabel.Size = new System.Drawing.Size(47, 20);
            this.m_RowsLabel.TabIndex = 6;
            this.m_RowsLabel.Text = "Rows:";
            // 
            // m_ColsLabel
            // 
            this.m_ColsLabel.AutoSize = true;
            this.m_ColsLabel.Location = new System.Drawing.Point(230, 253);
            this.m_ColsLabel.Name = "m_ColsLabel";
            this.m_ColsLabel.Size = new System.Drawing.Size(40, 20);
            this.m_ColsLabel.TabIndex = 7;
            this.m_ColsLabel.Text = "Cols:";
            // 
            // m_RowsNumeric
            // 
            this.m_RowsNumeric.Location = new System.Drawing.Point(123, 251);
            this.m_RowsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_RowsNumeric.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_RowsNumeric.Name = "m_RowsNumeric";
            this.m_RowsNumeric.Size = new System.Drawing.Size(43, 27);
            this.m_RowsNumeric.TabIndex = 8;
            this.m_RowsNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // m_ColsNumeric
            // 
            this.m_ColsNumeric.Location = new System.Drawing.Point(277, 251);
            this.m_ColsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_ColsNumeric.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_ColsNumeric.Name = "m_ColsNumeric";
            this.m_ColsNumeric.Size = new System.Drawing.Size(43, 27);
            this.m_ColsNumeric.TabIndex = 9;
            this.m_ColsNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // m_StartButton
            // 
            this.m_StartButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_StartButton.Location = new System.Drawing.Point(37, 309);
            this.m_StartButton.Name = "m_StartButton";
            this.m_StartButton.Size = new System.Drawing.Size(293, 29);
            this.m_StartButton.TabIndex = 10;
            this.m_StartButton.Text = "Start";
            this.m_StartButton.UseVisualStyleBackColor = false;
            this.m_StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(366, 380);
            this.Controls.Add(this.m_StartButton);
            this.Controls.Add(this.m_ColsNumeric);
            this.Controls.Add(this.m_RowsNumeric);
            this.Controls.Add(this.m_ColsLabel);
            this.Controls.Add(this.m_RowsLabel);
            this.Controls.Add(this.m_BoardSizeLabel);
            this.Controls.Add(this.m_Player2TB);
            this.Controls.Add(this.m_Player2CB);
            this.Controls.Add(this.m_Player1TB);
            this.Controls.Add(this.m_Player1Label);
            this.Controls.Add(this.m_PlayersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.m_RowsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ColsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label m_PlayersLabel;
        private Label m_Player1Label;
        private TextBox m_Player1TB;
        private CheckBox m_Player2CB;
        private TextBox m_Player2TB;
        private Label m_BoardSizeLabel;
        private Label m_RowsLabel;
        private Label m_ColsLabel;
        private NumericUpDown m_RowsNumeric;
        private NumericUpDown m_ColsNumeric;
        private Button m_StartButton;
    }
}