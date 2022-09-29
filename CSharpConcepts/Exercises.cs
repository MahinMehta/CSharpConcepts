using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CSharpConcepts.Classes.Exercises;

namespace CSharpConcepts
{
    internal class Exercises
    {
        internal static void Run()
        {
            //CallTypeExercises();
            CallSelectionExercises();
            OOPExercises.Run();
        }

        private static void CallTypeExercises()
        {
            // Add your calling code here for the questions an example is below

            /*Console.WriteLine("# Calculator");
            TypeExercises.Calculator(12,4,3);
            Console.WriteLine("# Calculator 2");
            TypeExercises.Calculator2(1,2,3);*/
            /*TypeExercises.BinaryStrings(128);
            TypeExercises.BMICalculator();
            TypeExercises.FutureDate(60000);
            TypeExercises.SelectLanguage(2);
            Console.ReadLine();*/

        }

        private static void CallSelectionExercises()
        {
            SelectionExercises.FizzBuzz(3);
            Console.ReadLine();
        }
    }
}
