using System.Collections.Generic;

namespace Ex02
{
    public class GameBoard
    {
        private eSymbol[,] m_Board;
        private int m_BoardSize;
        private List<Point> m_EmptyCells;

        public enum eSymbol
        {
            X = 'X',
            O = 'O',
            Empty = ' '
        }

        public GameBoard(int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            m_Board = new eSymbol[m_BoardSize, m_BoardSize];
            m_EmptyCells = new List<Point>();

            InitializeBoard();
        }

        public void InitializeBoard()
        {
            m_EmptyCells.Clear();
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    m_Board[i, j] = eSymbol.Empty;
                    m_EmptyCells.Add(new Point(i, j));
                }
            }
        }

        public bool IsCellEmpty(Point i_Move)
        {
            bool result = false;

            if (m_Board[i_Move.X, i_Move.Y]==eSymbol.Empty)
            {
                result = true;
            }

            return result;
        }

        public void AssignCellSymbol(Point i_Move, eSymbol i_Symbol)
        {
            m_Board[i_Move.X, i_Move.Y] = i_Symbol;

            m_EmptyCells.Remove(i_Move);
        }

        public bool IsFull()
        {
            bool result = true;

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    if (m_Board[i, j] == eSymbol.Empty)
                    {
                        result = false;
                    }      
                }
            }

            return result;
        }

        public List<Point> GetEmptyCellsList()
        {
            return m_EmptyCells;
        }

        public int GetBoardSize()
        {
            return m_BoardSize;
        }

        public eSymbol[,] GetBoard()
        {
            return m_Board;
        }

    }
}
