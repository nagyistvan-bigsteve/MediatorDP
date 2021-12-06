using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    interface IControlTower
    {
        void Register(IAirplane plane);
        bool CanTakeOff(IAirplane plane);
        bool CanLand(IAirplane plane);
        void HasLanded(IAirplane plane);
        void HasTakeOff(IAirplane plane);

    }
}
