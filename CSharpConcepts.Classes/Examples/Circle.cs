using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Examples
{
    public class Circle
    {
        private const double Pi = 3.142;
        
        // This is a constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // These are properties
        public double Radius { get; private set; }
        public double Circumference
        {
            get
            {
                return 2 * Pi * Radius;
            }
        }
        public double Area
        {
            get
            {
                return Pi * Math.Pow(Radius, 2);
            }            
        }
    }
}
