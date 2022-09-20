using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class TypeExercises
    {
        // Q1: Calculator 1
        // Write to the console correctly the results of: +. - , *, /
        public static void Calculator(int num1, int num2, int Select)
        {
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Choose:\n1. + \n2. - \n3. / \n4. *\n");
            Select = Convert.ToInt16(Console.ReadLine());
            if (Select == 1)
            {
                Console.WriteLine(num1 + num2);
            }
            if (Select == 2)
            {
                Console.WriteLine(num1 - num2);

            }
            if (Select == 3)
            {
                Console.WriteLine(num1 / num2);
            }
            if (Select == 4)
            {
                Console.WriteLine(num1 * num2);
            }
            if (Select <= 5)
            {
                Console.WriteLine("ERROR");
            }
        }

        // Q2: Calculator 2
        // Try to convert both the values to a double and write to the console the results of: +. - , *, /
        public static void Calculator2(double n1, double n2, double choose)
        {
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Choose:\n1. + \n2. - \n3. / \n4. *\n");
            choose = Convert.ToDouble(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine(n1 + n2);
            }
            if (choose == 2)
            {
                Console.WriteLine(n1 - n2);

            }
            if (choose == 3)
            {
                Console.WriteLine(n1 / n2);
            }
            if (choose == 4)
            {
                Console.WriteLine(n1 * n2);
            }
            if (choose <= 5)
            {
                Console.WriteLine("ERROR");
            }
        }

        // Q3: Binary Strings
        // Write to the console the number printed in Binary, Decimal and Hex formats
        public static void BinaryStrings(int num = 14)
        { 
        
            string b = Convert.ToString(num, 2);
            string h = Convert.ToString(num, 16);
            Console.WriteLine(b);
            Console.WriteLine(h);
            
        }

        // Q4: BMI
        // Calculate and return the BMI - Body mass index
        public static double BMICalculator(double height = 1.79, double weight = 73)
        {
            Console.WriteLine(weight/(height * height));
            return weight;
        }

        // Q5: FutureDate
        // Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
        public static DateTime FutureDate(int days)
        {
            Console.WriteLine(DateTime.Now);
            DateTime newDate = DateTime.Now.AddDays(days);
            Console.WriteLine(newDate);
            return newDate;

        }

        // Q6: Languages
        // Using the enum below write a program that will convert the proposed language to the enum if availabe
        // Otherwise it should randomly assign a language
        public enum Language
        {
            French,
            Italian,
            Spanish,
            Finnish
        }
        /*public static Language SelectLanguage(int proposedLanguage)
        {
            proposedLanguage = Convert.ToInt16(Console.ReadLine());
            if (proposedLanguage == 1)
            {
                Console.Write("French");
            }
            if (proposedLanguage == 2)
            {
                Console.Write("Italian");
            }
            if (proposedLanguage == 3)
            {
                Console.Write("Spanish");
            }
            if (proposedLanguage == 4)
            {
                Console.Write("Finnish");
            }
            else
            {
                Console.Write("Error");
            }*/
        }   


    }
}
