using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public class Baseship
    {
        private int counter;
        protected int speed;

        public Baseship( int i ) 
        {
            Console.WriteLine("Baseship onstructor " + i );
        }
        public virtual string Move(int disance)
        {
            counter++;
            return $"base ship convered ditance {disance}";
        }

    }








}
