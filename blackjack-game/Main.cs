namespace blackjack_game
{
    public partial class Main : Form
    {
        int balance;
        int betAmount = 0;
        int xp;
        uint gamesPlayed;
        int firstTime;

        int playerCardSum;
        int dealerCardSum;
        bool gameStarted;

        int gameSpeed = 500;

        Random random = new Random();

        List<int> usedCards = new List<int>();
        List<Card> playerCards = new List<Card>()
        {
            new Card() {Value = 0, Name = "null", Image = "null"}
        };
        List<Card> dealerCards = new List<Card>()
        {
            new Card() {Value = 0, Name = "null", Image = "null"}
        };
        List<Card> cardDeck = new List<Card>()
        {
                // Clubs
                new Card() {Value = 2, Name = "Two Clubs", Image = "Resources/Images/2C.png"},
                new Card() {Value = 3, Name = "Three Clubs", Image = "Resources/Images/3C.png"},
                new Card() {Value = 4, Name = "Four Clubs", Image = "Resources/Images/4C.png"},
                new Card() {Value = 5, Name = "Five Clubs", Image = "Resources/Images/5C.png"},
                new Card() {Value = 6, Name = "Six Clubs", Image = "Resources/Images/6C.png"},
                new Card() {Value = 7, Name = "Seven Clubs", Image = "Resources/Images/7C.png"},
                new Card() {Value = 8, Name = "Eight Clubs", Image = "Resources/Images/8C.png"},
                new Card() {Value = 9, Name = "Nine Clubs", Image= "Resources/Images/9C.png"},
                new Card() {Value = 10, Name = "Ten Clubs", Image = "Resources/Images/10C.png"},
                new Card() {Value = 10, Name = "Jack Clubs", Image = "Resources/Images/JC.png"},
                new Card() {Value = 10, Name = "Queen Clubs", Image = "Resources/Images/QC.png"},
                new Card() {Value = 10, Name = "King Clubs", Image = "Resources/Images/KC.png"},
                new Card() {Value = 11, Name = "Ace Clubs", Image = "Resources/Images/AC.png"},

                // Spades
                new Card() {Value = 2, Name = "Two Spades", Image = "Resources/Images/2S.png"},
                new Card() {Value = 3, Name = "Three Spades", Image = "Resources/Images/3S.png"},
                new Card() {Value = 4, Name = "Four Spades", Image = "Resources/Images/4S.png"},
                new Card() {Value = 5, Name = "Five Spades", Image = "Resources/Images/5S.png"},
                new Card() {Value = 6, Name = "Six Spades", Image = "Resources/Images/6S.png"},
                new Card() {Value = 7, Name = "Seven Spades", Image = "Resources/Images/7S.png"},
                new Card() {Value = 8, Name = "Eight Spades", Image = "Resources/Images/8S.png"},
                new Card() {Value = 9, Name = "Nine Spades", Image = "Resources/Images/9S.png"},
                new Card() {Value = 10, Name = "Ten Spades", Image = "Resources/Images/10S.png"},
                new Card() {Value = 10, Name = "Jack Spades", Image = "Resources/Images/JS.png"},
                new Card() {Value = 10, Name = "Queen Spades", Image = "Resources/Images/QS.png"},
                new Card() {Value = 10, Name = "King Spades", Image = "Resources/Images/KS.png"},
                new Card() {Value = 11, Name = "Ace Spades", Image = "Resources/Images/AS.png"},

                // Diamonds
                new Card() {Value = 2, Name = "Two Diamonds", Image = "Resources/Images/2D.png"},
                new Card() {Value = 3, Name = "Three Diamonds", Image = "Resources/Images/3D.png"},
                new Card() {Value = 4, Name = "Four Diamonds", Image = "Resources/Images/4D.png"},
                new Card() {Value = 5, Name = "Five Diamonds", Image = "Resources/Images/5D.png"},
                new Card() {Value = 6, Name = "Six Diamonds", Image = "Resources/Images/6D.png"},
                new Card() {Value = 7, Name = "Seven Diamonds", Image = "Resources/Images/7D.png"},
                new Card() {Value = 8, Name = "Eight Diamonds", Image = "Resources/Images/8D.png"},
                new Card() {Value = 9, Name = "Nine Diamonds", Image = "Resources/Images/9D.png"},
                new Card() {Value = 10, Name = "Ten Diamonds", Image = "Resources/Images/10D.png"},
                new Card() {Value = 10, Name = "Jack Diamonds", Image = "Resources/Images/JD.png"},
                new Card() {Value = 10, Name = "Queen Diamonds", Image = "Resources/Images/QD.png"},
                new Card() {Value = 10, Name = "King Diamonds", Image = "Resources/Images/KD.png"},
                new Card() {Value = 11, Name = "Ace Diamonds", Image = "Resources/Images/AD.png"},

                // Hearts
                new Card() {Value = 2, Name = "Two Hearts", Image = "Resources/Images/2H.png"},
                new Card() {Value = 3, Name = "Three Hearts", Image = "Resources/Images/3H.png"},
                new Card() {Value = 4, Name = "Four Hearts", Image = "Resources/Images/4H.png"},
                new Card() {Value = 5, Name = "Five Hearts", Image = "Resources/Images/5H.png"},
                new Card() {Value = 6, Name = "Six Hearts", Image = "Resources/Images/6H.png"},
                new Card() {Value = 7, Name = "Seven Hearts", Image = "Resources/Images/7H.png"},
                new Card() {Value = 8, Name = "Eight Hearts", Image = "Resources/Images/8H.png"},
                new Card() {Value = 9, Name = "Nine Hearts", Image = "Resources/Images/9H.png"},
                new Card() {Value = 10, Name = "Ten Hearts", Image = "Resources/Images/10H.png"},
                new Card() {Value = 10, Name = "Jack Hearts", Image = "Resources/Images/JH.png"},
                new Card() {Value = 10, Name = "Queen Hearts", Image = "Resources/Images/QH.png"},
                new Card() {Value = 10, Name = "King Hearts", Image = "Resources/Images/KH.png"},
                new Card() {Value = 11, Name = "Ace Hearts", Image = "Resources/Images/AH.png"}
        };

        List<PictureBox> dealerPictureBox = new List<PictureBox>();
        List<PictureBox> playerPictureBox = new List<PictureBox>();

        void WriteGameData()
        {
            string filePath = Path.Combine(Application.UserAppDataPath, "game_data.txt");
            using StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine(balance);
            writer.WriteLine(xp);
        }

        void ReadGameData()
        {
            string filePath = Path.Combine(Application.UserAppDataPath, "game_data.txt");
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    balance = int.Parse(reader.ReadLine());
                    xp = int.Parse(reader.ReadLine());
                }
            }
        }

        int ModifyBalance(int amount)
        {
            balance += amount;
            lbl_balance.Text = $"Balance: ${balance}";
            return balance;
        }

        void UpdateBetLabel()
        {

            if (betAmount > 9)
            {
                lbl_totalBet.Text = $"Max bet: ${balance}";
                lbl_betAmount.Text = $"${betAmount}";
            }
            else
            {
                lbl_totalBet.Text = $"Max bet: ${balance} - No XP gained!";
                lbl_betAmount.Text = $"${betAmount}";
            }
        }

        void LogToHistory(string message)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            TreeNode rootNode = new TreeNode($"Game: {gamesPlayed} / {message}");

            historyTree.Nodes.Insert(0, rootNode);

            TreeNode lastAddedNode = rootNode;

            TreeNode childNode1 = new TreeNode($"You {playerCardSum} / {dealerCardSum} Dealer");
            TreeNode childNode2 = new TreeNode($"Bet amount: ${betAmount}");
            TreeNode childNode3 = new TreeNode($"XP: {betAmount / 10}");
            TreeNode childNode4 = new TreeNode($"Time: {currentTime}");
            lastAddedNode.Nodes.Add(childNode1);
            lastAddedNode.Nodes.Add(childNode2);
            lastAddedNode.Nodes.Add(childNode3);
            lastAddedNode.Nodes.Add(childNode4);
        }

        void DisplayCardBack(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = "Resources/Images/BR.png";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void EnableButtons(bool arg)
        {
            btn_hit.Enabled = arg;
            btn_stand.Enabled = arg;
        }

        void EnableBetButtons(bool arg)
        {
            btn_increaseBet.Enabled = arg;
            btn_decreaseBet.Enabled = arg;
        }

        void ResetGame()
        {
            gamesPlayed++;
            WriteGameData();
            gameStarted = false;
            playerCardSum = 0;
            dealerCardSum = 0;
            usedCards.Clear();
            playerCards.Clear();
            dealerCards.Clear();
            EnableButtons(true);
            EnableBetButtons(true);
            btn_stand.Enabled = false;

            foreach (PictureBox pb in playerPictureBox)
            {
                this.Controls.Remove(pb);
            }
            playerPictureBox = new List<PictureBox>();

            foreach (PictureBox pb in dealerPictureBox)
            {
                this.Controls.Remove(pb);
            }
            dealerPictureBox = new List<PictureBox>();


            DisplayCardBack(pb_banker);
            DisplayCardBack(pb_player);
            DisplayCardBack(pb_player1);

            if (betAmount > balance)
            {
                betAmount = balance;
                UpdateBetLabel();
            }
        }

        void SumCards(List<Card> cards, ref int sum)
        {
            sum = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                sum += cards[i].Value;
            }

            if (sum > 21)
            {
                foreach (Card c in cards)
                {
                    if (c.Value == 11)
                    {
                        sum -= 10;
                        if (sum <= 21)
                        {
                            break;
                        }
                    }
                }
            }

            lbl_status.Text = $"[{Environment.UserName} {playerCardSum} / {dealerCardSum} Gregor]";
        }

        int DrawRandomCard()
        {
            int randomCard;
            randomCard = random.Next(0, cardDeck.Count);

            while (usedCards.Contains(randomCard))
            {
                randomCard = random.Next(0, cardDeck.Count);
            }

            usedCards.Add(randomCard);

            return randomCard;
        }

        void WinGame()
        {
            lbl_status.Text = $"[You won! {Environment.UserName} {playerCardSum} / {dealerCardSum} Gregor]";
            ModifyBalance(+(betAmount * 2));

            if (betAmount >= 5)
            {
                xp += betAmount / 10;
                LogToHistory($"Won ${betAmount}");
            }
            else
            {
                LogToHistory($"Won");
            }

            lbl_xp.Text = $"XP: {xp}";
        }

        void LoseGame()
        {
            lbl_status.Text = $"[You lost! {Environment.UserName} {playerCardSum} / {dealerCardSum} Gregor]";

            if (betAmount >= 5)
            {
                LogToHistory($"Lost ${betAmount}");
            }
            else
            {
                LogToHistory($"Lost");
            }
        }

        void TieGame()
        {
            lbl_status.Text = $"[Standoff! {Environment.UserName} {playerCardSum} / {dealerCardSum} Gregor]";
            LogToHistory($"Tied");
            ModifyBalance(+(betAmount));
        }

        public Main()
        {
            ReadGameData();
            InitializeComponent();
            lbl_balance.Text = $"Balance: ${balance}";
            lbl_xp.Text = $"XP: {xp}";
            lbl_status.Text = $"[Begin the game by pressing 'Start']";
            UpdateBetLabel();
            ResetGame();

            if (xp == 0 && balance == 0)
            {
                balance = 100;
            }
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
            betAmount = Math.Clamp(betAmount, 0, balance);
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
            betAmount = Math.Clamp(betAmount, 0, balance);
            UpdateBetLabel();
        }

        private void btn_hit_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                int randomPick = DrawRandomCard();
                Card card = cardDeck[randomPick];

                PictureBox pb = new PictureBox();
                pb.Width = 108;
                pb.Height = 144;
                pb.Location = new Point(240 + playerPictureBox.Count * 115, 191);
                pb.ImageLocation = card.Image;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                this.Controls.Add(pb);

                playerPictureBox.Add(pb);

                playerCards.Add(card);
            }
            else
            {
                gameStarted = true;
                btn_stand.Enabled = true;
                btn_hit.Text = "Hit";

                ModifyBalance(-betAmount);

                EnableBetButtons(false);

                int holeCard1 = DrawRandomCard();
                Card card1 = cardDeck[holeCard1];

                int holeCard2 = DrawRandomCard();
                Card card2 = cardDeck[holeCard2];

                playerCards.Add(card1);
                pb_player.ImageLocation = card1.Image;
                pb_player.SizeMode = PictureBoxSizeMode.StretchImage;

                playerCards.Add(card2);
                pb_player1.ImageLocation = card2.Image;
                pb_player1.SizeMode = PictureBoxSizeMode.StretchImage;

                int dealerHoleCard = DrawRandomCard();

                Card card3 = cardDeck[dealerHoleCard];

                dealerCards.Add(card3);
                pb_banker.ImageLocation = card3.Image;
                pb_banker.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            SumCards(playerCards, ref playerCardSum);
            SumCards(dealerCards, ref dealerCardSum);

            if (playerCardSum > 21)
            {
                LoseGame();
                ResetGame();
            }
        }

        private async void btn_stand_Click(object sender, EventArgs e)
        {
            while (dealerCardSum <= 16)
            {
                EnableButtons(false);
                int randomCard = DrawRandomCard();
                Card card = cardDeck[randomCard];

                PictureBox pb = new PictureBox();
                pb.Width = 108;
                pb.Height = 144;
                pb.Location = new Point(126 + dealerPictureBox.Count * 115, 41);
                pb.ImageLocation = card.Image;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                this.Controls.Add(pb);

                dealerPictureBox.Add(pb);
                dealerCards.Add(card);
                SumCards(dealerCards, ref dealerCardSum);
                await Task.Delay(gameSpeed);
            }

            SumCards(playerCards, ref playerCardSum);

            await Task.Delay(gameSpeed * 4);
            if (dealerCardSum > 21 || playerCardSum > dealerCardSum)
            {
                WinGame();
                ResetGame();
            }
            else if (dealerCardSum > playerCardSum)
            {
                LoseGame();
                ResetGame();
            }
            else
            {
                TieGame();
                ResetGame();
            }
        }

        private void deleteSaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This will delete ALL data, are you sure?";
            string title = "Delete Save Data";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                xp = 0;
                balance = 100;
                WriteGameData();
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSpeed = 500;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSpeed = 250;
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSpeed = 150;
        }

        private void speedrunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSpeed = 50;
        }

        private void btn_website_Click(object sender, EventArgs e)
        {
            //site
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnl_settings.Visible)
            {
                pnl_settings.Hide();
            }
            else
            {
                pnl_settings.Show();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_speed100.Checked)
            {
                gameSpeed = 100;
            }
            else if (rb_speed250.Checked)
            {
                gameSpeed = 250;
            }
            else if (rb_speed500.Checked)
            {
                gameSpeed = 500;
            }
            else if (rb_speed1000.Checked)
            {
                gameSpeed = 1000;
            }
            else if (rb_speed2500.Checked)
            {
                gameSpeed = 2500;
            }
        }
    }
}