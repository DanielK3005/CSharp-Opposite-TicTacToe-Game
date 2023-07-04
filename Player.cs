using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class Player
    {
        private string m_PlayerName;
        private GameBoard.eSymbol m_PlayerSymbol;
        private int m_PlayerScore;

        public Player(string i_playerName, GameBoard.eSymbol i_playerSymbol)
        {
            m_PlayerScore = 0;
            m_PlayerName = i_playerName;
            m_PlayerSymbol = i_playerSymbol;
        }

        public string GetPlayerName()
        {
            return m_PlayerName;
        }

        public int GetPlayerScore()
        {
            return m_PlayerScore;
        }

        public GameBoard.eSymbol GetPlayerSymbol()
        {
            return m_PlayerSymbol;
        }

        public void IncrementScore()
        {
            m_PlayerScore += 1;
        }
    }
}
