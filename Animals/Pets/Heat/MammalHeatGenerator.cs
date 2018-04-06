using System;

namespace PetsWithInterfaces
{
    class MammalHeatGenerator : IGenerateHeat
    {
        public void GenerateHeat()
        {
            Console.WriteLine();
            Console.WriteLine(" Generating Heat...");
        }
    }
}