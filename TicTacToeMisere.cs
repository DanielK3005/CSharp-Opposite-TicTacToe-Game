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
        private Button[,] m_Buttons;
        private int m_Rows;
        private int m_Columns;
        private Label m_Player1ScoreLabel;
        private Label m_Player2ScoreLabel;
        private GameLogic m_GameLogic;
        private GameLogic.eGameMode m_GameMode;
        private const string k_FormTitle = "TicTacToeMisere";


        public TicTacToeMisere(int i_Size, string i_Player1Name, string i_Player2Name, GameLogic.eGameMode i_gameMode)
        {
            m_GameLogic = new GameLogic(i_Size, i_Player1Name, i_Player2Name,  i_gameMode);
            InitializeComponent(i_Size, i_Size, i_Player1Name, i_Player2Name);
            m_GameMode = i_gameMode;
        }

        private void InitializeComponent(int i_rows, int i_columns, string i_player1Name, string i_player2Name)
        {
            this.m_Rows = i_rows;
            this.m_Columns = i_columns;
            m_Buttons = new Button[m_Rows, m_Columns];
            int buttonSize = 70;
            int spacing = 10; 
            int labelHeight = 30; 
            int formWidth = m_Columns * buttonSize + (m_Columns - 1) * spacing + spacing;
            int formHeight = m_Rows * buttonSize + (m_Rows - 1) * spacing + labelHeight;
            this.ClientSize = new System.Drawing.Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = k_FormTitle;
            this.MaximizeBox = false;
            FormClosing += TicTacToeMisere_FormClosing;


            for (int i = 0; i < m_Rows; i++)
            {
                for (int j = 0; j < m_Columns; j++)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(buttonSize, buttonSize);
                    button.Location = new System.Drawing.Point(j * buttonSize + (j + 1) * spacing, i * buttonSize + (i + 1) * spacing);
                    button.Font = new System.Drawing.Font("Arial", 36);
                    //button.Margin = new Padding(10, 10, 0, 10);

                    button.Tag = new Point(i, j);

                    button.Click += Button_Click;
                    
                    m_Buttons[i, j] = button;
                    this.Controls.Add(button);
                }
            }

            int halfFormWidth = (formWidth - spacing) / 2;

            // Create labels for player scores
            m_Player1ScoreLabel = new Label();
            m_Player1ScoreLabel.Text = $"{i_player1Name}: 0"; 
            m_Player1ScoreLabel.AutoSize = true;
            m_Player1ScoreLabel.PerformLayout();
            m_Player1ScoreLabel.Location = new System.Drawing.Point(halfFormWidth - m_Player1ScoreLabel.Size.Width / 2 - spacing , m_Rows * (buttonSize + spacing) + spacing);
            this.Controls.Add(m_Player1ScoreLabel);

            m_Player2ScoreLabel = new Label();
            m_Player2ScoreLabel.Text = $"{i_player2Name}: 0"; 
            m_Player2ScoreLabel.AutoSize = true;
            m_Player2ScoreLabel.Location = new System.Drawing.Point(halfFormWidth + 2 * spacing, m_Rows * (buttonSize + spacing) + spacing);

            gameLogic.GetCurrentPlayerTurn(out player);
            boldPlayerLabelTurn(player);

            this.ClientSize = new Size(this.ClientSize.Width + spacing, this.ClientSize.Height + 2 * spacing);
            this.Controls.Add(m_Player2ScoreLabel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Player nextPlayer = m_GameLogic.GetNextPlayerTurn();
            bool gameEnded = false;
            boldPlayerLabelTurn(nextPlayer);

            Button clickedButton = (Button)sender;
            clickedButton.Text = m_GameLogic.getCurrentPlayerSymbol().ToString(); 
            clickedButton.Enabled = false; 

            Point coordinates = (Point)clickedButton.Tag;
            int row = coordinates.X;
            int column = coordinates.Y;

            bool isSuccess = m_GameLogic.MakeMove(coordinates);

            UpdateScoreLabels();

            if (isSuccess)
            {
                gameEnded = checkGameStatus();
            }

            if (m_GameMode == GameLogic.eGameMode.HumanVsComputer && gameEnded == false)
            {
                performComputerMove(nextPlayer);
            }
        }

        private void boldPlayerLabelTurn(Player i_CurrentPlayer)
        {
            string[] player1Parts = player1ScoreLabel.Text.Split(':');
            string[] player2Parts = player2ScoreLabel.Text.Split(':');


            if (i_CurrentPlayer != null && !i_CurrentPlayer.GetPlayerName().Equals("Computer"))
            {
                if (i_CurrentPlayer.GetPlayerName().Equals(player1Parts[0]))
                {
                    m_Player1ScoreLabel.Font = new Font(m_Player1ScoreLabel.Font, FontStyle.Bold);
                    m_Player2ScoreLabel.Font = new Font(m_Player2ScoreLabel.Font, FontStyle.Regular);
                }
                else if (i_CurrentPlayer.GetPlayerName().Equals(player2Parts[0]))
                {
                    m_Player1ScoreLabel.Font = new Font(m_Player1ScoreLabel.Font, FontStyle.Regular);
                    m_Player2ScoreLabel.Font = new Font(m_Player2ScoreLabel.Font, FontStyle.Bold);
                }
            }
        }

        private void performComputerMove(Player i_NextPlayer)
        {
            Point computerChosenMove = m_GameLogic.GenerateComputerMove();
            bool isSuccess = m_GameLogic.MakeMove(computerChosenMove);

            UpdateScoreLabels();

            m_Buttons[computerChosenMove.X, computerChosenMove.Y].Text = i_NextPlayer.GetPlayerSymbol().ToString();
            m_Buttons[computerChosenMove.X, computerChosenMove.Y].Enabled = false;

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

            if (m_GameLogic.GetIsFull() || m_GameLogic.GetIsLose())
            {
                isGameEnded = true;
                m_GameLogic.GetCurrentPlayerTurn(out o_currentPlayer);

                if (m_GameLogic.GetIsLose())
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
                    gameLogic.GetCurrentPlayerTurn(out o_currentPlayer);
                    boldPlayerLabelTurn(o_currentPlayer);
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
            for (int i = 0; i < m_Rows; i++)
            {
                for (int j = 0; j < m_Columns; j++)
                {
                    m_Buttons[i, j].Text = "";
                    m_Buttons[i, j].Enabled = true;
                }
            }

            m_GameLogic.ResetGame();
        }

        private void UpdateScoreLabels()
        {
            Player player1 = m_GameLogic.GetPlayer1();
            Player player2 = m_GameLogic.GetPlayer2();

            m_Player1ScoreLabel.Text = $"{player1.GetPlayerName()}: {player1.GetPlayerScore()}";
            m_Player2ScoreLabel.Text = $"{player2.GetPlayerName()}: {player2.GetPlayerScore()}";
        }

        private void TicTacToeMisere_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
