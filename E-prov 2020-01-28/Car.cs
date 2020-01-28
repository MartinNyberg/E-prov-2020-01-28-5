using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_2020_01_28
{
    class Car
    {
        public int passengers;
        public int contrabandamount;
        public bool alreadychecked;
        public int random()
        {
            Random generator = new Random();
            int random1 = generator.Next();

            return random1;
        }
        
    }
}
