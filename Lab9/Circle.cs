using System;
//contain all circle constructors and methods

namespace Lab9
{
    class Circle
    {
        private double radius
        {
            get; set;
        }

        public Circle(double r)
        {
            radius = r;
            Console.WriteLine("The radius of the circle is " + radius + " .");
        }

        public double GetCircumference(double r)
        {
            double pi = Math.PI;
            double circumference = 2 * pi * r;
            return circumference;

        }

        public string GetFormattedCircumference(double c)
        {
           string formatted =  c.ToString("n2");
           return formatted;
        }

        public double GetArea(double r)
        {
            double pi = Math.PI;
            double area = pi * (r * r);
            return area;
        }

        public string GetFormattedArea(double a)
        {
            string formatted = a.ToString("n2");
            return formatted;
        }

    }



    /* private string FormatNumber(double x)
     {
        Why would we need this in the current situation? 
     }

     private Radius()
     {
       This is listed in the public Circle. What is the benefit of listing it twice? Unsure what to do with it here...
     }

     public GetToRadius()
     {

     }*/
}
