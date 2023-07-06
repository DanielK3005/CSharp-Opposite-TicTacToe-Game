namespace B23_Ex05_Daniel_208063362_Lior_207899469
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        private void player2CB_CheckedChanged(object sender, EventArgs e)
        {
            m_Player2TB.Enabled = m_Player2CB.Checked;
            if (m_Player2CB.Checked)
            {
                m_Player2TB.Text = "";
            }
            else
            {
                m_Player2TB.Text = "Computer";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TicTacToeMisere newForm;

            if (checkForErrors())
            {
                return;
            }

            if (m_Player2CB.Checked)
            {
                newForm = new TicTacToeMisere((int)m_RowsNumeric.Value, m_Player1TB.Text, m_Player2TB.Text, Ex02.GameLogic.eGameMode.HumanVsHuman);

            }
            else
            {
                newForm = new TicTacToeMisere((int)m_RowsNumeric.Value, m_Player1TB.Text, m_Player2TB.Text, Ex02.GameLogic.eGameMode.HumanVsComputer);
            }

            this.Hide();
            newForm.Show();
        }

        private bool checkForErrors()
        {
            bool isError = false;

            if (m_Player1TB.Text == "")
            {
                MessageBox.Show("Insert player one name!", "Error");
                isError = true;
            }

            if (m_Player2TB.Text == "")
            {
                MessageBox.Show("Insert player two name!", "Error");
                isError = true;
            }

            if (m_Player1TB.Text == m_Player2TB.Text)
            {
                MessageBox.Show("You have to use different names for each of the players", "Error");
                isError = true;
            }

            if (m_RowsNumeric.Value != m_ColsNumeric.Value)
            {
                MessageBox.Show("The form of the board must be a square.\nWhich means that rows will be equal to columns", "Error");
                isError = true;
            }

            return isError;
        }

    }
}