namespace blackjack_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navbar = new System.Windows.Forms.ToolStrip();
            this.dd_menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_website = new System.Windows.Forms.ToolStripMenuItem();
            this.forfeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSaveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_welcome = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dd_menu,
            this.lbl_welcome,
            this.toolStripSeparator1,
            this.lbl_balance,
            this.toolStripSeparator2,
            this.lbl_wins});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(834, 25);
            this.navbar.TabIndex = 1;
            // 
            // dd_menu
            // 
            this.dd_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dd_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dd_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_website,
            this.forfeitToolStripMenuItem,
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
            // 
            // forfeitToolStripMenuItem
            // 
            this.forfeitToolStripMenuItem.Enabled = false;
            this.forfeitToolStripMenuItem.Name = "forfeitToolStripMenuItem";
            this.forfeitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.forfeitToolStripMenuItem.Text = "Forfeit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundColourToolStripMenuItem,
            this.deleteSaveDataToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeBackgroundColourToolStripMenuItem
            // 
            this.changeBackgroundColourToolStripMenuItem.Name = "changeBackgroundColourToolStripMenuItem";
            this.changeBackgroundColourToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.changeBackgroundColourToolStripMenuItem.Text = "Change background colour";
            // 
            // deleteSaveDataToolStripMenuItem
            // 
            this.deleteSaveDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSaveDataToolStripMenuItem.Name = "deleteSaveDataToolStripMenuItem";
            this.deleteSaveDataToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.deleteSaveDataToolStripMenuItem.Text = "Delete save data";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(132, 22);
            this.lbl_welcome.Text = "Welcome, {USERNAME}";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.btn_hit.Location = new System.Drawing.Point(12, 399);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(125, 50);
            this.btn_hit.TabIndex = 2;
            this.btn_hit.Text = "Hit";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_stand.Location = new System.Drawing.Point(143, 399);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(125, 50);
            this.btn_stand.TabIndex = 3;
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = true;
            // 
            // btn_increaseBet
            // 
            this.btn_increaseBet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_increaseBet.Location = new System.Drawing.Point(274, 399);
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
            this.btn_decreaseBet.Location = new System.Drawing.Point(274, 424);
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
            this.lbl_totalBet.Location = new System.Drawing.Point(330, 399);
            this.lbl_totalBet.Name = "lbl_totalBet";
            this.lbl_totalBet.Size = new System.Drawing.Size(55, 15);
            this.lbl_totalBet.TabIndex = 6;
            this.lbl_totalBet.Text = "Total bet:";
            // 
            // lbl_betAmount
            // 
            this.lbl_betAmount.AutoSize = true;
            this.lbl_betAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_betAmount.Location = new System.Drawing.Point(330, 415);
            this.lbl_betAmount.Name = "lbl_betAmount";
            this.lbl_betAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_betAmount.Size = new System.Drawing.Size(194, 32);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lbl_betAmount);
            this.Controls.Add(this.btn_increaseBet);
            this.Controls.Add(this.lbl_totalBet);
            this.Controls.Add(this.pb_player1);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.btn_decreaseBet);
            this.Controls.Add(this.pb_banker);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.btn_hit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip navbar;
        private ToolStripDropDownButton dd_menu;
        private ToolStripLabel lbl_welcome;
        private ToolStripMenuItem btn_website;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lbl_balance;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel lbl_wins;
        private ToolStripMenuItem forfeitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem deleteSaveDataToolStripMenuItem;
        private Button btn_hit;
        private Button btn_stand;
        private Button btn_increaseBet;
        private Button btn_decreaseBet;
        private Label lbl_totalBet;
        private Label lbl_betAmount;
        private ToolStripMenuItem changeBackgroundColourToolStripMenuItem;
        private PictureBox pb_banker;
        private PictureBox pb_player;
        private PictureBox pb_player1;
    }
}