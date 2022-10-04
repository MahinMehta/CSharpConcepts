using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class IterationExercises
    {
        // Q1: Centuries
        // Calculate the number of times a batter scored a century (100 runs) or more in a match
        public static int NumberOfCenturiesScored(List<int> runsScored)
        {
            int centuries = 0;
            foreach (int num in runsScored)
            {
                if (num >= 100)
                {
                    centuries += 1;
                }
            }
            return centuries;
        }

        // Q2: Batting Average
        // Calculate the batting average.
        // Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
        public static double BattingAverage(List<int> runsScored)
        {
            double average = 0;
            int count = 0;
            foreach (int num in runsScored)
            {
                if (num >= 0)
                {
                    average = average + num;
                    count += 1;
                }
            }
            average = average / count;
            return average;
        }

        // Q3: User Names
        // Determine the user names
        // It will be the first three characters of their name and a number, which will be the order of the name in the list.
        public static List<string> UserNames(List<string> names)
        {
            List<string> result = new List<string>();
            int index = 0;
            foreach (string name in result)
            {
                string username = ($"{names[index].Substring(0, 3) + index}");
                result.Add(username);

            }
            return result;
        }

        // Q4: Calculate Multiples
        // Write a function that will output the multiple of a number from 1 to the max number specified
        // So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 50]
        public static List<int> CalculateMultiples(int number, int maximumMultiple)
        {
            List<int> multiple = new();

            for (int i = 1; i < maximumMultiple + 1; i++)
            {
                multiple.Add(number * i);
            }

            return multiple;
        }

        // Q5: Is Prime
        // Write a function to determine whether a number is prime
        public static Boolean Prime(int num)
        {
            Boolean Output = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Output = false;
                }
            }
            return Output;
        }

        // Q6: Star Pattern
        // Write a procedure to output a star pattern based on the number of stars input
        // So for example if the user enters 6 then it will output:

        //*
        //**
        //***
        //****
        //*****
        //******
        //*****
        //****
        //***
        //**
        //*

        public static void Stars(int star)
        {
            for (int i = 0; i < star; i++)
            {
                for (int pattern = 0; pattern < i; pattern++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = star; i > 0; i--)
            {
                for (int pattern = 0; pattern < i; pattern++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }




        // Q7: This function should take a noughts and crosses board represented as an character list,
        // A space represents an empty space as shown below.

        /* List<List<char>> board = new()
         {
             new() { 'X', '0', 'X' },
             new() { ' ', '0', ' ' },
             new() { 'X', '0', ' ' }
         };*/

        // The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
        // and ' ' if there is currently no winner.

        public static char NoughtsAndCrosses(List<List<char>> board)
        {
            char Output = ' ';
            foreach (List<char> row in board)
            {
                int noughts = 0;
                int crosses = 0;
                foreach (char symbol in row)
                    if (symbol == '0')
                    {
                        noughts =+ 1;
                    }
                    else if (symbol == 'X')
                    {
                        crosses =+ 1;
                    }
                if (crosses == 3)
                {
                    Output = 'X';
                }
                else if (noughts == 3)
                {
                    Output = '0';
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[c][i] != 'X') { break; }
                    if (c == 2) { return 'X'; }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[c][i] != '0') { break; }
                    if (c == 2) { return '0'; }
                }
            }

            for (int i = 0; i < 3; i++) 
            {
                if (board[i][i] != 'X') { break; }
                if (i == 2) { return 'X'; }
            }
            for (int i = 0; i < 3; i++) 
            {
                if (board[i][i] != '0') { break; }
                if (i == 2) { return '0'; }
            }

            for (int i = 0; i < 3; i++) 
            {
                if (board[i][2 - i] != 'X') { break; }
                if (i == 2) { return 'X'; }
            }

            for (int i = 0; i < 3; i++) 
            {
                if (board[i][2 - i] != '0') { break; }
                if (i == 2) { return '0'; }
            }


            return ' ';

        }
    }
}
