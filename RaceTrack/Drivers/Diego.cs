using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Diego : Driver
    {
        public Diego(RaceCar car) : base(car)
        {
            Name = "Diego";
            SkillLevel = 9;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
