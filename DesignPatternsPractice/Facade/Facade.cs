using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Facade
{
    public static class FacadeClass
    {
        public static void StartMovieNight()
        {
            DVDPlayer.TurnOn();
            SoundSystem.TurnOn();
            Lights.TurnOn();
            SoundSystem.AdjustSound();
            DVDPlayer.PlayMovie();
        }
    }
}
