using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    class ControlTower : IControlTower
    {
        private List<IAirplane> planes = new List<IAirplane>();
        private List<IAirplane> lineLand = new List<IAirplane>();
        private List<IAirplane> lineTakeOff = new List<IAirplane>();
        public bool CanLand(IAirplane plane)
        {
        if(!lineLand.Contains(plane))
            lineLand.Add(plane);

            foreach (IAirplane p in planes)
                if (p.canLand == true)
                {
                    Console.WriteLine($"{p.Name} is landing, so {plane.Name} can't");
                    return false;
                }
            Console.WriteLine($"{plane.Name} you can land");
            return true;
        }

        public bool CanTakeOff(IAirplane plane)
        {
            if (!lineTakeOff.Contains(plane))
                lineTakeOff.Add(plane);

            foreach (IAirplane p in planes)
                if (p.canTakeOff == true)
                {
                    Console.WriteLine($"{p.Name} is taking off, {plane.Name} you can't");
                    return false;
                }
            Console.WriteLine($"{plane.Name} you can take off");
            return true;
        }

        public void HasLanded(IAirplane plane)
        {
            Console.WriteLine($"{plane.Name} has landed");
            lineLand.Remove(plane);
            if (lineLand.Any())
            {
                lineLand[0].RequestLading();
            }
        }

        public void HasTakeOff(IAirplane plane)
        {
            Console.WriteLine($"{plane.Name} has taked off");
            lineTakeOff.Remove(plane);
            if (lineTakeOff.Any())
            {
                lineTakeOff[0].RequestTakeOff();
            }
        }

        public void Register(IAirplane plane)
        {
            if (!planes.Contains(plane))
                planes.Add(plane);
        }
    }
}
