using System.Collections.Generic;

namespace Ex02
{
    internal class GameBoard
    {
        private eSymbol[,] m_Board;
        private int m_BoardSize;
        private List<Coordinate> m_EmptyCells;

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
            m_EmptyCells = new List<Coordinate>();

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
                    m_EmptyCells.Add(new Coordinate(i, j));
                }
            }
        }

        public bool IsCellEmpty(Coordinate i_Move)
        {
            bool result = false;

            if (m_Board[i_Move.m_Row, i_Move.m_Col]==eSymbol.Empty)
            {
                result = true;
            }

            return result;
        }

        public void AssignCellSymbol(Coordinate i_Move, eSymbol i_Symbol)
        {
            m_Board[i_Move.m_Row, i_Move.m_Col] = i_Symbol;

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

        public List<Coordinate> GetEmptyCellsList()
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

        public struct Coordinate
        {
            public int m_Row;
            public int m_Col;

            public Coordinate(int i_Row, int i_Col)
            {
                this.m_Row = i_Row;
                this.m_Col = i_Col;
            }
        }
    }
}
