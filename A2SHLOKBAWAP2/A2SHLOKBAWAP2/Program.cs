using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SHLOKBAWAP2
{
    class Program
    {
        static double volume(double radius)
        {
            double vsphere = 1.33 * 3.14159 * radius * radius * radius;
            return vsphere;
        }

        static double volume(double radius, double height)
        {
            double vcylinder = 3.14159 * radius * radius * height;
            return vcylinder;
        }
        static double volume(double length, double width, double height)
        {
            double vrprism = length * width * height;
            return vrprism;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To calculate volume of sphere press 1");
            Console.WriteLine("To calculate volume of cylinder press 2");
            Console.WriteLine("To calculate volume of rectangular prism press 3");
            string x = Console.ReadLine();
            int choice = int.Parse(x);

            if (choice == 1)
            {
                Console.WriteLine("Enter Radius of Sphere");
                string r = Console.ReadLine();
                double radius = double.Parse(r);
                double Res = volume(radius);
                Console.WriteLine("The volume of sphere with radius = " + radius + " is " + Res);
            }
            if (choice == 2) 
            {
                Console.WriteLine("Enter radius of sphere");
                string r = Console.ReadLine();
                double radius=double.Parse(r);
                Console.WriteLine("Enter height of cylinder");
                string h = Console.ReadLine();
                double height = double.Parse(h);
                double res = volume(radius, height);
                Console.WriteLine("The Volume of Cylinder with radius = " + radius + " and height = " + height + " is " + res);
            }
            if (choice == 3)
            {
                Console.WriteLine("Enter length of rectangular Prism");
                string l = Console.ReadLine();
                double length = double.Parse(l);
                Console.WriteLine("Enter width of rectangular Prism");
                string w = Console.ReadLine();
                double width = double.Parse(w);
                Console.WriteLine("Enter height of rectangular Prism");
                string h = Console.ReadLine();
                double height = double.Parse(h);
                double res = volume(length, width, height);
                Console.WriteLine("the volume of rectangular Prism with length =" + length + " , width = " + width + " and height = " + height+ " is " + res);
            }
        }
    }
}
