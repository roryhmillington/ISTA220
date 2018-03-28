using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            horse.Eats();
            horse.Sleep();
            

            Cow cow = new Cow();
            cow.Eats();
            cow.Sleep();
            
            Pig pig = new Pig();
            pig.Eats();
            pig.Sleep();
           

            Chicken chicken = new Chicken();
            chicken.Eats();
            chicken.Sleep();

            Console.ReadLine(); //requires the console to wait before closing the program
                        
        }
    }
}
