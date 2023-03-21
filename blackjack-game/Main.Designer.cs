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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_github = new System.Windows.Forms.Button();
            this.btn_website = new System.Windows.Forms.Button();
            this.gb_resources = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_resources = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.gb_howtoplay = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_gamespeed = new System.Windows.Forms.GroupBox();
            this.rb_speed2500 = new System.Windows.Forms.RadioButton();
            this.rb_speed1000 = new System.Windows.Forms.RadioButton();
            this.rb_speed500 = new System.Windows.Forms.RadioButton();
            this.rb_speed250 = new System.Windows.Forms.RadioButton();
            this.rb_speed100 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_settings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_resources.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_howtoplay.SuspendLayout();
            this.gb_gamespeed.SuspendLayout();
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
            this.btn_increaseBet.Location = new System.Drawing.Point(329, 3);
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
            this.btn_decreaseBet.Location = new System.Drawing.Point(329, 28);
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
            this.lbl_totalBet.Location = new System.Drawing.Point(385, 3);
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
            this.lbl_betAmount.Location = new System.Drawing.Point(385, 18);
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
            this.lbl_xp.Location = new System.Drawing.Point(219, 3);
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
            this.pnl_settings.Controls.Add(this.groupBox2);
            this.pnl_settings.Controls.Add(this.gb_resources);
            this.pnl_settings.Controls.Add(this.groupBox1);
            this.pnl_settings.Controls.Add(this.gb_howtoplay);
            this.pnl_settings.Controls.Add(this.gb_gamespeed);
            this.pnl_settings.Location = new System.Drawing.Point(12, 41);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(860, 508);
            this.pnl_settings.TabIndex = 14;
            this.pnl_settings.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_github);
            this.groupBox2.Controls.Add(this.btn_website);
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
            this.btn_github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_github.FlatAppearance.BorderSize = 0;
            this.btn_github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_github.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_github.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_github.Location = new System.Drawing.Point(7, 51);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(113, 23);
            this.btn_github.TabIndex = 16;
            this.btn_github.Text = "My Github";
            this.btn_github.UseVisualStyleBackColor = false;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // btn_website
            // 
            this.btn_website.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_website.FlatAppearance.BorderSize = 0;
            this.btn_website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_website.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_website.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_website.Location = new System.Drawing.Point(7, 22);
            this.btn_website.Name = "btn_website";
            this.btn_website.Size = new System.Drawing.Size(113, 23);
            this.btn_website.TabIndex = 15;
            this.btn_website.Text = "My website";
            this.btn_website.UseVisualStyleBackColor = false;
            this.btn_website.Click += new System.EventHandler(this.btn_website_Click);
            // 
            // gb_resources
            // 
            this.gb_resources.Controls.Add(this.textBox2);
            this.gb_resources.Controls.Add(this.btn_resources);
            this.gb_resources.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_resources.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_resources.Location = new System.Drawing.Point(132, 205);
            this.gb_resources.Name = "gb_resources";
            this.gb_resources.Size = new System.Drawing.Size(247, 155);
            this.gb_resources.TabIndex = 16;
            this.gb_resources.TabStop = false;
            this.gb_resources.Text = "Resources";
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
            this.btn_resources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_resources.FlatAppearance.BorderSize = 0;
            this.btn_resources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resources.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_resources.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_resources.Location = new System.Drawing.Point(128, 126);
            this.btn_resources.Name = "btn_resources";
            this.btn_resources.Size = new System.Drawing.Size(113, 23);
            this.btn_resources.TabIndex = 15;
            this.btn_resources.Text = "Open folder";
            this.btn_resources.UseVisualStyleBackColor = false;
            this.btn_resources.Click += new System.EventHandler(this.btn_resources_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
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
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Work Sans Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_reset.Location = new System.Drawing.Point(6, 22);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 23);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset data";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // gb_howtoplay
            // 
            this.gb_howtoplay.Controls.Add(this.textBox1);
            this.gb_howtoplay.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_howtoplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_howtoplay.Location = new System.Drawing.Point(3, 3);
            this.gb_howtoplay.Name = "gb_howtoplay";
            this.gb_howtoplay.Size = new System.Drawing.Size(854, 196);
            this.gb_howtoplay.TabIndex = 5;
            this.gb_howtoplay.TabStop = false;
            this.gb_howtoplay.Text = "How to play";
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
            this.gb_gamespeed.Controls.Add(this.rb_speed2500);
            this.gb_gamespeed.Controls.Add(this.rb_speed1000);
            this.gb_gamespeed.Controls.Add(this.rb_speed500);
            this.gb_gamespeed.Controls.Add(this.rb_speed250);
            this.gb_gamespeed.Controls.Add(this.rb_speed100);
            this.gb_gamespeed.Font = new System.Drawing.Font("Work Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_gamespeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_gamespeed.Location = new System.Drawing.Point(3, 205);
            this.gb_gamespeed.Name = "gb_gamespeed";
            this.gb_gamespeed.Size = new System.Drawing.Size(125, 155);
            this.gb_gamespeed.TabIndex = 0;
            this.gb_gamespeed.TabStop = false;
            this.gb_gamespeed.Text = "Game speed";
            // 
            // rb_speed2500
            // 
            this.rb_speed2500.AutoSize = true;
            this.rb_speed2500.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_speed2500.Location = new System.Drawing.Point(6, 130);
            this.rb_speed2500.Name = "rb_speed2500";
            this.rb_speed2500.Size = new System.Drawing.Size(117, 21);
            this.rb_speed2500.TabIndex = 4;
            this.rb_speed2500.Text = "0.2x (Very slow)";
            this.rb_speed2500.UseVisualStyleBackColor = true;
            this.rb_speed2500.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed1000
            // 
            this.rb_speed1000.AutoSize = true;
            this.rb_speed1000.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_speed1000.Location = new System.Drawing.Point(6, 103);
            this.rb_speed1000.Name = "rb_speed1000";
            this.rb_speed1000.Size = new System.Drawing.Size(90, 21);
            this.rb_speed1000.TabIndex = 3;
            this.rb_speed1000.Text = "0.5x (Slow)";
            this.rb_speed1000.UseVisualStyleBackColor = true;
            this.rb_speed1000.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed500
            // 
            this.rb_speed500.AutoSize = true;
            this.rb_speed500.Checked = true;
            this.rb_speed500.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_speed500.Location = new System.Drawing.Point(6, 76);
            this.rb_speed500.Name = "rb_speed500";
            this.rb_speed500.Size = new System.Drawing.Size(102, 21);
            this.rb_speed500.TabIndex = 2;
            this.rb_speed500.TabStop = true;
            this.rb_speed500.Text = "1.0x (Normal)";
            this.rb_speed500.UseVisualStyleBackColor = true;
            this.rb_speed500.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed250
            // 
            this.rb_speed250.AutoSize = true;
            this.rb_speed250.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_speed250.Location = new System.Drawing.Point(6, 49);
            this.rb_speed250.Name = "rb_speed250";
            this.rb_speed250.Size = new System.Drawing.Size(85, 21);
            this.rb_speed250.TabIndex = 1;
            this.rb_speed250.Text = "2.0x (Fast)";
            this.rb_speed250.UseVisualStyleBackColor = true;
            this.rb_speed250.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_speed100
            // 
            this.rb_speed100.AutoSize = true;
            this.rb_speed100.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_speed100.Location = new System.Drawing.Point(6, 22);
            this.rb_speed100.Name = "rb_speed100";
            this.rb_speed100.Size = new System.Drawing.Size(113, 21);
            this.rb_speed100.TabIndex = 0;
            this.rb_speed100.Text = "5.0x (Very fast)";
            this.rb_speed100.UseVisualStyleBackColor = true;
            this.rb_speed100.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
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
            this.pnl_settings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gb_resources.ResumeLayout(false);
            this.gb_resources.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gb_howtoplay.ResumeLayout(false);
            this.gb_howtoplay.PerformLayout();
            this.gb_gamespeed.ResumeLayout(false);
            this.gb_gamespeed.PerformLayout();
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
        private GroupBox gb_gamespeed;
        private RadioButton rb_speed100;
        private RadioButton rb_speed500;
        private RadioButton rb_speed250;
        private RadioButton rb_speed2500;
        private RadioButton rb_speed1000;
        private GroupBox gb_howtoplay;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btn_reset;
        private GroupBox gb_resources;
        private TextBox textBox2;
        private Button btn_resources;
        private GroupBox groupBox2;
        private Button btn_website;
        private Button btn_github;
    }
}