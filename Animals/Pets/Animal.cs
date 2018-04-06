namespace PetsWithInterfaces
{
    class Animal : IMakeNoise, IGenerateHeat
    {
        public string Name { get; set; }
        public IMakeNoise noiseMaker { get; set; }
        public IGenerateHeat generator { get; set; }

        public Animal(string Name, IMakeNoise noiseMaker, IGenerateHeat generator)
        {
            this.Name = Name;
            this.noiseMaker = noiseMaker;
            this.generator = generator;
        }

        public void MakeNoise() { this.noiseMaker.MakeNoise(); }
        public void GenerateHeat() { this.generator.GenerateHeat(); }
    }
}