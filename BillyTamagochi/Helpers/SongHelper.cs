using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BillyTamagochi.Helpers
{
    class SongHelper
    {
        SoundPlayer musicPlayer;
        public void ActivateNewSong(string SongName)
        {
            musicPlayer = new SoundPlayer
            {
                SoundLocation = @"C:\\Program Files (x86)\\BillyGotchi\\Songs\\" + SongName + ".wav"
            };
            musicPlayer.PlayLooping();
        }
    }
}
