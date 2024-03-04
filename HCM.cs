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
            Console.WriteLine("Nhập chiều dai của hình chữ nhật:");
            double cd = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng của hcn:");
            double cr = double.Parse(Console.ReadLine());
         
            Rectangle retangle = new Rectangle(cd, cr);
            Console.WriteLine("Kích thước hình chữ nhật :");
            Console.WriteLine(retangle.GetDisplay().ToString());
            Console.WriteLine("Diện tích hình chữ nhật:");
            Console.WriteLine(retangle.GetArea().ToString());
            Console.WriteLine("Chu vi hình chữ nhật:");
            Console.WriteLine(retangle.GetPerimeter().ToString());
            Console.ReadKey();

        }
    }
    public  class Rectangle
    {
       public  double  height, width;
        // hàm khời tạo
        public  Rectangle() { }
        public  Rectangle(double heiight, double width) {
            this.height = heiight;
            this.width = width;
        }
        // tính s, chuvi
        public  double GetArea()
        {
            return this.height * this.width;
        }
        // hàm tính chu vi
        public double GetPerimeter()
        {
            return (this.height + this.width) / 2;
        }
        // hàm hiển thi
        public string GetDisplay()
        {
            return "Rectangle{" + "width=" + this.width + ", height=" + this.height + "}";
        }


     }
}
