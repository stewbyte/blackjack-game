using System.Diagnostics;

namespace blackjack_game
{
    public partial class Main : Form
    {
        int balance;
        int betAmount = 0;
        int xp;
        uint gamesPlayed;

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

            GregorTalk("annoyed");

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
            GregorTalk("happy");

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
            GregorTalk("greet");
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

        private void btn_reset_Click(object sender, EventArgs e)
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

        private void btn_resources_Click(object sender, EventArgs e)
        {
            string resourcesPath = Path.Combine(Application.StartupPath, "Resources");

            if (Directory.Exists(resourcesPath))
            {
                // The Resources folder exists, so you can open it in File Explorer:
                Process.Start("explorer.exe", resourcesPath);
            }
            else
            {
                MessageBox.Show("No resources folder found!");
            }
        }

        private void btn_website_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.stw.dev") { UseShellExecute = true });
        }

        private void btn_github_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Steffew") { UseShellExecute = true });
        }

        void GregorTalk(string arg)
        {
            int prevRandom = -1;

            int r;
            do
            {
                r = random.Next(0, 21);
            } while (r == prevRandom);

            prevRandom = r;

            if (arg == "greet")
            {
                #region switch Greet
                switch (r)
                {
                    case 0:
                        gregorBox.Text = $"There you are, how is my little friend doing?";
                        break;
                    case 1:
                        gregorBox.Text = $"Aha, {Environment.UserName}. I have heard about you.";
                        break;
                    case 2:
                        gregorBox.Text = $"Finally, you are here.";
                        break;
                    case 3:
                        gregorBox.Text = $"Is this my opponent? Should be a piece of Medovik.";
                        break;
                    case 4:
                        gregorBox.Text = $"Privet.";
                        break;
                    case 5:
                        gregorBox.Text = $"Well, well, well. A new challenger has arrived. Let's see what you're made of.";
                        break;
                    case 6:
                        gregorBox.Text = $"Greetings, young one. You've come to face the master of the game.";
                        break;
                    case 7:
                        gregorBox.Text = $"Aha, a brave one. You're not afraid to lose, are you?";
                        break;
                    case 8:
                        gregorBox.Text = $"Privet. I am the one and only champion of this game.";
                        break;
                    case 9:
                        gregorBox.Text = $"Welcome, comrade. Are you ready to test your luck against me?";
                        break;
                    case 10:
                        gregorBox.Text = $"So, you think you have what it takes to beat me? We shall see.";
                        break;
                    case 11:
                        gregorBox.Text = $"Greetings, my friend. Do you have the skills to defeat me?";
                        break;
                    case 12:
                        gregorBox.Text = $"Is this my new opponent? You don't look like much of a challenge.";
                        break;
                    case 13:
                        gregorBox.Text = $"Ah, a fresh face. I hope you're not too disappointed when you lose.";
                        break;
                    case 14:
                        gregorBox.Text = $"Blin, another one? Fine, let's play this game again.";
                        break;
                    case 15:
                        gregorBox.Text = $"You've come to challenge the master of the game? We'll see how that goes.";
                        break;
                    case 16:
                        gregorBox.Text = $"Welcome to the game, {Environment.UserName}. I hope you're prepared to lose.";
                        break;
                    case 17:
                        gregorBox.Text = $"So, you think you can beat me? You have much to learn, my young friend.";
                        break;
                    case 18:
                        gregorBox.Text = $"Well, well, well. Another challenger. I hope you're not too disappointed when you lose.";
                        break;
                    case 19:
                        gregorBox.Text = $"Ah, it's you. I've been waiting for a new opponent to humiliate.";
                        break;
                    case 20:
                        gregorBox.Text = $"Privet. I am the champion of this game, and you're no match for me.";
                        break;
                }
                #endregion
            }

            else if (arg == "annoyed")
            {
                #region Switch Annoyed
                switch (r)
                {
                    case 0:
                        gregorBox.Text = $"Blin! How?";
                        break;
                    case 1:
                        gregorBox.Text = $"Luck, pure luck.";
                        break;
                    case 2:
                        gregorBox.Text = $"You got me this time.";
                        break;
                    case 3:
                        gregorBox.Text = $"I can't believe it. You have horsehoe stuck in pocket or what?";
                        break;
                    case 4:
                        gregorBox.Text = $"Always winning. Maybe I let you win, huh?";
                        break;
                    case 5:
                        gregorBox.Text = $"Blin! Game is rigged anyway!";
                        break;
                    case 6:
                        gregorBox.Text = $"Argh! I don't understand how you won.";
                        break;
                    case 7:
                        gregorBox.Text = $"Nyet! What is wrong with me?";
                        break;
                    case 8:
                        gregorBox.Text = $"You must be cheating somehow. I'm watching you.";
                        break;
                    case 9:
                        gregorBox.Text = $"You might have won this time, but it won't happen again.";
                        break;
                    case 10:
                        gregorBox.Text = $"One day you'll get what's coming to you, mark my words.";
                        break;
                    case 11:
                        gregorBox.Text = $"I don't know how you keep doing it, but it won't last forever.";
                        break;
                    case 12:
                        gregorBox.Text = $"You're not as good as you think you are, trust me.";
                        break;
                    case 13:
                        gregorBox.Text = $"You got lucky this time, don't let it go to your head.";
                        break;
                    case 14:
                        gregorBox.Text = $"I'll get you next time, you can count on it.";
                        break;
                    case 15:
                        gregorBox.Text = $"Don't get too comfortable, I'm just getting started.";
                        break;
                    case 16:
                        gregorBox.Text = $"You might have won the battle, but the war is far from over.";
                        break;
                    case 17:
                        gregorBox.Text = $"You're not the only one who knows how to play this game.";
                        break;
                    case 18:
                        gregorBox.Text = $"This was gift from me, I felt like I won too much.";
                        break;
                    case 19:
                        gregorBox.Text = $"Durak! Stop with the cheats!";
                        break;
                    case 20:
                        gregorBox.Text = $"You think you are so good, huh?";
                        break;
                }
                #endregion
            }

            else if (arg == "happy")
            {
                #region Switch Happy
                switch (r)
                {
                    case 0:
                        gregorBox.Text = $"Ha! You're no match for me, young one!";
                        break;
                    case 1:
                        gregorBox.Text = $"I knew I could beat you, it was just a matter of time.";
                        break;
                    case 2:
                        gregorBox.Text = $"You're not as good as you think you are. I have more experience.";
                        break;
                    case 3:
                        gregorBox.Text = $"I win again! Maybe you need some more practice, eh?";
                        break;
                    case 4:
                        gregorBox.Text = $"You think you can beat me? Hah! I laugh at your foolishness!";
                        break;
                    case 5:
                        gregorBox.Text = $"I am still the champion! You have much to learn, my friend.";
                        break;
                    case 6:
                        gregorBox.Text = $"It was a good try, but not good enough. Maybe next time?";
                        break;
                    case 7:
                        gregorBox.Text = $"You're not the first to challenge me, and you won't be the last.";
                        break;
                    case 8:
                        gregorBox.Text = $"Ha! Victory is mine once again!";
                        break;
                    case 9:
                        gregorBox.Text = $"I am unbeatable! You might as well give up now.";
                        break;
                    case 10:
                        gregorBox.Text = $"You thought you could beat me? Think again, youngster.";
                        break;
                    case 11:
                        gregorBox.Text = $"You have much to learn, but I'll teach you.";
                        break;
                    case 12:
                        gregorBox.Text = $"I could play this game with my eyes closed and still win.";
                        break;
                    case 13:
                        gregorBox.Text = $"You're not the first one to fall victim to my skills, and you won't be the last.";
                        break;
                    case 14:
                        gregorBox.Text = $"You'll have to try harder than that to beat me, comrade.";
                        break;
                    case 15:
                        gregorBox.Text = $"You're not a worthy opponent, but I like winning from you.";
                        break;
                    case 16:
                        gregorBox.Text = $"I could win this game with one hand tied behind my back.";
                        break;
                    case 17:
                        gregorBox.Text = $"You're outmatched, my friend. It's time to concede.";
                        break;
                    case 18:
                        gregorBox.Text = $"I win again! You might as well give up now.";
                        break;
                    case 19:
                        gregorBox.Text = $"You thought you had a chance? Ha! You're no match for me.";
                        break;
                    case 20:
                        gregorBox.Text = $"Victory is mine once again! You need more than luck to beat me, my friend.";
                        break;
                }
                #endregion
            }
        }
    }
}