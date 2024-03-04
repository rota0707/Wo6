using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Circle
            Circle circle = new Circle(12, "yellow");
            Console.WriteLine(circle.ToString());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Cylinder
            Cylinder cylinder = new Cylinder(8, 15, "blue");
       
            Console.WriteLine(cylinder.ToString());





            Console.ReadKey();

        }
    }

    // circle
    public class Circle
    {
        double radius;
        string color;
        // ham khoi toa
        public Circle() { }
        public Circle( double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        // get and set
        public double Radius { get { return radius; } set { radius = value; } }
        public string Color { get { return color; } set { color = value; } }
        // s
        public double Area
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }
        // to string
        public override string ToString()
        {
            return $"Circle : Radius= {radius}, Color = {color}, Area = {Area}";
        }
    }
    // Cylinder
    public class Cylinder : Circle
    {
        double height;
        // ham khoi toa
        public Cylinder() { }
        public Cylinder(double height) : base()
        {
            this.height = height;
        }
        public Cylinder(double height,double radius,string color) : base(radius, color)
        {
            this.height = height;
        }
        // get and set
        public double Height { get { return height; } set { height = value; } }

        // V
        public double V()
        {
            return Area * Height;
        }
        // to Strong
        public override string ToString()
        {
            return $"Cylinder - {base.ToString()}, V = {V()}";
        }
    }





}