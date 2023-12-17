
namespace BillyTamagochi.Forms
{
    partial class FormStore
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
            this.NotEnoughMoneyNotification = new System.Windows.Forms.Label();
            this.RentButton = new FontAwesome.Sharp.IconButton();
            this.EnginePartsButton = new FontAwesome.Sharp.IconButton();
            this.HealthButton = new FontAwesome.Sharp.IconButton();
            this.StaminaUpgrade = new FontAwesome.Sharp.IconButton();
            this.HappinessUpgrade = new FontAwesome.Sharp.IconButton();
            this.SteroidsUpgrade = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // NotEnoughMoneyNotification
            // 
            this.NotEnoughMoneyNotification.AutoSize = true;
            this.NotEnoughMoneyNotification.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotEnoughMoneyNotification.ForeColor = System.Drawing.Color.Red;
            this.NotEnoughMoneyNotification.Location = new System.Drawing.Point(136, 8);
            this.NotEnoughMoneyNotification.Name = "NotEnoughMoneyNotification";
            this.NotEnoughMoneyNotification.Size = new System.Drawing.Size(201, 14);
            this.NotEnoughMoneyNotification.TabIndex = 1;
            this.NotEnoughMoneyNotification.Text = "Not Enough Money for that Upgrade!";
            this.NotEnoughMoneyNotification.Visible = false;
            // 
            // RentButton
            // 
            this.RentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.RentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentButton.ForeColor = System.Drawing.Color.White;
            this.RentButton.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.RentButton.IconColor = System.Drawing.Color.White;
            this.RentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RentButton.IconSize = 36;
            this.RentButton.Location = new System.Drawing.Point(12, 25);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(189, 54);
            this.RentButton.TabIndex = 0;
            this.RentButton.Text = "Rent Upgrade\r\n(Doubles Rent Timer)\r\n£1000";
            this.RentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RentButton.UseVisualStyleBackColor = false;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // EnginePartsButton
            // 
            this.EnginePartsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.EnginePartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnginePartsButton.ForeColor = System.Drawing.Color.White;
            this.EnginePartsButton.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.EnginePartsButton.IconColor = System.Drawing.Color.White;
            this.EnginePartsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EnginePartsButton.IconSize = 36;
            this.EnginePartsButton.Location = new System.Drawing.Point(255, 25);
            this.EnginePartsButton.Name = "EnginePartsButton";
            this.EnginePartsButton.Size = new System.Drawing.Size(189, 54);
            this.EnginePartsButton.TabIndex = 2;
            this.EnginePartsButton.Text = "Engine Upgrade\r\n(Skip Travelling)\r\n£1000";
            this.EnginePartsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EnginePartsButton.UseVisualStyleBackColor = false;
            this.EnginePartsButton.Click += new System.EventHandler(this.EnginePartsButton_Click);
            // 
            // HealthButton
            // 
            this.HealthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.HealthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealthButton.ForeColor = System.Drawing.Color.White;
            this.HealthButton.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.HealthButton.IconColor = System.Drawing.Color.White;
            this.HealthButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HealthButton.IconSize = 36;
            this.HealthButton.Location = new System.Drawing.Point(12, 94);
            this.HealthButton.Name = "HealthButton";
            this.HealthButton.Size = new System.Drawing.Size(189, 54);
            this.HealthButton.TabIndex = 3;
            this.HealthButton.Text = "Upgrade Health\r\n(Doubles Health)\r\n£500";
            this.HealthButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HealthButton.UseVisualStyleBackColor = false;
            this.HealthButton.Click += new System.EventHandler(this.HealthButton_Click);
            // 
            // StaminaUpgrade
            // 
            this.StaminaUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.StaminaUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaminaUpgrade.ForeColor = System.Drawing.Color.White;
            this.StaminaUpgrade.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.StaminaUpgrade.IconColor = System.Drawing.Color.White;
            this.StaminaUpgrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StaminaUpgrade.IconSize = 36;
            this.StaminaUpgrade.Location = new System.Drawing.Point(12, 163);
            this.StaminaUpgrade.Name = "StaminaUpgrade";
            this.StaminaUpgrade.Size = new System.Drawing.Size(189, 54);
            this.StaminaUpgrade.TabIndex = 4;
            this.StaminaUpgrade.Text = "Upgrade Stamina\r\n(Doubles Stamina)\r\n£500";
            this.StaminaUpgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StaminaUpgrade.UseVisualStyleBackColor = false;
            this.StaminaUpgrade.Click += new System.EventHandler(this.StaminaUpgrade_Click);
            // 
            // HappinessUpgrade
            // 
            this.HappinessUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.HappinessUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HappinessUpgrade.ForeColor = System.Drawing.Color.White;
            this.HappinessUpgrade.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.HappinessUpgrade.IconColor = System.Drawing.Color.White;
            this.HappinessUpgrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HappinessUpgrade.IconSize = 36;
            this.HappinessUpgrade.Location = new System.Drawing.Point(12, 232);
            this.HappinessUpgrade.Name = "HappinessUpgrade";
            this.HappinessUpgrade.Size = new System.Drawing.Size(189, 54);
            this.HappinessUpgrade.TabIndex = 5;
            this.HappinessUpgrade.Text = "Upgrade Happiness\r\n(Doubles Happiness)\r\n£500";
            this.HappinessUpgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HappinessUpgrade.UseVisualStyleBackColor = false;
            this.HappinessUpgrade.Click += new System.EventHandler(this.HappinessUpgrade_Click);
            // 
            // SteroidsUpgrade
            // 
            this.SteroidsUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.SteroidsUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteroidsUpgrade.ForeColor = System.Drawing.Color.White;
            this.SteroidsUpgrade.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.SteroidsUpgrade.IconColor = System.Drawing.Color.White;
            this.SteroidsUpgrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SteroidsUpgrade.IconSize = 36;
            this.SteroidsUpgrade.Location = new System.Drawing.Point(255, 94);
            this.SteroidsUpgrade.Name = "SteroidsUpgrade";
            this.SteroidsUpgrade.Size = new System.Drawing.Size(189, 54);
            this.SteroidsUpgrade.TabIndex = 6;
            this.SteroidsUpgrade.Text = "Steroids\r\n(Increases Muscle Building)\r\n£250";
            this.SteroidsUpgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SteroidsUpgrade.UseVisualStyleBackColor = false;
            this.SteroidsUpgrade.Click += new System.EventHandler(this.SteroidsUpgrade_Click);
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.SteroidsUpgrade);
            this.Controls.Add(this.HappinessUpgrade);
            this.Controls.Add(this.StaminaUpgrade);
            this.Controls.Add(this.HealthButton);
            this.Controls.Add(this.EnginePartsButton);
            this.Controls.Add(this.NotEnoughMoneyNotification);
            this.Controls.Add(this.RentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStore";
            this.Text = "FormStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton RentButton;
        private System.Windows.Forms.Label NotEnoughMoneyNotification;
        private FontAwesome.Sharp.IconButton EnginePartsButton;
        private FontAwesome.Sharp.IconButton HealthButton;
        private FontAwesome.Sharp.IconButton StaminaUpgrade;
        private FontAwesome.Sharp.IconButton HappinessUpgrade;
        private FontAwesome.Sharp.IconButton SteroidsUpgrade;
    }
}