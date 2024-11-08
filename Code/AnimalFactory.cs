using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedProgrammingH1day5.Code;

internal class AnimalFactory
{
    public static Animal CreateAnimal(enmAnimals animalType, string name)
    {
        switch (animalType)
        {
            case enmAnimals.Cat:
                return new Cat(name);

            case enmAnimals.Dog:
                return new Dog(name);

            case enmAnimals.Sheep:
                return new Sheep(name);

            default:
                return new Sheep(name);



        }



    }
    public static Animal CreateAnimal(enmAnimals animalType)
    {
        switch (animalType)
        {
            case enmAnimals.Cat:
                return new Cat("Tina");

            case enmAnimals.Dog:
                return new Dog("Anne");

            case enmAnimals.Sheep:
                return new Sheep("Sus");

            default:
                return new Sheep("Sus");

        }
    }
}

