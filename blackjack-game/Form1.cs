namespace blackjack_game
{
    public partial class Form1 : Form
    {
        int balance = 100;
        int betAmount = 5;
        int wins;

        List<Card> playerCards = new List<Card>() 
        { 
            new Card() {Value = 0, Name = "null", Image = "null"}
        };

        List<Card> bankerCards = new List<Card>() 
        { 
            new Card() {Value = 0, Name = "null", Image = "null"}
        };

        List<Card> cardDeck = new List<Card>()
        {
                // Clubs
                new Card() { Value = 2, Name = "Two Clubs", Image = "2C.png" },
                new Card() { Value = 3, Name = "Three Clubs", Image = "3C.png" },
                new Card() { Value = 4, Name = "Four Clubs", Image = "4C.png"},
                new Card() { Value = 5, Name = "Five Clubs", Image = "5C.png" },
                new Card() { Value = 6, Name = "Six Clubs", Image = "6C.png" },
                new Card() { Value = 7, Name = "Seven Clubs", Image = "7C.png" },
                new Card() { Value = 8, Name = "Eight Clubs", Image = "8C.png" },
                new Card() { Value = 9, Name = "Nine Clubs", Image= "9C.png" },
                new Card() { Value = 10, Name = "Ten Clubs", Image = "10C.png" },
                new Card() { Value = 10, Name = "Jack Clubs", Image = "JC.png" },
                new Card() { Value = 10, Name = "Queen Clubs", Image = "QC.png" },
                new Card() { Value = 10, Name = "King Clubs", Image = "KC.png" },
                new Card() { Value = 11, Name = "Ace Clubs", Image = "AC.png" },

                // Spades
                new Card() { Value = 2, Name = "Two Spades", Image = "2S.png" },
                new Card() { Value = 3, Name = "Three Spades", Image = "3S.png"},
                new Card() { Value = 4, Name = "Four Spades", Image = "4S.png"},
                new Card() { Value = 5, Name = "Five Spades", Image = "5S.png" },
                new Card() { Value = 6, Name = "Six Spades", Image = "6S.png" },
                new Card() { Value = 7, Name = "Seven Spades", Image = "7S.png" },
                new Card() { Value = 8, Name = "Eight Spades", Image = "8S.png" },
                new Card() { Value = 9, Name = "Nine Spades", Image = "9S.png" },
                new Card() { Value = 10, Name = "Ten Spades", Image = "10S.png" },
                new Card() { Value = 10, Name = "Jack Spades", Image = "JS.png" },
                new Card() { Value = 10, Name = "Queen Spades", Image = "QS.png" },
                new Card() { Value = 10, Name = "King Spades", Image = "KS.png" },
                new Card() { Value = 11, Name = "Ace Spades", Image = "AS.png" },

                // Diamonds
                new Card() { Value = 2, Name = "Two Diamonds", Image = "2D.png" },
                new Card() { Value = 3, Name = "Three Diamonds", Image = "3D.png" },
                new Card() { Value = 4, Name = "Four Diamonds", Image = "4D.png"},
                new Card() { Value = 5, Name = "Five Diamonds", Image = "5D.png" },
                new Card() { Value = 6, Name = "Six Diamonds", Image = "6D.png" },
                new Card() { Value = 7, Name = "Seven Diamonds", Image = "7D.png" },
                new Card() { Value = 8, Name = "Eight Diamonds", Image = "8D.png" },
                new Card() { Value = 9, Name = "Nine Diamonds", Image = "9D.png" },
                new Card() { Value = 10, Name = "Ten Diamonds", Image = "10D.png" },
                new Card() { Value = 10, Name = "Jack Diamonds", Image = "JD.png" },
                new Card() { Value = 10, Name = "Queen Diamonds", Image = "QD.png" },
                new Card() { Value = 10, Name = "King Diamonds", Image = "KD.png" },
                new Card() { Value = 11, Name = "Ace Diamonds", Image = "AD.png" },

                // Hearts
                new Card() { Value = 2, Name = "Two Hearts", Image = "2H.png" },
                new Card() { Value = 3, Name = "Three Hearts", Image = "3H.png" },
                new Card() { Value = 4, Name = "Four Hearts", Image = "4H.png"},
                new Card() { Value = 5, Name = "Five Hearts", Image = "5H.png" },
                new Card() { Value = 6, Name = "Six Hearts", Image = "6H.png" },
                new Card() { Value = 7, Name = "Seven Hearts", Image = "7H.png" },
                new Card() { Value = 8, Name = "Eight Hearts", Image = "8H.png" },
                new Card() { Value = 9, Name = "Nine Hearts", Image = "9H.png" },
                new Card() { Value = 10, Name = "Ten Hearts", Image = "10H.png" },
                new Card() { Value = 10, Name = "Jack Hearts", Image = "JH.png" },
                new Card() { Value = 10, Name = "Queen Hearts", Image = "QH.png" },
                new Card() { Value = 10, Name = "King Hearts", Image = "KH.png" },
                new Card() { Value = 11, Name = "Ace Hearts", Image = "AH.png" }
        };

        int AddBalance(int amount = 0)
        {
            balance = amount + balance;

            return balance;
        }

        int RemoveBalance(int amount = 0)
        {
            balance = amount - balance;

            return balance;
        }
        void UpdateBetLabel()
        {
            lbl_betAmount.Text = $"${betAmount}";
        }

        public Form1()
        {
            InitializeComponent();
            lbl_welcome.Text = $"Welcome, {Environment.UserName}";
            lbl_balance.Text = $"Balance: ${balance}";
            lbl_wins.Text = $"Wins: {wins}";
            UpdateBetLabel();

        }

        private void btn_increaseBet_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                betAmount += 1;
            }

            else if (ModifierKeys.HasFlag(Keys.Control))
            {
                betAmount += 10;
            }

            else
            {
                betAmount += 5;
            }
            betAmount = Math.Clamp(betAmount, 5, balance);
            UpdateBetLabel();
        }

        private void btn_decreaseBet_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                betAmount -= 1;
            }

            else if (ModifierKeys.HasFlag(Keys.Control))
            {
                betAmount -= 10;
            }

            else
            {
                betAmount -= 5;
            }
            betAmount = Math.Clamp(betAmount, 5, balance);
            UpdateBetLabel();
        }
    }
}