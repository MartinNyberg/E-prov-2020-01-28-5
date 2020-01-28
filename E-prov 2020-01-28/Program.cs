using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_2020_01_28
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>();
            //Lista skapas

            int num = -1;
            bool success = false;
            while (success == false)
            {
                Console.Write("Hur många bilar ska spawna? ");
                string antal1 = Console.ReadLine();

                success = int.TryParse(antal1, out num);

                if (success && num < 1)
                {
                    success = false;
                }
            }
            //kollar så att man skriver ett tal över 1 anars får man gör om.


            for (int i = 0; i < num; i++)
            {
                Car Cars3 = new Car();
                Cars.Add(Cars3);
                
            }
            //Här addas bilarana till listan.


            Console.WriteLine("Du skapade " + Cars.Count() + " bilar");

            Console.ReadKey();


        }
    }
}
