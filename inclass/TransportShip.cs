using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public class TransportShip : Baseship
    {
        public TransportShip(int i) : base(5)
        {
            Console.WriteLine("TransportShip onstructor");
        }

        public override string Move(int distance)
        {
            return $"TransportShip convered ditance: {distance}";
        }

        public override string ToString()
        {
            return $"TransportShip: Hello from TOSTRING";
        }

    }
}
