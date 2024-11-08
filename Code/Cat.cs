using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ObjectOrientedProgrammingH1day5.Code;

internal class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meau");

        string pathToWavFile= @"C:\Users\Bruger\Documents\C#\ObjectOrientedProgrammingH1day5\Sounds\cat.wav";

        SoundPlayer player = new SoundPlayer(pathToWavFile);

       player.PlaySync();



    }
}

