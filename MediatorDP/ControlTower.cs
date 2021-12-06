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
        public bool CanLand(IAirplane plane)
        {
            foreach (IAirplane p in planes)
                if (p.canLand == true)
                {
                    Console.WriteLine($"{p.Name} is landing, so you can't");
                    return false;
                }
            Console.WriteLine($"{plane.Name} you can land");
            return true;
        }

        public bool CanTakeOff(IAirplane plane)
        {
            foreach (IAirplane p in planes)
                if (p.canTakeOff == true)
                {
                    Console.WriteLine($"{p.Name} is taking off, so you can't");
                    return false;
                }
            Console.WriteLine($"{plane.Name} you can take off");
            return true;
        }

        public void HasLanded(IAirplane plane)
        {
            Console.WriteLine($"{plane.Name} has landed");
        }

        public void HasTakeOff(IAirplane plane)
        {
            Console.WriteLine($"{plane.Name} has taked off");
        }

        public void Register(IAirplane plane)
        {
            if (!planes.Contains(plane))
                planes.Add(plane);
        }
    }
}
