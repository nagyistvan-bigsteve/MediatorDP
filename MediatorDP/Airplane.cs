using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    class Airplane : IAirplane
    {
        public string Name { get; set; } 
        private ControlTower tower { get; set; }
        public bool canTakeOff { get; set; }
        public bool canLand { get; set; }

        public Airplane(string name, ControlTower tower)
        {
            this.Name = name;
            this.tower = tower;
            canTakeOff = false;
            canLand = false;
        }
        public void CompleteLanding()
        {
            if (canLand)
                {
                tower.HasLanded(this);
                canLand = false;
            }
            else
                Console.WriteLine($"{Name} you can't land");
        }

        public void CompleteTakeOff()
        {
            if (canTakeOff)
            {
                tower.HasTakeOff(this);
                canTakeOff = false;
            }
            else
                Console.WriteLine($"{Name} you can't take off");
        }

        public void RequestLading()
        {
            canLand = tower.CanLand(this);
        }

        public void RequestTakeOff()
        {
            canTakeOff = tower.CanTakeOff(this);
        }
    }
}
