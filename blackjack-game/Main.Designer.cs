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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.lbl_xp = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.pnl_settings = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_hit
            // 
            this.btn_hit.FlatAppearance.BorderSize = 0;
            this.btn_hit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hit.Font = new System.Drawing.Font("Work Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_hit.Location = new System.Drawing.Point(3, 3);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(125, 50);
            this.btn_hit.TabIndex = 2;
            this.btn_hit.Text = "Hit";
            this.btn_hit.UseVisualStyleBackColor = false;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Enabled = false;
            this.btn_stand.FlatAppearance.BorderSize = 0;
            this.btn_stand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stand.Font = new System.Drawing.Font("Work Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stand.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_stand.Location = new System.Drawing.Point(134, 3);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(125, 50);
            this.btn_stand.TabIndex = 3;
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = false;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // btn_increaseBet
            // 
            this.btn_increaseBet.FlatAppearance.BorderSize = 0;
            this.btn_increaseBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_increaseBet.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_increaseBet.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.btn_decreaseBet.FlatAppearance.BorderSize = 0;
            this.btn_decreaseBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decreaseBet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_decreaseBet.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.pb_banker.Location = new System.Drawing.Point(12, 41);
            this.pb_banker.Name = "pb_banker";
            this.pb_banker.Size = new System.Drawing.Size(108, 144);
            this.pb_banker.TabIndex = 0;
            this.pb_banker.TabStop = false;
            // 
            // pb_player
            // 
            this.pb_player.Location = new System.Drawing.Point(12, 191);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(108, 144);
            this.pb_player.TabIndex = 1;
            this.pb_player.TabStop = false;
            // 
            // pb_player1
            // 
            this.pb_player1.Location = new System.Drawing.Point(126, 191);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.btn_menu);
            this.panel4.Controls.Add(this.lbl_xp);
            this.panel4.Controls.Add(this.lbl_balance);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 23);
            this.panel4.TabIndex = 13;
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_menu.Location = new System.Drawing.Point(785, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 23);
            this.btn_menu.TabIndex = 14;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_xp
            // 
            this.lbl_xp.AutoSize = true;
            this.lbl_xp.Font = new System.Drawing.Font("Work Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_xp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_xp.Location = new System.Drawing.Point(359, 3);
            this.lbl_xp.Name = "lbl_xp";
            this.lbl_xp.Size = new System.Drawing.Size(27, 17);
            this.lbl_xp.TabIndex = 1;
            this.lbl_xp.Text = "XP:";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Work Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_balance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_balance.Location = new System.Drawing.Point(3, 3);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(92, 17);
            this.lbl_balance.TabIndex = 0;
            this.lbl_balance.Text = "Balance: $100";
            // 
            // pnl_settings
            // 
            this.pnl_settings.Location = new System.Drawing.Point(12, 41);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(860, 508);
            this.pnl_settings.TabIndex = 14;
            this.pnl_settings.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnl_settings);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.historyTree);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_player1);
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.pb_banker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Main";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pb_banker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private TreeView historyTree;
        private Panel panel4;
        private Label lbl_balance;
        private Label lbl_xp;
        private Button btn_menu;
        private Panel pnl_settings;
    }
}