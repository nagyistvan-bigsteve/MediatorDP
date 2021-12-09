using System;

namespace MediatorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new ControlTower();

            var plane1 = new Airplane("A2", tower);
            var plane2 = new Airplane("B4", tower);
            var plane3 = new Airplane("C9", tower);

            tower.Register(plane1);
            tower.Register(plane2);
            tower.Register(plane3);

            plane1.RequestLading();

            plane2.RequestLading();

            plane3.RequestLading();

            plane2.CompleteLanding();

            plane1.CompleteLanding();

            plane3.RequestLading();

            plane3.CompleteLanding();

            plane2.CompleteLanding();

            plane3.CompleteLanding();
        }
    }
}
