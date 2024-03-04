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
            // fan1
            Fan fan1 = new Fan();
            fan1.Speed = 3;
            fan1.Radius = 10;
            fan1.Color = "Yellow";
            fan1.On = true;
            Console.WriteLine("Fan 1:");
            fan1.GetDisPlay();

            // fan 2
            Fan fan2 = new Fan();
            fan2.Speed = 2;
            Console.WriteLine("Fan 2:");
            fan2.GetDisPlay();
           
           
            Console.ReadKey();

        }
    }
    public class Fan
    {
        // Constants for speed
        const int Slow = 1;
        const int Medium = 2;
        const int Fast = 3;
        // Fields
        int speed;
        bool on;
        double radius;
        string color;
        public Fan()
        {
            speed = Slow;
            on = false;
            radius = 5;
            color = "blue";
        }
        // hàm speed
        public int Speed {  get { return speed; } set { speed = value; } }
        // ham on
        public bool On { get { return on; } set { on = value; } }
        // ham radius
        public double Radius { get { return radius; } set { radius = value; } }
        // hàm màu sắc
        public string Color { get { return color; } set { color = value; } }
        // ham hien thi
        public void GetDisPlay()
        {
            Console.WriteLine("Speed :" + speed);
            Console.WriteLine("On :" + on);
            Console.WriteLine("Radius :" + radius);
            Console.WriteLine("Color :" + color);
        }

    }




}
