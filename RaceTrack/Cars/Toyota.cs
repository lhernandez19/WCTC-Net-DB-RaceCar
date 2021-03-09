using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Toyota : RaceCar
    { 
        public Toyota()
        {
            Name = "Toyota";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} roars to life!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is having a hard time stopping!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} stop the engine");
        }


    }
}
