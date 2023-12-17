
namespace BillyTamagochi
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timeTag = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.ButtonStore = new FontAwesome.Sharp.IconButton();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.workButton = new FontAwesome.Sharp.IconButton();
            this.barButton = new FontAwesome.Sharp.IconButton();
            this.gymButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rentReminder = new System.Windows.Forms.Label();
            this.currentWalletText = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.happinessValue = new System.Windows.Forms.Label();
            this.staminaValue = new System.Windows.Forms.Label();
            this.healthValue = new System.Windows.Forms.Label();
            this.happinessProgressBar = new System.Windows.Forms.ProgressBar();
            this.staminaProgressBar = new System.Windows.Forms.ProgressBar();
            this.healthProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.Label();
            this.game_tick = new System.Windows.Forms.Timer(this.components);
            this.backGroundPanel = new System.Windows.Forms.Panel();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.notificationBody = new System.Windows.Forms.Label();
            this.notificationTitle = new System.Windows.Forms.Label();
            this.wake_up_timer = new System.Windows.Forms.Timer(this.components);
            this.go_to_sleep_timer = new System.Windows.Forms.Timer(this.components);
            this.travel_timer = new System.Windows.Forms.Timer(this.components);
            this.TopBar = new System.Windows.Forms.Panel();
            this.ButtonMinimise = new FontAwesome.Sharp.IconButton();
            this.ButtonExit = new FontAwesome.Sharp.IconButton();
            this.infoPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.backGroundPanel.SuspendLayout();
            this.notificationPanel.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(102)))), ((int)(((byte)(145)))));
            this.infoPanel.Controls.Add(this.panel4);
            this.infoPanel.Controls.Add(this.buttonPanel);
            this.infoPanel.Controls.Add(this.panel2);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(186, 433);
            this.infoPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel4.Controls.Add(this.timeTag);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 37);
            this.panel4.TabIndex = 2;
            // 
            // timeTag
            // 
            this.timeTag.AutoSize = true;
            this.timeTag.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTag.ForeColor = System.Drawing.SystemColors.Control;
            this.timeTag.Location = new System.Drawing.Point(1, 8);
            this.timeTag.Name = "timeTag";
            this.timeTag.Size = new System.Drawing.Size(48, 18);
            this.timeTag.TabIndex = 4;
            this.timeTag.Text = "[time]";
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(144)))), ((int)(((byte)(192)))));
            this.buttonPanel.Controls.Add(this.ButtonStore);
            this.buttonPanel.Controls.Add(this.settingsButton);
            this.buttonPanel.Controls.Add(this.workButton);
            this.buttonPanel.Controls.Add(this.barButton);
            this.buttonPanel.Controls.Add(this.gymButton);
            this.buttonPanel.Controls.Add(this.homeButton);
            this.buttonPanel.Location = new System.Drawing.Point(4, 202);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(179, 228);
            this.buttonPanel.TabIndex = 1;
            // 
            // ButtonStore
            // 
            this.ButtonStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ButtonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStore.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonStore.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.ButtonStore.IconColor = System.Drawing.Color.White;
            this.ButtonStore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonStore.IconSize = 32;
            this.ButtonStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonStore.Location = new System.Drawing.Point(0, 152);
            this.ButtonStore.Name = "ButtonStore";
            this.ButtonStore.Size = new System.Drawing.Size(179, 39);
            this.ButtonStore.TabIndex = 5;
            this.ButtonStore.Text = "Store";
            this.ButtonStore.UseVisualStyleBackColor = false;
            this.ButtonStore.Click += new System.EventHandler(this.ButtonStore_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 32;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 189);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(179, 39);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // workButton
            // 
            this.workButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.workButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workButton.ForeColor = System.Drawing.SystemColors.Control;
            this.workButton.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.workButton.IconColor = System.Drawing.Color.White;
            this.workButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.workButton.IconSize = 32;
            this.workButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.workButton.Location = new System.Drawing.Point(0, 76);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(179, 39);
            this.workButton.TabIndex = 3;
            this.workButton.Text = "Work";
            this.workButton.UseVisualStyleBackColor = false;
            this.workButton.Click += new System.EventHandler(this.WorkButton_Click);
            // 
            // barButton
            // 
            this.barButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.barButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barButton.ForeColor = System.Drawing.SystemColors.Control;
            this.barButton.IconChar = FontAwesome.Sharp.IconChar.BeerMugEmpty;
            this.barButton.IconColor = System.Drawing.Color.White;
            this.barButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.barButton.IconSize = 32;
            this.barButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.barButton.Location = new System.Drawing.Point(0, 114);
            this.barButton.Name = "barButton";
            this.barButton.Size = new System.Drawing.Size(179, 39);
            this.barButton.TabIndex = 2;
            this.barButton.Text = "Bar";
            this.barButton.UseVisualStyleBackColor = false;
            this.barButton.Click += new System.EventHandler(this.BarButton_Click);
            // 
            // gymButton
            // 
            this.gymButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.gymButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gymButton.ForeColor = System.Drawing.SystemColors.Control;
            this.gymButton.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.gymButton.IconColor = System.Drawing.Color.White;
            this.gymButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gymButton.IconSize = 32;
            this.gymButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gymButton.Location = new System.Drawing.Point(0, 38);
            this.gymButton.Name = "gymButton";
            this.gymButton.Size = new System.Drawing.Size(179, 39);
            this.gymButton.TabIndex = 1;
            this.gymButton.Text = "Gym";
            this.gymButton.UseVisualStyleBackColor = false;
            this.gymButton.Click += new System.EventHandler(this.GymButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.House;
            this.homeButton.IconColor = System.Drawing.Color.White;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 32;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(179, 39);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel2.Controls.Add(this.rentReminder);
            this.panel2.Controls.Add(this.currentWalletText);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.happinessValue);
            this.panel2.Controls.Add(this.staminaValue);
            this.panel2.Controls.Add(this.healthValue);
            this.panel2.Controls.Add(this.happinessProgressBar);
            this.panel2.Controls.Add(this.staminaProgressBar);
            this.panel2.Controls.Add(this.healthProgressBar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Statistics);
            this.panel2.Location = new System.Drawing.Point(3, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 149);
            this.panel2.TabIndex = 0;
            // 
            // rentReminder
            // 
            this.rentReminder.AutoSize = true;
            this.rentReminder.ForeColor = System.Drawing.Color.Red;
            this.rentReminder.Location = new System.Drawing.Point(122, 126);
            this.rentReminder.Name = "rentReminder";
            this.rentReminder.Size = new System.Drawing.Size(54, 13);
            this.rentReminder.TabIndex = 12;
            this.rentReminder.Text = "-100 Rent";
            this.rentReminder.Visible = false;
            // 
            // currentWalletText
            // 
            this.currentWalletText.AutoSize = true;
            this.currentWalletText.ForeColor = System.Drawing.SystemColors.Control;
            this.currentWalletText.Location = new System.Drawing.Point(45, 126);
            this.currentWalletText.Name = "currentWalletText";
            this.currentWalletText.Size = new System.Drawing.Size(76, 13);
            this.currentWalletText.TabIndex = 11;
            this.currentWalletText.Text = "[currentWallet]";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 117);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // happinessValue
            // 
            this.happinessValue.AutoSize = true;
            this.happinessValue.ForeColor = System.Drawing.SystemColors.Control;
            this.happinessValue.Location = new System.Drawing.Point(123, 84);
            this.happinessValue.Name = "happinessValue";
            this.happinessValue.Size = new System.Drawing.Size(54, 13);
            this.happinessValue.TabIndex = 9;
            this.happinessValue.Text = "[100/100]";
            this.happinessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // staminaValue
            // 
            this.staminaValue.AutoSize = true;
            this.staminaValue.ForeColor = System.Drawing.SystemColors.Control;
            this.staminaValue.Location = new System.Drawing.Point(123, 55);
            this.staminaValue.Name = "staminaValue";
            this.staminaValue.Size = new System.Drawing.Size(54, 13);
            this.staminaValue.TabIndex = 8;
            this.staminaValue.Text = "[100/100]";
            this.staminaValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // healthValue
            // 
            this.healthValue.AutoSize = true;
            this.healthValue.ForeColor = System.Drawing.SystemColors.Control;
            this.healthValue.Location = new System.Drawing.Point(123, 26);
            this.healthValue.Name = "healthValue";
            this.healthValue.Size = new System.Drawing.Size(54, 13);
            this.healthValue.TabIndex = 7;
            this.healthValue.Text = "[100/100]";
            this.healthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // happinessProgressBar
            // 
            this.happinessProgressBar.Location = new System.Drawing.Point(6, 100);
            this.happinessProgressBar.MarqueeAnimationSpeed = 0;
            this.happinessProgressBar.Name = "happinessProgressBar";
            this.happinessProgressBar.Size = new System.Drawing.Size(170, 10);
            this.happinessProgressBar.TabIndex = 6;
            // 
            // staminaProgressBar
            // 
            this.staminaProgressBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.staminaProgressBar.Location = new System.Drawing.Point(7, 71);
            this.staminaProgressBar.MarqueeAnimationSpeed = 0;
            this.staminaProgressBar.Name = "staminaProgressBar";
            this.staminaProgressBar.Size = new System.Drawing.Size(170, 10);
            this.staminaProgressBar.TabIndex = 5;
            // 
            // healthProgressBar
            // 
            this.healthProgressBar.ForeColor = System.Drawing.Color.Red;
            this.healthProgressBar.Location = new System.Drawing.Point(7, 42);
            this.healthProgressBar.MarqueeAnimationSpeed = 0;
            this.healthProgressBar.Name = "healthProgressBar";
            this.healthProgressBar.Size = new System.Drawing.Size(170, 10);
            this.healthProgressBar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Happiness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stamina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health";
            // 
            // Statistics
            // 
            this.Statistics.AutoSize = true;
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.ForeColor = System.Drawing.SystemColors.Control;
            this.Statistics.Location = new System.Drawing.Point(4, 4);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(59, 13);
            this.Statistics.TabIndex = 0;
            this.Statistics.Text = "Statistics";
            // 
            // game_tick
            // 
            this.game_tick.Enabled = true;
            this.game_tick.Interval = 1000;
            this.game_tick.Tick += new System.EventHandler(this.GameTick);
            // 
            // backGroundPanel
            // 
            this.backGroundPanel.BackColor = System.Drawing.Color.Black;
            this.backGroundPanel.Controls.Add(this.notificationPanel);
            this.backGroundPanel.Location = new System.Drawing.Point(186, 33);
            this.backGroundPanel.Name = "backGroundPanel";
            this.backGroundPanel.Size = new System.Drawing.Size(505, 400);
            this.backGroundPanel.TabIndex = 2;
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(187)))), ((int)(((byte)(221)))));
            this.notificationPanel.Controls.Add(this.notificationBody);
            this.notificationPanel.Controls.Add(this.notificationTitle);
            this.notificationPanel.Location = new System.Drawing.Point(343, 341);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(131, 48);
            this.notificationPanel.TabIndex = 5;
            this.notificationPanel.Visible = false;
            // 
            // notificationBody
            // 
            this.notificationBody.AutoSize = true;
            this.notificationBody.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationBody.ForeColor = System.Drawing.SystemColors.Desktop;
            this.notificationBody.Location = new System.Drawing.Point(3, 18);
            this.notificationBody.Name = "notificationBody";
            this.notificationBody.Size = new System.Drawing.Size(34, 14);
            this.notificationBody.TabIndex = 6;
            this.notificationBody.Text = "Alert!";
            this.notificationBody.Visible = false;
            // 
            // notificationTitle
            // 
            this.notificationTitle.AutoSize = true;
            this.notificationTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.notificationTitle.Location = new System.Drawing.Point(42, 0);
            this.notificationTitle.Name = "notificationTitle";
            this.notificationTitle.Size = new System.Drawing.Size(46, 18);
            this.notificationTitle.TabIndex = 5;
            this.notificationTitle.Text = "Alert!";
            this.notificationTitle.Visible = false;
            // 
            // wake_up_timer
            // 
            this.wake_up_timer.Interval = 4000;
            // 
            // go_to_sleep_timer
            // 
            this.go_to_sleep_timer.Interval = 5500;
            // 
            // travel_timer
            // 
            this.travel_timer.Interval = 13000;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.TopBar.Controls.Add(this.ButtonMinimise);
            this.TopBar.Controls.Add(this.ButtonExit);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(186, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(505, 30);
            this.TopBar.TabIndex = 3;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // ButtonMinimise
            // 
            this.ButtonMinimise.FlatAppearance.BorderSize = 0;
            this.ButtonMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimise.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinimise.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimise.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonMinimise.IconColor = System.Drawing.Color.Black;
            this.ButtonMinimise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonMinimise.Location = new System.Drawing.Point(457, 4);
            this.ButtonMinimise.Name = "ButtonMinimise";
            this.ButtonMinimise.Size = new System.Drawing.Size(26, 23);
            this.ButtonMinimise.TabIndex = 1;
            this.ButtonMinimise.Text = "O";
            this.ButtonMinimise.UseVisualStyleBackColor = true;
            this.ButtonMinimise.Click += new System.EventHandler(this.ButtonMinimise_Click);
            this.ButtonMinimise.MouseEnter += new System.EventHandler(this.ButtonMinimise_MouseEnter);
            this.ButtonMinimise.MouseLeave += new System.EventHandler(this.ButtonMinimise_MouseLeave);
            // 
            // ButtonExit
            // 
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonExit.IconColor = System.Drawing.Color.Black;
            this.ButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonExit.Location = new System.Drawing.Point(479, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(26, 23);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "O";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.ButtonExit.MouseEnter += new System.EventHandler(this.ButtonExit_MouseEnter);
            this.ButtonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(691, 433);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.backGroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Home";
            this.infoPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.backGroundPanel.ResumeLayout(false);
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Statistics;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer game_tick;
        private System.Windows.Forms.Label timeTag;
        private System.Windows.Forms.ProgressBar happinessProgressBar;
        private System.Windows.Forms.ProgressBar staminaProgressBar;
        private System.Windows.Forms.ProgressBar healthProgressBar;
        private FontAwesome.Sharp.IconButton settingsButton;
        private FontAwesome.Sharp.IconButton workButton;
        private FontAwesome.Sharp.IconButton barButton;
        private FontAwesome.Sharp.IconButton gymButton;
        internal FontAwesome.Sharp.IconButton homeButton;
        private System.Windows.Forms.Panel backGroundPanel;
        private System.Windows.Forms.Timer wake_up_timer;
        private System.Windows.Forms.Label happinessValue;
        private System.Windows.Forms.Label staminaValue;
        private System.Windows.Forms.Label healthValue;
        private System.Windows.Forms.Label currentWalletText;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label rentReminder;
        private System.Windows.Forms.Timer go_to_sleep_timer;
        private System.Windows.Forms.Timer travel_timer;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label notificationBody;
        private System.Windows.Forms.Label notificationTitle;
        private System.Windows.Forms.Panel TopBar;
        private FontAwesome.Sharp.IconButton ButtonMinimise;
        private FontAwesome.Sharp.IconButton ButtonExit;
        private FontAwesome.Sharp.IconButton ButtonStore;
    }
}

