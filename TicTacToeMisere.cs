using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B23_Ex05_Daniel_208063362_Lior_207899469
{
    public partial class TicTacToeMisere : Form
    {
        private Button[,] buttons;
        private int rows;
        private int columns;
        private Label player1ScoreLabel;
        private Label player2ScoreLabel;

        public TicTacToeMisere()
        {
            InitializeComponent();

            this.rows = 3;
            this.columns = 3;
            buttons = new Button[rows, columns];

            int buttonSize = 100; // Adjust the button size as desired
            int spacing = 10; // Adjust the spacing between buttons as desired

            int formWidth = columns * buttonSize + (columns - 1) * spacing;
            int formHeight = rows * buttonSize + (rows - 1) * spacing;
            this.ClientSize = new System.Drawing.Size(formWidth, formHeight);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(buttonSize, buttonSize);
                    button.Location = new System.Drawing.Point(j * (buttonSize + spacing), i * (buttonSize + spacing));
                    button.Font = new System.Drawing.Font("Arial", 36);
                    button.Click += Button_Click;
                    buttons[i, j] = button;
                    this.Controls.Add(button);
                }
            }

            // Create labels for player scores
            player1ScoreLabel = new Label();
            player1ScoreLabel.Text = "Player 1: 0"; // Initial score for player 1
            player1ScoreLabel.Location = new System.Drawing.Point(0, rows * (buttonSize + spacing));
            this.Controls.Add(player1ScoreLabel);

            player2ScoreLabel = new Label();
            player2ScoreLabel.Text = "Player 2: 0"; // Initial score for player 2
            player2ScoreLabel.Location = new System.Drawing.Point(columns * (buttonSize + spacing) - 100, rows * (buttonSize + spacing));
            this.Controls.Add(player2ScoreLabel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Text = "X"; // Set the text to X (you can modify this logic according to your game's rules)
            clickedButton.Enabled = false; // Disable the button after it's clicked
        }
    }
}
