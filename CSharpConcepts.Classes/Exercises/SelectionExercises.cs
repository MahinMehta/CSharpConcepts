using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class SelectionExercises
    {
        // Q1: FizzBuzz
        // Return Fizz if divisible by 3. Buzz if divisible by 5. FizzBuzz if divisible by both.
        // If divisible by neither return the number itself (as a string)
        public static void FizzBuzz(int num)
        {
            num = Convert.ToInt16(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.Write("Fizz");
            }
            if (num % 5 == 0)
            {
                Console.Write("Buzz");
            }
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }

        // Q2: Vowel or Consonant
        // Using a switch statement write a function which returns true if the input is a vowel and
        // false if it is a consonant
        public static void VowelOrConsonant(char letter)
        {
            letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
        }

        // Q3: DiceRoller
        // Write a procedure which rolls three dice and write the following messages to the console
        // If all three dice have the same value write, "Three of a kind"
        // If two of the dice have the same value write, "You have a pair!
        // Otherwise write, "Sorry you lose

        public static void ThreeDice(int a, int b, int c)
        {
            Random rnd = new Random();
            {
                a = rnd.Next(6);
                b = rnd.Next(6);
                c = rnd.Next(6);
               
            }
            if  (a == b && b == c)
            {
                Console.Write("Three of a kind");

            }
            if (a == b || b == c || a == c)
            {
                Console.Write("You have a pair!");
            }
            else
            {
                Console.Write("You lose");
            }


        }



        // Q4: Angles
        // Write a function to return whether the angle input is acute, right angle, obtuse, straight or reflex
        // Use an enum for the different angle types

        public enum Angles
        {
            Acute,
            RightAngle,
            Obtuse,
            Straight,
            Reflex,
        }

        public static Angles AngleInput(int Degrees)
        {
            Degrees = Convert.ToInt16(Console.ReadLine());
            if (Degrees < 90)
            {
                return (Angles)0;
            }
            if (Degrees == 90)
            {
                return (Angles)1;
            }
            if (Degrees > 90 && Degrees <180)
            {
                return (Angles)2;
            }
            if (Degrees == 180)
            {
                return (Angles)3;
            }
            if (Degrees > 180 && Degrees < 360)
            {
                return (Angles)4;
            }
            
        }

        // Q5: Rock, Paper Scissors
        // Write a procedure which takes the user's choice as input and randomly generate the computer's choice
        // It should write the computer's choice to the console and write whether the user lost, won, or drew.
        // Handle the user input in the calling code in Program.cs

        static void RockPaperScissors()
        {
             string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Drew");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Win");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Lost");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Lost");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Drew");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Win");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Win");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Lose");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Drew");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            
        }

        // Q6: Triangle
        // Write a function that takes in three side lengths.
        // Determine whether a triangle with those sides is equilateral, isosceles, scalene or impossible

        public static void Triangle(int L1, int L2, int L3)
        {
            L1 = Convert.ToInt16(Console.ReadLine());
            L2 = Convert.ToInt16(Console.ReadLine());
            L3 = Convert.ToInt16(Console.ReadLine());
            if (L1 == L2 && L1 == L3)
            {
                Console.Write("Equilateral");
            }
            if (L1 == L2 || L1 == L3 || L2 == L3)
            {
                Console.Write("Isosceles");
            }
            else
            {
                Console.Write("Scalene");
            }
        }
    }
}
