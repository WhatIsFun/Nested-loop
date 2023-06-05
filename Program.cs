using System.Security.Cryptography;

namespace Nested_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// test Star pattern part 1
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
            Console.ReadLine();*/


            // Write a program that take 2 input to
            // Odd numbers scanner between two numbers input from user ex: 2, 6
            /*Console.WriteLine("Hello, programmer");
            Console.WriteLine("Enter your first number:");
            int fN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your last number:");
            int lN = Convert.ToInt32(Console.ReadLine());


            for (int i = fN; i <= lN; i++)
            {

                if (i % 2 ==0)
            {
            Console.WriteLine(i + "- Even number");

            }
                else
                {
                    Console.WriteLine(i + "- Odd number");
                }

            }*/

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }


    }

}
    
