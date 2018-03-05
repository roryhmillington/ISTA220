 static void Main(string[] args)
        {
            Console.WriteLine("Sum ten integers. ");
            int sum = 0;
            int count = 0;
            get_sums();
            Console.WriteLine($"The sum is {sum}");


            void get_sums()
            {
                Console.WriteLine( $"Enter interger {count}:");
                sum += int.Parse(Console.ReadLine());
                if (count < 10)
                get_sums();
                else
                    return;
            }
			
		}
		