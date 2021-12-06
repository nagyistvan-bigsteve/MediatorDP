using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    interface IAirplane
    {
        void RequestTakeOff();

        void CompleteTakeOff();
        void RequestLading();
        void CompleteLanding();
        string Name { get; }
        bool canLand { get; }
        bool canTakeOff { get; }
    }
}
