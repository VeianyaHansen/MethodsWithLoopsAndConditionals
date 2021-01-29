using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PrintThousand:");
            PrintThousand();
            Console.WriteLine();

            Console.WriteLine("Threes:");
            Threes();
            Console.WriteLine();

            Console.WriteLine("IsEqual:");
            Console.WriteLine(IsEqual(2, 8));
            Console.WriteLine();

            Console.WriteLine("EvenOrOdd:");
            EvenOrOdd(7);
            Console.WriteLine();

            Console.WriteLine("PositiveOrNegative:");
            PositiveOrNegative(-1);
            Console.WriteLine();

            Console.WriteLine("IsEligible:");
            IsEligible();
            Console.WriteLine();

            Console.WriteLine("CheckInteger:");
            CheckInteger();
            Console.WriteLine();

            Console.WriteLine("MultiplicationTable:");
            MultiplicationTable();
            Console.WriteLine();
        }
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Threes()
        {
            for (int k = 3; k <= 999; k+=3)
            {
                Console.WriteLine(k);
            }
        }

        public static bool IsEqual(int a, int b)
        {
            var check = (a == b) ? true : false;

            return check;
        }

        public static void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void PositiveOrNegative(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }        
        }

        public static void IsEligible()
        {
            Console.WriteLine("How old are you?:");
            var input = int.Parse(Console.ReadLine());
            if (input >= 18)
            {
                Console.WriteLine($"{input} is old enough to vote.");
            }
            else
            {
                Console.WriteLine($"{input} is not old enough to vote.");
            }
            
        }    
        
        public static void CheckInteger()
        {
            Console.WriteLine("Enter a number:");
            var input = int.Parse(Console.ReadLine());

            if (input >= -10 && input <= 10)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number between 1 and 12:");
            var input = int.Parse(Console.ReadLine());

            if (input >= 1 && input < 13)
            {
                var two = input * 2;
                var three = input * 3;
                var four = input * 4;
                var five = input * 5;
                var six = input * 6;
                var seven = input * 7;
                var eight = input * 8;
                var nine = input * 9;
                var ten = input * 10;
                var eleven = input * 11;
                var twelve = input * 12;

                Console.WriteLine($"{input}, {two}, {three}, {four}, {five}, {six}, {seven}, {eight}, {nine}, {ten}, {eleven}, {twelve}");
            }
            else
            {
                Console.WriteLine("That was not a valid number.");
            }
        }
    }
}
