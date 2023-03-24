namespace blackjack_game
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnIncreaseBet = new System.Windows.Forms.Button();
            this.btnDecreaseBet = new System.Windows.Forms.Button();
            this.lblTotalBet = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.pbxBanker = new System.Windows.Forms.PictureBox();
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.pbxPlayer1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gregorBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.historyTree = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnWebsite = new System.Windows.Forms.Button();
            this.gbxResources = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnResources = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxHowToPlay = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxGameSpeed = new System.Windows.Forms.GroupBox();
            this.rbnSpeed2500 = new System.Windows.Forms.RadioButton();
            this.rbnSpeed1000 = new System.Windows.Forms.RadioButton();
            this.rbnSpeed500 = new System.Windows.Forms.RadioButton();
            this.rbnSpeed250 = new System.Windows.Forms.RadioButton();
            this.rbnSpeed100 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxResources.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxHowToPlay.SuspendLayout();
            this.gbxGameSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_hit
            // 
            this.btnHit.FlatAppearance.BorderSize = 0;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Work Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHit.Location = new System.Drawing.Point(3, 3);
            this.btnHit.Name = "btn_hit";
            this.btnHit.Size = new System.Drawing.Size(125, 50);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btn_stand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.FlatAppearance.BorderSize = 0;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Work Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStand.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStand.Location = new System.Drawing.Point(134, 3);
            this.btnStand.Name = "btn_stand";
            this.btnStand.Size = new System.Drawing.Size(125, 50);
            this.btnStand.TabIndex = 3;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btn_increaseBet
            // 
            this.btnIncreaseBet.FlatAppearance.BorderSize = 0;
            this.btnIncreaseBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseBet.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncreaseBet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIncreaseBet.Location = new System.Drawing.Point(329, 3);
            this.btnIncreaseBet.Name = "btn_increaseBet";
            this.btnIncreaseBet.Size = new System.Drawing.Size(50, 25);
            this.btnIncreaseBet.TabIndex = 4;
            this.btnIncreaseBet.Text = "↑";
            this.btnIncreaseBet.UseVisualStyleBackColor = true;
            this.btnIncreaseBet.Click += new System.EventHandler(this.btnIncreaseBet_Click);
            // 
            // btn_decreaseBet
            // 
            this.btnDecreaseBet.FlatAppearance.BorderSize = 0;
            this.btnDecreaseBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseBet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecreaseBet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDecreaseBet.Location = new System.Drawing.Point(329, 28);
            this.btnDecreaseBet.Name = "btn_decreaseBet";
            this.btnDecreaseBet.Size = new System.Drawing.Size(50, 25);
            this.btnDecreaseBet.TabIndex = 5;
            this.btnDecreaseBet.Text = "↓";
            this.btnDecreaseBet.UseVisualStyleBackColor = true;
            this.btnDecreaseBet.Click += new System.EventHandler(this.btnDecreaseBet_Click);
            // 
            // lbl_totalBet
            // 
            this.lblTotalBet.AutoSize = true;
            this.lblTotalBet.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalBet.Location = new System.Drawing.Point(385, 3);
            this.lblTotalBet.Name = "lbl_totalBet";
            this.lblTotalBet.Size = new System.Drawing.Size(65, 17);
            this.lblTotalBet.TabIndex = 6;
            this.lblTotalBet.Text = "Total bet:";
            // 
            // lbl_betAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Font = new System.Drawing.Font("Work Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBetAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBetAmount.Location = new System.Drawing.Point(385, 18);
            this.lblBetAmount.Name = "lbl_betAmount";
            this.lblBetAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBetAmount.Size = new System.Drawing.Size(202, 35);
            this.lblBetAmount.TabIndex = 7;
            this.lblBetAmount.Text = "${BETAMOUNT}";
            this.lblBetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_banker
            // 
            this.pbxBanker.Location = new System.Drawing.Point(12, 41);
            this.pbxBanker.Name = "pb_banker";
            this.pbxBanker.Size = new System.Drawing.Size(108, 144);
            this.pbxBanker.TabIndex = 0;
            this.pbxBanker.TabStop = false;
            // 
            // pb_player
            // 
            this.pbxPlayer.Location = new System.Drawing.Point(12, 191);
            this.pbxPlayer.Name = "pb_player";
            this.pbxPlayer.Size = new System.Drawing.Size(108, 144);
            this.pbxPlayer.TabIndex = 1;
            this.pbxPlayer.TabStop = false;
            // 
            // pb_player1
            // 
            this.pbxPlayer1.Location = new System.Drawing.Point(126, 191);
            this.pbxPlayer1.Name = "pb_player1";
            this.pbxPlayer1.Size = new System.Drawing.Size(108, 144);
            this.pbxPlayer1.TabIndex = 2;
            this.pbxPlayer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnStand);
            this.panel1.Controls.Add(this.lblTotalBet);
            this.panel1.Controls.Add(this.lblBetAmount);
            this.panel1.Controls.Add(this.btnHit);
            this.panel1.Controls.Add(this.btnIncreaseBet);
            this.panel1.Controls.Add(this.btnDecreaseBet);
            this.panel1.Location = new System.Drawing.Point(12, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 57);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.gregorBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 114);
            this.panel2.TabIndex = 9;
            // 
            // gregorBox
            // 
            this.gregorBox.AutoSize = true;
            this.gregorBox.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gregorBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gregorBox.Location = new System.Drawing.Point(114, 23);
            this.gregorBox.Name = "gregorBox";
            this.gregorBox.Size = new System.Drawing.Size(51, 17);
            this.gregorBox.TabIndex = 2;
            this.gregorBox.Text = "Gregor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(114, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gregor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::blackjack_game.Properties.Resources.Gregor;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_status
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(3, 3);
            this.lblStatus.Name = "lbl_status";
            this.lblStatus.Size = new System.Drawing.Size(279, 19);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "[Press Start to start a game!]";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Location = new System.Drawing.Point(12, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 25);
            this.panel3.TabIndex = 10;
            // 
            // historyTree
            // 
            this.historyTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.historyTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyTree.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.historyTree.ForeColor = System.Drawing.SystemColors.Window;
            this.historyTree.Location = new System.Drawing.Point(608, 341);
            this.historyTree.Name = "historyTree";
            this.historyTree.Scrollable = false;
            this.historyTree.ShowPlusMinus = false;
            this.historyTree.ShowRootLines = false;
            this.historyTree.Size = new System.Drawing.Size(264, 208);
            this.historyTree.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Controls.Add(this.lblXp);
            this.panel4.Controls.Add(this.lblBalance);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 23);
            this.panel4.TabIndex = 13;
            // 
            // btn_menu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMenu.Location = new System.Drawing.Point(785, 0);
            this.btnMenu.Name = "btn_menu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.panelToggle_Click);
            // 
            // lbl_xp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Font = new System.Drawing.Font("Work Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblXp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblXp.Location = new System.Drawing.Point(219, 3);
            this.lblXp.Name = "lbl_xp";
            this.lblXp.Size = new System.Drawing.Size(27, 17);
            this.lblXp.TabIndex = 1;
            this.lblXp.Text = "XP:";
            // 
            // lbl_balance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Work Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBalance.Location = new System.Drawing.Point(3, 3);
            this.lblBalance.Name = "lbl_balance";
            this.lblBalance.Size = new System.Drawing.Size(92, 17);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance: $100";
            // 
            // pnl_settings
            // 
            this.pnlSettings.Controls.Add(this.groupBox2);
            this.pnlSettings.Controls.Add(this.gbxResources);
            this.pnlSettings.Controls.Add(this.groupBox1);
            this.pnlSettings.Controls.Add(this.gbxHowToPlay);
            this.pnlSettings.Controls.Add(this.gbxGameSpeed);
            this.pnlSettings.Location = new System.Drawing.Point(12, 41);
            this.pnlSettings.Name = "pnl_settings";
            this.pnlSettings.Size = new System.Drawing.Size(860, 508);
            this.pnlSettings.TabIndex = 14;
            this.pnlSettings.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGithub);
            this.groupBox2.Controls.Add(this.btnWebsite);
            this.groupBox2.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(3, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 82);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other links";
            // 
            // btn_github
            // 
            this.btnGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGithub.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGithub.Location = new System.Drawing.Point(7, 51);
            this.btnGithub.Name = "btn_github";
            this.btnGithub.Size = new System.Drawing.Size(113, 23);
            this.btnGithub.TabIndex = 16;
            this.btnGithub.Text = "My Github";
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btn_website
            // 
            this.btnWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnWebsite.FlatAppearance.BorderSize = 0;
            this.btnWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebsite.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWebsite.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnWebsite.Location = new System.Drawing.Point(7, 22);
            this.btnWebsite.Name = "btn_website";
            this.btnWebsite.Size = new System.Drawing.Size(113, 23);
            this.btnWebsite.TabIndex = 15;
            this.btnWebsite.Text = "My website";
            this.btnWebsite.UseVisualStyleBackColor = false;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // gb_resources
            // 
            this.gbxResources.Controls.Add(this.textBox2);
            this.gbxResources.Controls.Add(this.btnResources);
            this.gbxResources.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxResources.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxResources.Location = new System.Drawing.Point(132, 205);
            this.gbxResources.Name = "gb_resources";
            this.gbxResources.Size = new System.Drawing.Size(247, 155);
            this.gbxResources.TabIndex = 16;
            this.gbxResources.TabStop = false;
            this.gbxResources.Text = "Resources";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Work Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(6, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(235, 95);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "If you want to replace the textures you can do so here.\r\n";
            // 
            // btn_resources
            // 
            this.btnResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnResources.FlatAppearance.BorderSize = 0;
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResources.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnResources.Location = new System.Drawing.Point(128, 126);
            this.btnResources.Name = "btn_resources";
            this.btnResources.Size = new System.Drawing.Size(113, 23);
            this.btnResources.TabIndex = 15;
            this.btnResources.Text = "Open folder";
            this.btnResources.UseVisualStyleBackColor = false;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(732, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset data";
            // 
            // btn_reset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Location = new System.Drawing.Point(6, 22);
            this.btnReset.Name = "btn_reset";
            this.btnReset.Size = new System.Drawing.Size(113, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset data";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gb_howtoplay
            // 
            this.gbxHowToPlay.Controls.Add(this.textBox1);
            this.gbxHowToPlay.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxHowToPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxHowToPlay.Location = new System.Drawing.Point(3, 3);
            this.gbxHowToPlay.Name = "gb_howtoplay";
            this.gbxHowToPlay.Size = new System.Drawing.Size(854, 196);
            this.gbxHowToPlay.TabIndex = 5;
            this.gbxHowToPlay.TabStop = false;
            this.gbxHowToPlay.Text = "How to play";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Work Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(842, 168);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // gb_gamespeed
            // 
            this.gbxGameSpeed.Controls.Add(this.rbnSpeed2500);
            this.gbxGameSpeed.Controls.Add(this.rbnSpeed1000);
            this.gbxGameSpeed.Controls.Add(this.rbnSpeed500);
            this.gbxGameSpeed.Controls.Add(this.rbnSpeed250);
            this.gbxGameSpeed.Controls.Add(this.rbnSpeed100);
            this.gbxGameSpeed.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxGameSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxGameSpeed.Location = new System.Drawing.Point(3, 205);
            this.gbxGameSpeed.Name = "gb_gamespeed";
            this.gbxGameSpeed.Size = new System.Drawing.Size(125, 155);
            this.gbxGameSpeed.TabIndex = 0;
            this.gbxGameSpeed.TabStop = false;
            this.gbxGameSpeed.Text = "Game speed";
            // 
            // rb_speed2500
            // 
            this.rbnSpeed2500.AutoSize = true;
            this.rbnSpeed2500.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnSpeed2500.Location = new System.Drawing.Point(6, 130);
            this.rbnSpeed2500.Name = "rb_speed2500";
            this.rbnSpeed2500.Size = new System.Drawing.Size(117, 21);
            this.rbnSpeed2500.TabIndex = 4;
            this.rbnSpeed2500.Text = "0.2x (Very slow)";
            this.rbnSpeed2500.UseVisualStyleBackColor = true;
            this.rbnSpeed2500.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed1000
            // 
            this.rbnSpeed1000.AutoSize = true;
            this.rbnSpeed1000.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnSpeed1000.Location = new System.Drawing.Point(6, 103);
            this.rbnSpeed1000.Name = "rb_speed1000";
            this.rbnSpeed1000.Size = new System.Drawing.Size(90, 21);
            this.rbnSpeed1000.TabIndex = 3;
            this.rbnSpeed1000.Text = "0.5x (Slow)";
            this.rbnSpeed1000.UseVisualStyleBackColor = true;
            this.rbnSpeed1000.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed500
            // 
            this.rbnSpeed500.AutoSize = true;
            this.rbnSpeed500.Checked = true;
            this.rbnSpeed500.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnSpeed500.Location = new System.Drawing.Point(6, 76);
            this.rbnSpeed500.Name = "rb_speed500";
            this.rbnSpeed500.Size = new System.Drawing.Size(102, 21);
            this.rbnSpeed500.TabIndex = 2;
            this.rbnSpeed500.TabStop = true;
            this.rbnSpeed500.Text = "1.0x (Normal)";
            this.rbnSpeed500.UseVisualStyleBackColor = true;
            this.rbnSpeed500.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed250
            // 
            this.rbnSpeed250.AutoSize = true;
            this.rbnSpeed250.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnSpeed250.Location = new System.Drawing.Point(6, 49);
            this.rbnSpeed250.Name = "rb_speed250";
            this.rbnSpeed250.Size = new System.Drawing.Size(85, 21);
            this.rbnSpeed250.TabIndex = 1;
            this.rbnSpeed250.Text = "2.0x (Fast)";
            this.rbnSpeed250.UseVisualStyleBackColor = true;
            this.rbnSpeed250.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed100
            // 
            this.rbnSpeed100.AutoSize = true;
            this.rbnSpeed100.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnSpeed100.Location = new System.Drawing.Point(6, 22);
            this.rbnSpeed100.Name = "rb_speed100";
            this.rbnSpeed100.Size = new System.Drawing.Size(113, 21);
            this.rbnSpeed100.TabIndex = 0;
            this.rbnSpeed100.Text = "5.0x (Very fast)";
            this.rbnSpeed100.UseVisualStyleBackColor = true;
            this.rbnSpeed100.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.historyTree);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxPlayer1);
            this.Controls.Add(this.pbxPlayer);
            this.Controls.Add(this.pbxBanker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Main";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbxResources.ResumeLayout(false);
            this.gbxResources.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbxHowToPlay.ResumeLayout(false);
            this.gbxHowToPlay.PerformLayout();
            this.gbxGameSpeed.ResumeLayout(false);
            this.gbxGameSpeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnHit;
        private Button btnStand;
        private Button btnIncreaseBet;
        private Button btnDecreaseBet;
        private Label lblTotalBet;
        private Label lblBetAmount;
        private PictureBox pbxBanker;
        private PictureBox pbxPlayer;
        private PictureBox pbxPlayer1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblStatus;
        private Panel panel3;
        private ColumnHeader Card;
        private TreeView historyTree;
        private Panel panel4;
        private Label lblBalance;
        private Label lblXp;
        private Button btnMenu;
        private Panel pnlSettings;
        private GroupBox gbxGameSpeed;
        private RadioButton rbnSpeed100;
        private RadioButton rbnSpeed500;
        private RadioButton rbnSpeed250;
        private RadioButton rbnSpeed2500;
        private RadioButton rbnSpeed1000;
        private GroupBox gbxHowToPlay;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnReset;
        private GroupBox gbxResources;
        private TextBox textBox2;
        private Button btnResources;
        private GroupBox groupBox2;
        private Button btnWebsite;
        private Button btnGithub;
        private Label gregorBox;
        private Label label1;
    }
}