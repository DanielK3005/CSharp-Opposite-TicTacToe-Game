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
            checkForErrors();
        }

        private void checkForErrors()
        {
            if (player1TB.Text == "")
            {
                MessageBox.Show("You didnt insert player one name!", "Error");
            }

            if (player2TB.Text == "")
            {
                MessageBox.Show("You didnt insert player two name!", "Error");
            }

            if (rowsNumeric.Value != colsNumeric.Value)
            {
                MessageBox.Show("The form of the board must be a square.\nwhich means that rows will be equal to cols", "Error");
            }
        }
    }
}