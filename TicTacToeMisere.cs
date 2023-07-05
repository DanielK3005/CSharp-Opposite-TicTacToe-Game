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
        private GameLogic.eGameMode gameMode;
        private const string k_FormTitle = "TicTacToeMisere";


        public TicTacToeMisere(int i_Size, string i_Player1Name, string i_Player2Name, GameLogic.eGameMode i_gameMode)
        {
            gameLogic = new GameLogic(i_Size, i_Player1Name, i_Player2Name,  i_gameMode);
            InitializeComponent(i_Size, i_Size, i_Player1Name, i_Player2Name);
            gameMode = i_gameMode;

        }

        private void InitializeComponent(int i_rows, int i_columns, string i_player1Name, string i_player2Name)
        {
            this.rows = i_rows;
            this.columns = i_columns;
            buttons = new Button[rows, columns];

            int buttonSize = 70; // Adjust the button size as desired
            int spacing = 10; // Adjust the spacing between buttons as desired
            int labelHeight = 30; // Adjust the height of the labels as desired

            int formWidth = columns * buttonSize + (columns - 1) * spacing + spacing;
            int formHeight = rows * buttonSize + (rows - 1) * spacing + labelHeight;
            this.ClientSize = new System.Drawing.Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = k_FormTitle;
            this.MaximizeBox = false;



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(buttonSize, buttonSize);
                    button.Location = new System.Drawing.Point(j * buttonSize + (j + 1) * spacing, i * buttonSize + (i + 1) * spacing);
                    button.Font = new System.Drawing.Font("Arial", 36);
                    //button.Margin = new Padding(10, 10, 0, 10);

                    button.Tag = new Point(i, j);

                    button.Click += Button_Click;
                    
                    buttons[i, j] = button;
                    this.Controls.Add(button);
                }
            }

            int halfFormWidth = (formWidth - spacing) / 2;

            // Create labels for player scores
            player1ScoreLabel = new Label();
            player1ScoreLabel.Text = $"{i_player1Name}: 0"; // Initial score for player 1
            player1ScoreLabel.AutoSize = true;
            player1ScoreLabel.PerformLayout();
            player1ScoreLabel.Location = new System.Drawing.Point(halfFormWidth - player1ScoreLabel.Size.Width / 2 - spacing , rows * (buttonSize + spacing) + spacing);
            this.Controls.Add(player1ScoreLabel);

            player2ScoreLabel = new Label();
            player2ScoreLabel.Text = $"{i_player2Name}: 0"; // Initial score for player 2
            player2ScoreLabel.AutoSize = true;
            player2ScoreLabel.Location = new System.Drawing.Point(halfFormWidth + 2 * spacing, rows * (buttonSize + spacing) + spacing);

            boldPlayerLabelTurn();

            this.ClientSize = new Size(this.ClientSize.Width + spacing, this.ClientSize.Height + 2 * spacing);
            this.Controls.Add(player2ScoreLabel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Player nextPlayer = gameLogic.GetNextPlayerTurn();
            bool gameEnded = false;
            boldPlayerLabelTurn();

            Button clickedButton = (Button)sender;
            clickedButton.Text = gameLogic.getCurrentPlayerSymbol().ToString(); 
            clickedButton.Enabled = false; 

            Point coordinates = (Point)clickedButton.Tag;
            int row = coordinates.X;
            int column = coordinates.Y;

            bool isSuccess = gameLogic.MakeMove(coordinates);

            UpdateScoreLabels();

            if (isSuccess)
            {
                gameEnded = checkGameStatus();
            }

            if (gameMode == GameLogic.eGameMode.HumanVsComputer && gameEnded == false)
            {
                performComputerMove(nextPlayer);
            }

        }

        private void boldPlayerLabelTurn()
        {
            string[] player1Parts = player1ScoreLabel.Text.Split(':');
            string[] player2Parts = player2ScoreLabel.Text.Split(':');
            if (gameLogic.GetCurrentPlayer() != null && !gameLogic.GetCurrentPlayer().GetPlayerName().Equals("Computer"))
            {
                if (gameLogic.GetCurrentPlayer().GetPlayerName().Equals(player1Parts[0]))
                {
                    player1ScoreLabel.Font = new Font(player1ScoreLabel.Font, FontStyle.Bold);
                    player2ScoreLabel.Font = new Font(player2ScoreLabel.Font, FontStyle.Regular);
                }
                else if (gameLogic.GetCurrentPlayer().GetPlayerName().Equals(player2Parts[0]))
                {
                    player1ScoreLabel.Font = new Font(player1ScoreLabel.Font, FontStyle.Regular);
                    player2ScoreLabel.Font = new Font(player2ScoreLabel.Font, FontStyle.Bold);
                }
            }
        }

        private void performComputerMove(Player i_NextPlayer)
        {
            Point computerChosenMove = gameLogic.GenerateComputerMove();
            bool isSuccess = gameLogic.MakeMove(computerChosenMove);

            UpdateScoreLabels();

            buttons[computerChosenMove.X, computerChosenMove.Y].Text = i_NextPlayer.GetPlayerSymbol().ToString();
            buttons[computerChosenMove.X, computerChosenMove.Y].Enabled = false;

            if (isSuccess)
            {
                checkGameStatus();
            }
        }

        private bool checkGameStatus()
        {
            DialogResult dialogResult;
            Player o_currentPlayer;
            bool isGameEnded = false;

            if (gameLogic.GetIsFull() || gameLogic.GetIsLose())
            {
                isGameEnded = true;
                gameLogic.GetCurrentPlayerTurn(out o_currentPlayer);

                if (gameLogic.GetIsLose())
                {
                    dialogResult = MessageBox.Show("The winner is " + o_currentPlayer.GetPlayerName() + "!\nWould you like to player another round?", "A win!", MessageBoxButtons.YesNo);
                }
                else
                {
                    dialogResult = MessageBox.Show("Tie!\nWould you like to player another round?", "A tie!", MessageBoxButtons.YesNo);

                }

                if (dialogResult == DialogResult.Yes)
                {
                    resetButtonsBoard();
                    boldPlayerLabelTurn();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }

            return isGameEnded;
        }

        private void resetButtonsBoard()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }

            gameLogic.ResetGame();
        }

        private void UpdateScoreLabels()
        {
            Player player1 = gameLogic.GetPlayer1();
            Player player2 = gameLogic.GetPlayer2();

            player1ScoreLabel.Text = $"{player1.GetPlayerName()}: {player1.GetPlayerScore()}";
            player2ScoreLabel.Text = $"{player2.GetPlayerName()}: {player2.GetPlayerScore()}";
        }
    }
}
