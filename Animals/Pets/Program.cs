namespace PetsWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var mammalHeatGenerator = new MammalHeatGenerator();

            var dog = new Animal("Stuart", new DogNoiseMaker(), mammalHeatGenerator);
            dog.GenerateHeat();
            dog.MakeNoise();

            var cat = new Animal("Chandler", new CatNoiseMaker(), mammalHeatGenerator);
            cat.GenerateHeat();
            cat.MakeNoise();

            System.Threading.Thread.Sleep(5000);
        }
    }
}