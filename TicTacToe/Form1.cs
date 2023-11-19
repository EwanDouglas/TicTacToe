namespace TicTacToe
{
    public partial class Form1 : Form
    {

        const int ROWS = 3;
        const int COLS = 3;
        const int LBLS = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int SIZE = 9;
            int[] numbersArray = new int[SIZE];
            int num1;
            Random rand = new Random();
            num1 = rand.Next(0, 2);
            int value = 0;
            bool xray = false;
            bool oscar = false;
            string x = "x";
            string o = "0";




            int[,] scores = new int[3, 3];

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    scores[row, col] = rand.Next(0, 2);


                    lbl1.Text = scores[0, 0].ToString();
                    lbl2.Text = scores[0, 1].ToString();
                    lbl3.Text = scores[0, 2].ToString();
                    lbl4.Text = scores[1, 0].ToString();
                    lbl5.Text = scores[1, 1].ToString();
                    lbl6.Text = scores[1, 2].ToString();
                    lbl7.Text = scores[2, 0].ToString();
                    lbl8.Text = scores[2, 1].ToString();
                    lbl9.Text = scores[2, 2].ToString();

                    stepThrough();






                    //lbl1.Text = scores[row, col].ToString() + "\n";

                }
            }

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {

                    lstOutput.Items.Add(scores[row, col].ToString());


                }
            }

            for (int index = 0; index < SIZE; index++)
            {


                numbersArray[index] = rand.Next();


                if (numbersArray[index] == 1)
                {

                }
            }

            if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0)
            {
                lblWin.Text = "O Wins!";
            }

            if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1)
            {
                lblWin.Text = "X Wins!";
            }

            if (scores[0, 0] == 0 && scores[1, 0] == 0 && scores[2, 0] == 0)
            {
                lblWin.Text = "O Wins!";
            }

            if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1)
            {
                lblWin.Text = "X Wins!";
            }

            if (scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0)
            {
                lblWin.Text = "O Wins!";
            }

            if (scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1)
            {
                lblWin.Text = "X Wins!";
            }

            if (scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "O Wins!";
            }

            if (scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "X Wins!";
            }

            if (scores[0, 1] == 0 && scores[1, 1] == 0 && scores[2, 1] == 0)
            {
                lblWin.Text = "O Wins!";
            }

            if (scores[0, 1] == 1 && scores[1, 1] == 1 && scores[2, 1] == 1)
            {
                lblWin.Text = "X Wins!";
            }
            if (scores[0, 2] == 0 && scores[1, 2] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "O Wins!";
            }

            if (scores[0, 2] == 1 && scores[1, 2] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "X Wins!";
            }
            if (scores[0, 0] == 0 && scores[1, 1] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "O Wins!";
            }
            if (scores[0, 0] == 1 && scores[1, 1] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "X Wins!";
            }
            if (scores[0, 2] == 0 && scores[1, 1] == 0 && scores[2, 0] == 0)
            {
                lblWin.Text = "O Wins!";
            }
            if (scores[2, 0] == 1 && scores[1, 1] == 1 && scores[0, 2] == 1)
            {
                lblWin.Text = "X Wins!";
            }
            if (scores[0, 2] == 1 && scores[1, 2] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "X Wins!";
            }

            if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0 && scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1)
            {
                lblWin.Text = "It was a tie!";
            }

            if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0 && scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0 && scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1 && scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }

            if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }


            if (scores[0, 0] == 0 && scores[1, 0] == 0 && scores[2, 0] == 0 && scores[0, 1] == 1 && scores[1, 1] == 1 && scores[2, 1] == 1)
            {
                lblWin.Text = "It was a tie!";
            }

            if (scores[0, 0] == 0 && scores[1, 0] == 0 && scores[2, 0] == 0 && scores[0, 2] == 1 && scores[1, 2] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[0, 1] == 0 && scores[1, 1] == 0 && scores[2, 1] == 0 && scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
            {
                lblWin.Text = "It was a tie!";
            }

            if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1 && scores[0, 1] == 0 && scores[1, 1] == 0 && scores[2, 1] == 0)
            {
                lblWin.Text = "It was a tie!";
            }

            if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1 && scores[0, 2] == 0 && scores[1, 2] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[0, 1] == 1 && scores[1, 1] == 1 && scores[2, 1] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1 && scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0 && scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }
            if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1 && scores[0, 2] == 0 && scores[1, 2] == 0 && scores[2, 2] == 0)
            {
                lblWin.Text = "It was a tie!";
            }
        }

        private void stepThrough()
        {


            if (lbl1.Text == "1")
            {
                lbl1.Text = "X";
            }
            else
            {
                lbl1.Text = "O";
            }

            if (lbl2.Text == "1")
            {
                lbl2.Text = "X";
            }
            else
            {
                lbl2.Text = "O";
            }
            if (lbl3.Text == "1")
            {
                lbl3.Text = "X";
            }
            else
            {
                lbl3.Text = "O";
            }

            if (lbl4.Text == "1")
            {
                lbl4.Text = "X";
            }
            else
            {
                lbl4.Text = "O";
            }
            if (lbl5.Text == "1")
            {
                lbl5.Text = "X";
            }
            else
            {
                lbl5.Text = "O";
            }

            if (lbl6.Text == "1")
            {
                lbl6.Text = "X";
            }
            else
            {
                lbl6.Text = "O";
            }
            if (lbl7.Text == "1")
            {
                lbl7.Text = "X";
            }
            else
            {
                lbl7.Text = "O";
            }

            if (lbl8.Text == "1")
            {
                lbl8.Text = "X";
            }
            else
            {
                lbl8.Text = "O";
            }
            if (lbl9.Text == "1")
            {
                lbl9.Text = "X";
            }
            else
            {
                lbl9.Text = "O";
            }
        }

        private void playGame()
        {
            const int SIZE = 9;
            int[] numbersArray = new int[SIZE];
            int num1;
            Random rand = new Random();
            num1 = rand.Next(0, 2);
            int value = 0;
            bool xray = false;
            bool oscar = false;
            string x = "x";
            string o = "0";




            int[,] scores = new int[3, 3];

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    scores[row, col] = rand.Next(0, 2);


                    lbl1.Text = scores[0, 0].ToString();
                    lbl2.Text = scores[0, 1].ToString();
                    lbl3.Text = scores[0, 2].ToString();
                    lbl4.Text = scores[1, 0].ToString();
                    lbl5.Text = scores[1, 1].ToString();
                    lbl6.Text = scores[1, 2].ToString();
                    lbl7.Text = scores[2, 0].ToString();
                    lbl8.Text = scores[2, 1].ToString();
                    lbl9.Text = scores[2, 2].ToString();








                    //lbl1.Text = scores[row, col].ToString() + "\n";

                }
            }
            /*
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    outputListBox.Text = "";
                   outputListBox.Items.Add(scores[row, col].ToString());
                    

                }
            }
            */
            for (int index = 0; index < SIZE; index++)
            {


                numbersArray[index] = rand.Next();


                if (numbersArray[index] == 1)
                {

                }
            }

            try
            {
                if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0)
                {
                    lblWin.Text = "O Wins!";
                }

                if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1)
                {
                    lblWin.Text = "X Wins!";
                }

                if (scores[0, 0] == 0 && scores[1, 0] == 0 && scores[2, 0] == 0)
                {
                    lblWin.Text = "O Wins!";
                }

                if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1)
                {
                    lblWin.Text = "X Wins!";
                }

                if (scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0)
                {
                    lblWin.Text = "O Wins!";
                }

                if (scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1)
                {
                    lblWin.Text = "X Wins!";
                }

                if (scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "O Wins!";
                }

                if (scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "X Wins!";
                }

                if (scores[0, 1] == 0 && scores[1, 1] == 0 && scores[2, 1] == 0)
                {
                    lblWin.Text = "O Wins!";
                }

                if (scores[0, 1] == 1 && scores[1, 1] == 1 && scores[2, 1] == 1)
                {
                    lblWin.Text = "X Wins!";
                }
                if (scores[0, 2] == 0 && scores[1, 2] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "O Wins!";
                }

                if (scores[0, 2] == 1 && scores[1, 2] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "X Wins!";
                }
                if (scores[0, 0] == 0 && scores[1, 1] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "O Wins!";
                }
                if (scores[0, 0] == 1 && scores[1, 1] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "X Wins!";
                }
                if (scores[0, 2] == 0 && scores[1, 1] == 0 && scores[2, 0] == 0)
                {
                    lblWin.Text = "O Wins!";
                }
                if (scores[2, 0] == 1 && scores[1, 1] == 1 && scores[0, 2] == 1)
                {
                    lblWin.Text = "X Wins!";
                }
                if (scores[0, 2] == 1 && scores[1, 2] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "X Wins!";
                }

                if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0 && scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1)
                {
                    lblWin.Text = "It was a tie!";
                }

                if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0 && scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0 && scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1 && scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }

                if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }


                if (scores[0, 0] == 0 && scores[1, 0] == 0 && scores[2, 0] == 0 && scores[0, 1] == 1 && scores[1, 1] == 1 && scores[2, 1] == 1)
                {
                    lblWin.Text = "It was a tie!";
                }

                if (scores[0, 0] == 0 && scores[1, 0] == 0 && scores[2, 0] == 0 && scores[0, 2] == 1 && scores[1, 2] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[0, 1] == 0 && scores[1, 1] == 0 && scores[2, 1] == 0 && scores[2, 0] == 1 && scores[2, 1] == 1 && scores[2, 2] == 1)
                {
                    lblWin.Text = "It was a tie!";
                }

                if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1 && scores[0, 1] == 0 && scores[1, 1] == 0 && scores[2, 1] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }

                if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1 && scores[0, 2] == 0 && scores[1, 2] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[0, 1] == 1 && scores[1, 1] == 1 && scores[2, 1] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[0, 0] == 1 && scores[0, 1] == 1 && scores[0, 2] == 1 && scores[1, 0] == 0 && scores[1, 1] == 0 && scores[1, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[0, 0] == 0 && scores[0, 1] == 0 && scores[0, 2] == 0 && scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[1, 0] == 1 && scores[1, 1] == 1 && scores[1, 2] == 1 && scores[2, 0] == 0 && scores[2, 1] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }
                if (scores[0, 0] == 1 && scores[1, 0] == 1 && scores[2, 0] == 1 && scores[0, 2] == 0 && scores[1, 2] == 0 && scores[2, 2] == 0)
                {
                    lblWin.Text = "It was a tie!";
                }
            }
            catch
            {
                lblWin.Text = "It was a tie!";
            }

        }

        private void whoWon()
        {
            const int SIZE = 9;
            int[] numbersArray = new int[SIZE];
            int num1;
            Random rand = new Random();
            num1 = rand.Next(0, 2);
            int value = 0;
            bool xray = false;
            bool oscar = false;
            string x = "x";
            string o = "0";




            int[,] scores = new int[3, 3];

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    scores[row, col] = rand.Next(0, 2);


                    lbl1.Text = scores[0, 0].ToString();
                    lbl2.Text = scores[0, 1].ToString();
                    lbl3.Text = scores[0, 2].ToString();
                    lbl4.Text = scores[1, 0].ToString();
                    lbl5.Text = scores[1, 1].ToString();
                    lbl6.Text = scores[1, 2].ToString();
                    lbl7.Text = scores[2, 0].ToString();
                    lbl8.Text = scores[2, 1].ToString();
                    lbl9.Text = scores[2, 2].ToString();
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            playGame();

            stepThrough();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}