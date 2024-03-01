using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Facade
{
    public static class DVDPlayer
    {
        public static void TurnOn()
        {
            Console.WriteLine("DVD Player turned on !");
        }
        public static void PlayMovie()
        {
            Console.WriteLine(String.Format("Playing movie {0} !", "Interstellar"));
        }
    }
    public static class SoundSystem
    {
        public static void TurnOn()
        {
            Console.WriteLine("Sound System turned on !");
        }
        public static void AdjustSound()
        {
            Console.WriteLine("Adjusting sound...");
        }

    }
    public static class Lights
    {
        public static void TurnOn()
        {
            Console.WriteLine("Lights turned on and adjusted to given settings !");
        }
    }

}
