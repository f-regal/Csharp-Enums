using System;

namespace CsharpFundamentals
{
    class Program
    {
        public enum Planets
        {
           Mercury = 1,
           Venus = 2,
           Earth = 3,
           Mars = 4,
           Jupiter = 5,
           Saturn = 6,
           Uranus = 7,
           Neptune = 8,
           Pluto = 9

        }

        public enum PlanetRadius
        {
            Mercury = 2439,
            Venus = 6051,
            Earth = 6371,
            Mars = 3389,
            Jupiter = 69911,
            Saturn = 58232,
            Uranus = 25362,
            Neptune = 24622,
            Pluto = 1188

        }

        public static double Volume(int r)
        {
            return (4 / 3) * Math.PI * Math.Pow(r, 3);
        }

        static void Main(string[] args)
        {
            var name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Program.Volume(radius);

            Console.WriteLine("Planet: " + name);
            Console.WriteLine("Radius: " + radius + "km");
            Console.WriteLine("Volume: " + volume);
        }


    }    

}
