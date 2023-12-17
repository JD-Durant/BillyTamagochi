using BillyTamagochi.Helpers;
using BillyTamagochi.Objects;
using System;
using System.Windows.Forms;

namespace BillyTamagochi
{
    static class Program
    {
        public static PlayerObject Player;
        public static SongHelper MusicPlayer;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
