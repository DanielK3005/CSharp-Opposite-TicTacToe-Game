using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class GameLogic
    {
        private const string k_Player1Name = "Player 1";
        private const string k_Player2Name = "Player 2";
        private const string k_ComputerName = "Computer";
        private Player m_Player1;
        private Player m_Player2;
        private GameBoard m_Board;
        private eGameMode m_GameMode;
        private bool m_IsFull = false;
        private bool m_IsLose = false;
        private int m_PlayedTurns = 0;

        public GameLogic(int i_BoardSize, eGameMode i_GameMode)
        {
            InitGameLogic(i_BoardSize, i_GameMode);
        }

        public string GetComputerName()
        {
            return k_ComputerName;
        }

        public void ResetGame()
        {
            m_IsFull = false;
            m_IsLose = false;
            m_PlayedTurns = 0;
            m_Board.InitializeBoard();
        }

        public bool GetIsFull()
        {
            return m_IsFull;
        }

        public Player GetPlayer1()
        {
            return m_Player1;
        }

        public Player GetPlayer2()
        {
            return m_Player2;
        }

        public bool GetIsLose()
        {
            return m_IsLose;
        }

        public enum eGameMode
        {
            HumanVsHuman,
            HumanVsComputer
        }

        public void InitGameLogic(int i_BoardSize, eGameMode i_GameMode)
        {
            m_Board = new GameBoard(i_BoardSize);
            m_GameMode = i_GameMode;
            createNewPlayers();
        }

        public GameBoard GetGameBoard()
        { 
            return m_Board;
        }

        public void GetCurrentPlayerTurn(out Player o_CurrentTurnPlayer)
        {
            if (m_PlayedTurns % 2 == 0)
            {
                o_CurrentTurnPlayer = m_Player1;
            }
            else
            {
                o_CurrentTurnPlayer = m_Player2;
            }
        }

        public Player GetNextPlayerTurn()
        {
            Player currentTurnPlayer =  m_Player2;

            GetCurrentPlayerTurn(out currentTurnPlayer);

            if(currentTurnPlayer == m_Player1)
            {
                currentTurnPlayer = m_Player2;
            }
            else if(currentTurnPlayer == m_Player2)
            {
                currentTurnPlayer = m_Player1;
            }

            return currentTurnPlayer;
        }


        public bool MakeMove(GameBoard.Coordinate i_Move)
        {
            bool isSuccess = true;
            Player currentTurnPlayer;

            GetCurrentPlayerTurn(out currentTurnPlayer);
            isSuccess = m_Board.IsCellEmpty(i_Move);

            if(isSuccess == true)
            {
                makePlayerMove(currentTurnPlayer, i_Move);

                if (CheckLose(currentTurnPlayer))
                {
                    m_IsLose = true;
                    GetNextPlayerTurn().IncrementScore();
                }

                if (m_Board.IsFull())
                {
                    m_IsFull = true;
                }

                m_PlayedTurns++;
            }

            return isSuccess;
        }

        public bool CheckLose(Player i_Player)
        {
            return checkRowSequence(i_Player) || checkColSequence(i_Player) || checkDiagonalSequence(i_Player);
        }

        private bool checkRowSequence(Player i_Player)
        {
            bool isRowSequence = true;
            int size = m_Board.GetBoardSize();

            for (int i = 0; i < size; i++)
            {
                isRowSequence = true;

                for (int j = 0; j < size; j++)
                {
                    if (m_Board.GetBoard()[i, j] != i_Player.GetPlayerSymbol())
                    {
                        isRowSequence = false;
                    }
                }

                if (isRowSequence)
                {
                    break;
                }
            }

            return isRowSequence;
        }

        private bool checkColSequence(Player i_Player)
        {
            bool isColSequence = true;
            int size = m_Board.GetBoardSize();

            for (int i = 0; i < size; i++)
            {
                isColSequence = true;

                for (int j = 0; j < size; j++)
                {
                    if (m_Board.GetBoard()[j, i] != i_Player.GetPlayerSymbol())
                    {
                        isColSequence = false;
                    }
                }

                if (isColSequence)
                {
                    break;
                }
            }

            return isColSequence;
        }

        public GameBoard.eSymbol getCurrentPlayerSymbol()
        {
            Player currentPlayer = m_Player1;
            GetCurrentPlayerTurn(out currentPlayer);

            return currentPlayer.GetPlayerSymbol();
        }

        private bool checkDiagonalSequence(Player i_Player)
        {
            bool isDiagonalSequence = true;
            int size = m_Board.GetBoardSize();

            for (int i = 0; i < size; i++)
            {
                if (m_Board.GetBoard()[i, i] != i_Player.GetPlayerSymbol())
                {
                    isDiagonalSequence = false;
                    break;
                }
            }

            if (!isDiagonalSequence)
            {
                isDiagonalSequence = true;

                for (int i = 0; i < size; i++)
                {
                    if (m_Board.GetBoard()[i, size - i - 1] != i_Player.GetPlayerSymbol())
                    {
                        isDiagonalSequence = false;
                        break;
                    }
                }
            }

            return isDiagonalSequence;
        }


        private void makePlayerMove(Player i_Player, GameBoard.Coordinate i_Move)
        {
            m_Board.AssignCellSymbol(i_Move, i_Player.GetPlayerSymbol());
        }

        public GameBoard.Coordinate GenerateComputerMove()
        {
            Random random = new Random();
            List<GameBoard.Coordinate> listOfEmptyCells = m_Board.GetEmptyCellsList();

            int index = random.Next(0, listOfEmptyCells.Count);

            return listOfEmptyCells[index];
        }

        private void createNewPlayers()
        {
            m_Player1 = new Player(k_Player1Name, GameBoard.eSymbol.X);

            if (m_GameMode == eGameMode.HumanVsHuman)
            {
                m_Player2 = new Player(k_Player2Name, GameBoard.eSymbol.O);
            }
            else
            {
                m_Player2 = new Player(k_ComputerName, GameBoard.eSymbol.O);
            }
        } 
    }
}
