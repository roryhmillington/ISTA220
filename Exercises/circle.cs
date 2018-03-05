// circumference = 2 3.1459

// console.writeLine ("Enter value radius");
// console.readLine (); 
// string radius = console.readLine();

// double radius = double.Parse (radius);
// double pi = 3.1459
// double radius = (2 * pi * (radius * radius));
// double V = volume / 2;
// console.writeLine ($" The volume is {V}");

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Circumference();
        }
        public void Circumference()
        {
              Console.WriteLine("enter the value of radius");
              double radius = double.Parse(Console.ReadLine());            
              double radius = (2 * Math.PI) * (radius * radius);
              Console.WriteLine($"The circumference is");
			  
		}
			  
	}		  
            


