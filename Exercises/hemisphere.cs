// Volume 4/3 pi r3 / 2

// console.writeLine ("Enter value radius");
// console.readLine (); 
// string radius = console.readLine();

// double radius = double.Parse (radius);
// double pi = 3.1459
// double volume = (4/3 * pi * (radius * radius * radius));
// double V = volume / 2;
// console.writeLine ($" The volume is {V}");

namespace Hemispere
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Hemivolume();
        }
        public void Hemivolume()
        {
            /*  Console.WriteLine("enter the value of radius");
              double radius = double.Parse(Console.ReadLine());            
              double volume = (4 / 3 * Math.PI) * (radius * radius * radius) / 2;
              Console.WriteLine($"The volume is {volume}");*/
			  
            Console.WriteLine("enter the value of radius");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.1459;
            double volume = (4 / 3 * pi * (radius * radius * radius)) / 2;
            Console.WriteLine($"the volume is {volume}");

		}

    }
}
    
