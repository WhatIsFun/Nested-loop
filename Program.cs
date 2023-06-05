namespace Nested_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test Star pattern part 1
            //*
            //**
            //***
            //****
            //*****

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Part 2  
            //if (i == 6)
            //{
            //Console.WriteLine("Test");

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            // Part 3 
            // star line 
            //******
            for (int i = 0; i <= 6; ++i)
            {

                Console.Write('*');
            }
            Console.ReadLine();
        }

    }

}
    
