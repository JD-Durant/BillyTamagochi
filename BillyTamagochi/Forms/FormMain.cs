using BillyTamagochi.Forms;
using BillyTamagochi.Helpers;
using BillyTamagochi.Objects;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillyTamagochi
{
    public partial class Main : Form
    {
        FormActivity ActivityForm;
        FormStore StoreActivity;
        private IconButton currentBtn;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            Program.Player = new PlayerObject();
            Program.MusicPlayer = new SongHelper();
            InitTextFields();
            Program.MusicPlayer.ActivateNewSong("MUSICHome");
            ActivateHomeButtonOnStart();
            InitImageActivity();
            InitStoreActivity();
        }

        public void InitTextFields()
        {
            healthProgressBar.Value = (int)Program.Player.GetPlayerHealth();
            staminaProgressBar.Value = (int)Program.Player.GetPlayerStamina();
            happinessProgressBar.Value = (int)Program.Player.GetPlayerHappiness();
            ProgressBarHelper.SetState(healthProgressBar, 2);
            ProgressBarHelper.SetState(staminaProgressBar, 1);
            ProgressBarHelper.SetState(happinessProgressBar, 3);
            timeTag.Text = DateTime.Now.ToLocalTime().ToString();
            healthValue.Text = "[" + Program.Player.GetPlayerHealth() + "/" + Program.Player.GetMaxHealth() + "]";
            staminaValue.Text = "[" + Program.Player.GetPlayerStamina() + "/" + Program.Player.GetMaxStamina() + "]";
            happinessValue.Text = "[" + Program.Player.GetPlayerHappiness() + "/" + Program.Player.GetMaxHappiness() + "]";
            currentWalletText.Text = "[" + Program.Player.GetPlayerWallet() + "]";
        }

        public void InitImageActivity()
        {
            ActivityForm = new FormActivity
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            backGroundPanel.Controls.Add(ActivityForm);
            ActivityForm.Show();
        }


        public void InitStoreActivity()
        {
            StoreActivity = new FormStore
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            backGroundPanel.Controls.Add(ActivityForm);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonExit_MouseEnter(object sender, EventArgs e)
        {
            ButtonExit.ForeColor = Color.FromArgb(255, 105, 97);
        }

        private void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            ButtonExit.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ButtonMinimise_MouseEnter(object sender, EventArgs e)
        {
            ButtonMinimise.ForeColor = Color.FromArgb(252, 235, 159);
        }

        private void ButtonMinimise_MouseLeave(object sender, EventArgs e)
        {
            ButtonMinimise.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void GameTick(object sender, EventArgs e)
        {
            rentReminder.Visible = false;
            if (Program.Player.PlayerWalletTick())
            {
                rentReminder.Visible = true;
            }
            if (Program.Player.PlayerHealthTick())
            {
                healthProgressBar.Value = (int)Program.Player.GetPlayerHealth();
                healthValue.Text = "[" + Program.Player.GetPlayerHealth() + "/"+Program.Player.GetMaxHealth()+"]";
            }
            else
            {
                ShowAlert("Health");
            }
            if (Program.Player.PlayerStaminaTick())
            {
                staminaProgressBar.Value = (int)Program.Player.GetPlayerStamina();
                staminaValue.Text = "[" + Program.Player.GetPlayerStamina() + "/" + Program.Player.GetMaxStamina() + "]";
            }
            else
            {
                ShowAlert("Stamina");
            }
            if (Program.Player.PlayerHappinessTick())
            {
                happinessProgressBar.Value = (int)Program.Player.GetPlayerHappiness();
                happinessValue.Text = "[" + Program.Player.GetPlayerHappiness() + "/" + Program.Player.GetMaxHappiness() + "]";
            }
            else
            {
                ShowAlert("Happiness");
            }
            if (Program.Player.GetPlayerHealth() > 2 && Program.Player.GetPlayerStamina() > 2 && Program.Player.GetPlayerHappiness() > 2)
            {
                HideAlert();
            }
            currentWalletText.Text = "[" + Program.Player.GetPlayerWallet() + "]";
            timeTag.Text = DateTime.Now.ToLocalTime().ToString();
        }

        public void ActivateHomeButtonOnStart()
        {
            currentBtn = homeButton;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = Color.FromArgb(172, 126, 241);
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = Color.FromArgb(172, 126, 241);
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void ActivateButton(object senderBtn, Color color, string Activity, Bitmap ImageName, string SongName, double happinessMult, double staminaMult, double healthMult, double walletMult)
        {
            backGroundPanel.Controls.Add(ActivityForm);
            backGroundPanel.Controls.Remove(StoreActivity);
            if (senderBtn != null)
            {
                if (ActivityForm.CurrentActivity.Equals("Home"))
                {
                    WakeUpTimer(ImageName, Activity, happinessMult, staminaMult, healthMult, walletMult, SongName);
                }
                else
                {
                    if (Activity.Equals("Home"))
                    {
                        SleepTimer(ImageName, Activity, happinessMult, staminaMult, healthMult, walletMult, SongName);
                    }
                    else
                    {
                        TravelTimer(ImageName, Activity, happinessMult, staminaMult, healthMult, walletMult, SongName);
                    }
                }
                DisableButton();
                EnableButton(senderBtn, color);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void EnableButton(object senderBtn, Color color)
        {
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241), "Home", Properties.Resources.IMAGEAsleep, "MUSICHome", -1, 2, 0, 0);
        }

        private void GymButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(249, 118, 176), "Gym", Properties.Resources.GIFGym, "MUSICGym", 1.5, -2, 1.5, 0);
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(253, 138, 114), "Work", Properties.Resources.GIFWork, "MUSICWork", -0.5, -0.5, -0.5, 10);
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(95, 77, 221), "Bar", Properties.Resources.GIFBar, "MUSICBar", 1.5, 0, -0.5, -5);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(249, 88, 155), "Settings", Properties.Resources.GIFSettings, "MUSICSettings", 0, 0, 0, 0);
        }
        private void ButtonStore_Click(object sender, EventArgs e)
        {
            Program.Player.SetStatModifiers(0, 0, 0, 0);
            Program.MusicPlayer.ActivateNewSong("MUSICStore");
            backGroundPanel.Controls.Remove(ActivityForm);
            backGroundPanel.Controls.Add(StoreActivity);
            StoreActivity.Show();
        }

        public void HideAlert()
        {
            notificationPanel.Visible = false;
            notificationTitle.Visible = false;
            notificationBody.Visible = false;
        }

        public void ShowAlert(string AlertType)
        {
            notificationPanel.Visible = true;
            notificationTitle.Visible = true;
            notificationBody.Visible = true;
            switch (AlertType)
            {
                case "Health":
                    notificationBody.Text = "Billy is hurt!\nLet him rest";
                    break;
                case "Stamina":
                    notificationBody.Text = "Billy is tired!\nLet him rest";
                    break;
                case "Happiness":
                    notificationBody.Text = "Billy is unhappy!\nGo workout or drink!";
                    break;
            };
        }

        public void WakeUpTimer(Bitmap ImageName, string Activity, double happinessMult, double staminaMult, double healthMult, double walletMult, string SongName)
        {
            wake_up_timer.Enabled = true;
            wake_up_timer.Start();
            Program.Player.SetStatModifiers(0, 0, 0, 0);
            ActivityForm.ChangeActivity("Waking Up", Properties.Resources.GIFWakeUp);
            wake_up_timer.Tick += (s, e) =>
            {
                wake_up_timer.Enabled = false;
                wake_up_timer.Stop();
                ActivityForm.ChangeActivity(Activity, ImageName);
                Program.Player.SetStatModifiers(happinessMult, staminaMult, healthMult, walletMult);
                Program.MusicPlayer.ActivateNewSong(SongName);
            };
        }

        public void SleepTimer(Bitmap ImageName, string Activity, double happinessMult, double staminaMult, double healthMult, double walletMult, string SongName)
        {
            Program.MusicPlayer.ActivateNewSong(SongName);
            go_to_sleep_timer.Enabled = true;
            go_to_sleep_timer.Start();
            Program.Player.SetStatModifiers(0, 0, 0, 0);
            ActivityForm.ChangeActivity("Sleeping", Properties.Resources.GIFGoingToBed);
            go_to_sleep_timer.Tick += (s, e) =>
            {
                go_to_sleep_timer.Enabled = false;
                go_to_sleep_timer.Stop();
                ActivityForm.ChangeActivity(Activity, ImageName);
                Program.Player.SetStatModifiers(happinessMult, staminaMult, healthMult, walletMult);
            };
        }

        public void TravelTimer(Bitmap ImageName, string Activity, double happinessMult, double staminaMult, double healthMult, double walletMult, string SongName)
        {
            Program.MusicPlayer.ActivateNewSong("MUSICTravel");
            travel_timer.Enabled = true;
            travel_timer.Start();
            Program.Player.SetStatModifiers(0, 0, 0, 0);
            ActivityForm.ChangeActivity("Travelling", Properties.Resources.GIFTravel);
            travel_timer.Tick += (s, e) =>
            {
                travel_timer.Enabled = false;
                travel_timer.Stop();
                ActivityForm.ChangeActivity(Activity, ImageName);
                Program.Player.SetStatModifiers(happinessMult, staminaMult, healthMult, walletMult);
                Program.MusicPlayer.ActivateNewSong(SongName);
            };
        }
    }
}
