using Ex02;
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
        private GameLogic gameLogic;

        //public enum eGameMode
        //{
        //    HumanVsHuman,
        //    HumanVsComputer
        //}

        public TicTacToeMisere(int i_rows, int i_columns, string i_player1Name, string i_player2Name, int i_gameMode)
        {
            InitializeComponent(i_rows, i_columns, i_player1Name, i_player2Name);

            gameLogic = new GameLogic();
            gameLogic.InitGameLogic(i_rows, (GameLogic.eGameMode)i_gameMode);

        }

        private void InitializeComponent(int i_rows, int i_columns, string i_player1Name, string i_player2Name)
        {
            this.rows = i_rows;
            this.columns = i_columns;
            buttons = new Button[rows, columns];

            int buttonSize = 100; // Adjust the button size as desired
            int spacing = 10; // Adjust the spacing between buttons as desired
            int labelHeight = 30; // Adjust the height of the labels as desired

            int formWidth = columns * buttonSize + (columns - 1) * spacing;
            int formHeight = rows * buttonSize + (rows - 1) * spacing + labelHeight;
            this.ClientSize = new System.Drawing.Size(formWidth, formHeight);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(buttonSize, buttonSize);
                    button.Location = new System.Drawing.Point(j * (buttonSize + spacing), i * (buttonSize + spacing));
                    button.Font = new System.Drawing.Font("Arial", 36);

                    button.Tag = new GameBoard.Coordinate(i, j);

                    button.Click += Button_Click;
                    
                    buttons[i, j] = button;
                    this.Controls.Add(button);
                }
            }

            // Create labels for player scores
            player1ScoreLabel = new Label();
            player1ScoreLabel.Text = $"{i_player1Name}: 0"; // Initial score for player 1
            player1ScoreLabel.Location = new System.Drawing.Point(0, rows * (buttonSize + spacing));
            this.Controls.Add(player1ScoreLabel);

            player2ScoreLabel = new Label();
            player2ScoreLabel.Text = $"{i_player2Name}: 0"; // Initial score for player 2
            player2ScoreLabel.Location = new System.Drawing.Point(columns * (buttonSize + spacing) - 100, rows * (buttonSize + spacing));
            this.Controls.Add(player2ScoreLabel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
    
            Button clickedButton = (Button)sender;
            clickedButton.Text = gameLogic.getCurrentPlayerSymbol().ToString(); 
            clickedButton.Enabled = false; // Disable the button after it's clicked

            // Retrieve the button coordinates from the Tag property
            GameBoard.Coordinate coordinates = (GameBoard.Coordinate)clickedButton.Tag;
            int row = coordinates.m_Row;
            int column = coordinates.m_Col;

            bool isSuccess = gameLogic.MakeMove(coordinates);

            if (isSuccess)
            {
                // Update the score labels
                UpdateScoreLabels();

                // Check if the game is over
                if (gameLogic.GetIsFull() || gameLogic.GetIsLose())
                {
                    // Perform necessary actions when the game is over
                    // For example, display a message, reset the game, etc.
                }
            }
        }

        private void UpdateScoreLabels()
        {
            Player player1 = gameLogic.GetPlayer1();
            Player player2 = gameLogic.GetPlayer2();

            // Update the score labels
            player1ScoreLabel.Text = $"{player1.GetPlayerName()}: {player1.GetPlayerScore()}";
            player2ScoreLabel.Text = $"{player2.GetPlayerName()}: {player2.GetPlayerScore()}";
        }
    }
}
