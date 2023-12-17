using System.Drawing;
using System.Windows.Forms;

namespace BillyTamagochi.Forms
{
    public partial class FormActivity : Form
    {
        public string CurrentActivity = "home";
        static PictureBox Image;
        public FormActivity()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            Image = activityImage;
        }

        public void ChangeActivity(string Activity, Bitmap ImageName)
        {
            CurrentActivity = Activity;
            Image.SizeMode = PictureBoxSizeMode.Zoom;
            Image.Image = ImageName;
            Image.Refresh();
        }
    }
}
