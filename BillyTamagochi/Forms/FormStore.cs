using FontAwesome.Sharp;
using System.Windows.Forms;

namespace BillyTamagochi.Forms
{
    public partial class FormStore : Form
    {
        public FormStore()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            if (Program.Player.Purchases.GetRentUpgrade())
            {
                DisableButtonAsPurchased(RentButton);
            }
            if (Program.Player.Purchases.GetHappinessUpgrade())
            {
                DisableButtonAsPurchased(HappinessUpgrade);
            }
            if (Program.Player.Purchases.GetHealthUpgrade())
            {
                DisableButtonAsPurchased(HealthButton);
            }
            if (Program.Player.Purchases.GetStaminaUpgrade())
            {
                DisableButtonAsPurchased(StaminaUpgrade);
            }
            if (Program.Player.Purchases.GetSteroidUpgrade())
            {
                DisableButtonAsPurchased(SteroidsUpgrade);
            }
            if (Program.Player.Purchases.GetEngineUpgrade())
            {
                DisableButtonAsPurchased(EnginePartsButton);
            }

        }

        private void DisableButtonAsPurchased(IconButton targetButton)
        {
            targetButton.IconChar = IconChar.CheckCircle;
            targetButton.IconColor = System.Drawing.Color.FromArgb(34, 139, 34);
            targetButton.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            targetButton.Enabled = false;
        }

        private void RentButton_Click(object sender, System.EventArgs e)
        {
            if(Program.Player.GetPlayerWallet() > 1000)
            {
                Program.Player.SetWallet(Program.Player.GetPlayerWallet() - 1000);
                Program.Player.SetRentLimit(Program.Player.GetRentLimit() * 2);
                Program.Player.Purchases.SetRentUpgrade(true);
                DisableButtonAsPurchased(RentButton);
            }
            else
            {
                NotEnoughMoneyNotification.Visible = true;
            }
        }

        private void HealthButton_Click(object sender, System.EventArgs e)
        {
            if (Program.Player.GetPlayerWallet() > 500)
            {
                Program.Player.SetWallet(Program.Player.GetPlayerWallet() - 500);
                Program.Player.SetMaxHealth(Program.Player.GetMaxHealth() * 2);
                Program.Player.Purchases.SetHealthUpgrade(true);
                DisableButtonAsPurchased(HealthButton);
            }
            else
            {
                NotEnoughMoneyNotification.Visible = true;
            }
        }

        private void StaminaUpgrade_Click(object sender, System.EventArgs e)
        {
            if (Program.Player.GetPlayerWallet() > 500)
            {
                Program.Player.SetWallet(Program.Player.GetPlayerWallet() - 500);
                Program.Player.SetMaxStamina(Program.Player.GetMaxStamina() * 2);
                Program.Player.Purchases.SetStaminaUpgrade(true);
                DisableButtonAsPurchased(StaminaUpgrade);
            }
            else
            {
                NotEnoughMoneyNotification.Visible = true;
            }
        }

        private void HappinessUpgrade_Click(object sender, System.EventArgs e)
        {
            if (Program.Player.GetPlayerWallet() > 500)
            {
                Program.Player.SetWallet(Program.Player.GetPlayerWallet() - 500);
                Program.Player.SetMaxHappiness(Program.Player.GetMaxHappiness() * 2);
                Program.Player.Purchases.SetHappinessUpgrade(true);
                DisableButtonAsPurchased(HappinessUpgrade);
            }
            else
            {
                NotEnoughMoneyNotification.Visible = true;
            }
        }

        private void SteroidsUpgrade_Click(object sender, System.EventArgs e)
        {
            if (Program.Player.GetPlayerWallet() > 500)
            {
                Program.Player.SetWallet(Program.Player.GetPlayerWallet() - 500);
                Program.Player.SetMaxHealth(Program.Player.GetMaxHealth() * 2);
                Program.Player.Purchases.SetHealthUpgrade(true);
                DisableButtonAsPurchased(SteroidsUpgrade);
            }
            else
            {
                NotEnoughMoneyNotification.Visible = true;
            }
        }

        private void EnginePartsButton_Click(object sender, System.EventArgs e)
        {
            if (Program.Player.GetPlayerWallet() > 500)
            {
                Program.Player.SetWallet(Program.Player.GetPlayerWallet() - 500);
                Program.Player.SetMaxHealth(Program.Player.GetMaxHealth() * 2);
                Program.Player.Purchases.SetHealthUpgrade(true);
                DisableButtonAsPurchased(EnginePartsButton);
            }
            else
            {
                NotEnoughMoneyNotification.Visible = true;
            }
        }
    }
}
