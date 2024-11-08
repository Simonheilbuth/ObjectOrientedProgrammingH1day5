using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingH1day5.Code;

internal class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Vow");

        string pathToWavFile = @"C:\Users\Bruger\Documents\C#\ObjectOrientedProgrammingH1day5\Sounds\dog.wav";

        SoundPlayer player = new SoundPlayer(pathToWavFile);

        player.PlaySync();
    }
}

