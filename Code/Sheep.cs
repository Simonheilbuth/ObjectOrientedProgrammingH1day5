using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingH1day5.Code
{
    internal class Sheep : Animal
    {
        public Sheep(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Baaaah");

            string pathToWavFile = @"C:\Users\Bruger\Documents\C#\ObjectOrientedProgrammingH1day5\Sounds\sheep.wav";

            SoundPlayer player = new SoundPlayer(pathToWavFile);

            player.PlaySync();
        }
    }
}
 
