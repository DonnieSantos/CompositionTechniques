using System;

namespace PetsWithInterfaces
{
    class CatNoiseMaker : IMakeNoise
    {
        public void MakeNoise()
        {
            Console.WriteLine();
            Console.WriteLine(" Meow Meow Meow Meow.");
        }
    }
}