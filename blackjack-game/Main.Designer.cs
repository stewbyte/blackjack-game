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
            this.navbar = new System.Windows.Forms.ToolStrip();
            this.dd_menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_website = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedrunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSaveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_balance = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_wins = new System.Windows.Forms.ToolStripLabel();
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stand = new System.Windows.Forms.Button();
            this.btn_increaseBet = new System.Windows.Forms.Button();
            this.btn_decreaseBet = new System.Windows.Forms.Button();
            this.lbl_totalBet = new System.Windows.Forms.Label();
            this.lbl_betAmount = new System.Windows.Forms.Label();
            this.pb_banker = new System.Windows.Forms.PictureBox();
            this.pb_player = new System.Windows.Forms.PictureBox();
            this.pb_player1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.historyTree = new System.Windows.Forms.TreeView();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dd_menu,
            this.lbl_balance,
            this.toolStripSeparator2,
            this.lbl_wins});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(884, 25);
            this.navbar.TabIndex = 1;
            // 
            // dd_menu
            // 
            this.dd_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dd_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dd_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_website,
            this.settingsToolStripMenuItem});
            this.dd_menu.Image = ((System.Drawing.Image)(resources.GetObject("dd_menu.Image")));
            this.dd_menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dd_menu.Name = "dd_menu";
            this.dd_menu.Size = new System.Drawing.Size(51, 22);
            this.dd_menu.Text = "Menu";
            // 
            // btn_website
            // 
            this.btn_website.Name = "btn_website";
            this.btn_website.Size = new System.Drawing.Size(116, 22);
            this.btn_website.Text = "Website";
            this.btn_website.Click += new System.EventHandler(this.btn_website_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameSpeedToolStripMenuItem,
            this.deleteSaveDataToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // gameSpeedToolStripMenuItem
            // 
            this.gameSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.speedrunToolStripMenuItem});
            this.gameSpeedToolStripMenuItem.Name = "gameSpeedToolStripMenuItem";
            this.gameSpeedToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.gameSpeedToolStripMenuItem.Text = "Game speed";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.slowToolStripMenuItem.Text = "Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fastToolStripMenuItem.Text = "Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // speedrunToolStripMenuItem
            // 
            this.speedrunToolStripMenuItem.Name = "speedrunToolStripMenuItem";
            this.speedrunToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.speedrunToolStripMenuItem.Text = "Speedrun";
            this.speedrunToolStripMenuItem.Click += new System.EventHandler(this.speedrunToolStripMenuItem_Click);
            // 
            // deleteSaveDataToolStripMenuItem
            // 
            this.deleteSaveDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSaveDataToolStripMenuItem.Name = "deleteSaveDataToolStripMenuItem";
            this.deleteSaveDataToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteSaveDataToolStripMenuItem.Text = "Delete save data";
            this.deleteSaveDataToolStripMenuItem.Click += new System.EventHandler(this.deleteSaveDataToolStripMenuItem_Click);
            // 
            // lbl_balance
            // 
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(120, 22);
            this.lbl_balance.Text = "Balance: ${BALANCE}";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_wins
            // 
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(121, 22);
            this.lbl_wins.Text = "Wins: {WINAMOUNT}";
            // 
            // btn_hit
            // 
            this.btn_hit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hit.Location = new System.Drawing.Point(3, 3);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(125, 50);
            this.btn_hit.TabIndex = 2;
            this.btn_hit.Text = "Hit";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Enabled = false;
            this.btn_stand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_stand.Location = new System.Drawing.Point(134, 3);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(125, 50);
            this.btn_stand.TabIndex = 3;
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // btn_increaseBet
            // 
            this.btn_increaseBet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_increaseBet.Location = new System.Drawing.Point(265, 3);
            this.btn_increaseBet.Name = "btn_increaseBet";
            this.btn_increaseBet.Size = new System.Drawing.Size(50, 25);
            this.btn_increaseBet.TabIndex = 4;
            this.btn_increaseBet.Text = "↑";
            this.btn_increaseBet.UseVisualStyleBackColor = true;
            this.btn_increaseBet.Click += new System.EventHandler(this.btn_increaseBet_Click);
            // 
            // btn_decreaseBet
            // 
            this.btn_decreaseBet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_decreaseBet.Location = new System.Drawing.Point(265, 28);
            this.btn_decreaseBet.Name = "btn_decreaseBet";
            this.btn_decreaseBet.Size = new System.Drawing.Size(50, 25);
            this.btn_decreaseBet.TabIndex = 5;
            this.btn_decreaseBet.Text = "↓";
            this.btn_decreaseBet.UseVisualStyleBackColor = true;
            this.btn_decreaseBet.Click += new System.EventHandler(this.btn_decreaseBet_Click);
            // 
            // lbl_totalBet
            // 
            this.lbl_totalBet.AutoSize = true;
            this.lbl_totalBet.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalBet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_totalBet.Location = new System.Drawing.Point(321, 3);
            this.lbl_totalBet.Name = "lbl_totalBet";
            this.lbl_totalBet.Size = new System.Drawing.Size(65, 17);
            this.lbl_totalBet.TabIndex = 6;
            this.lbl_totalBet.Text = "Total bet:";
            // 
            // lbl_betAmount
            // 
            this.lbl_betAmount.AutoSize = true;
            this.lbl_betAmount.Font = new System.Drawing.Font("Work Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_betAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_betAmount.Location = new System.Drawing.Point(321, 18);
            this.lbl_betAmount.Name = "lbl_betAmount";
            this.lbl_betAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_betAmount.Size = new System.Drawing.Size(202, 35);
            this.lbl_betAmount.TabIndex = 7;
            this.lbl_betAmount.Text = "${BETAMOUNT}";
            this.lbl_betAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_banker
            // 
            this.pb_banker.Location = new System.Drawing.Point(12, 28);
            this.pb_banker.Name = "pb_banker";
            this.pb_banker.Size = new System.Drawing.Size(108, 144);
            this.pb_banker.TabIndex = 0;
            this.pb_banker.TabStop = false;
            // 
            // pb_player
            // 
            this.pb_player.Location = new System.Drawing.Point(12, 178);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(108, 144);
            this.pb_player.TabIndex = 1;
            this.pb_player.TabStop = false;
            // 
            // pb_player1
            // 
            this.pb_player1.Location = new System.Drawing.Point(126, 178);
            this.pb_player1.Name = "pb_player1";
            this.pb_player1.Size = new System.Drawing.Size(108, 144);
            this.pb_player1.TabIndex = 2;
            this.pb_player1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btn_stand);
            this.panel1.Controls.Add(this.lbl_totalBet);
            this.panel1.Controls.Add(this.lbl_betAmount);
            this.panel1.Controls.Add(this.btn_hit);
            this.panel1.Controls.Add(this.btn_increaseBet);
            this.panel1.Controls.Add(this.btn_decreaseBet);
            this.panel1.Location = new System.Drawing.Point(12, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 57);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 114);
            this.panel2.TabIndex = 9;
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
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_status.Location = new System.Drawing.Point(3, 3);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(279, 19);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "[Press Start to start a game!]";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.lbl_status);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.historyTree);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_player1);
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.pb_banker);
            this.Controls.Add(this.navbar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Main";
            this.Text = "Blackjack";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip navbar;
        private ToolStripDropDownButton dd_menu;
        private ToolStripMenuItem btn_website;
        private ToolStripLabel lbl_balance;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel lbl_wins;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem deleteSaveDataToolStripMenuItem;
        private Button btn_hit;
        private Button btn_stand;
        private Button btn_increaseBet;
        private Button btn_decreaseBet;
        private Label lbl_totalBet;
        private Label lbl_betAmount;
        private PictureBox pb_banker;
        private PictureBox pb_player;
        private PictureBox pb_player1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lbl_status;
        private Panel panel3;
        private ColumnHeader Card;
        private ToolStripMenuItem gameSpeedToolStripMenuItem;
        private ToolStripMenuItem slowToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem fastToolStripMenuItem;
        private ToolStripMenuItem speedrunToolStripMenuItem;
        private TreeView historyTree;
    }
}