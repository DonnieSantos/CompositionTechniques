using System;

namespace PetsWithInterfaces
{
    class DogNoiseMaker : IMakeNoise
    {
        public void MakeNoise()
        {
            Console.WriteLine();
            Console.WriteLine(" Woof! Woof!");
        }
    }
}