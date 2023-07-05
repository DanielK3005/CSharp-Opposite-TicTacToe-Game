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
            player2TB.Enabled = player2CB.Checked;
            if(player2CB.Checked)
            {
                player2TB.Text = "";
            }
            else
            {
                player2TB.Text = "Computer";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TicTacToeMisere newForm;

            if(checkForErrors())
            {
                return;
            }

            if(player2CB.Checked)
            {
                newForm = new TicTacToeMisere((int)rowsNumeric.Value, player1TB.Text, player2TB.Text, Ex02.GameLogic.eGameMode.HumanVsHuman);

            }
            else
            {
                newForm = new TicTacToeMisere((int)rowsNumeric.Value, player1TB.Text, player2TB.Text, Ex02.GameLogic.eGameMode.HumanVsComputer);
            }

            this.Hide();
            newForm.Show();
        }

        private bool checkForErrors()
        {
            bool isError = false;

            if (player1TB.Text == "")
            {
                MessageBox.Show("You didnt insert player one name!", "Error");
                isError = true;
            }

            if (player2TB.Text == "")
            {
                MessageBox.Show("You didnt insert player two name!", "Error");
                isError = true;
            }

            if (rowsNumeric.Value != colsNumeric.Value)
            {
                MessageBox.Show("The form of the board must be a square.\nwhich means that rows will be equal to cols", "Error");
                isError = true;
            }

            return isError;
        }
    }
}