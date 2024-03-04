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
            // to độ 2d
            Point2D point2D = new Point2D(32.05f, 89.09f);
            Console.WriteLine(point2D.ToString());
            Console.WriteLine();
            Console.WriteLine();



            // toa dodoj 3d
            Point3D point3D = new Point3D(76.99f, 78, 99.68f);
            Console.WriteLine(point3D.ToString());





            Console.ReadKey();

        }
    }
    public class Point2D
    {
        float x=0.0f, y=0.0f;
        //ham khoi toa
        public Point2D() { }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        // set and get
        public float X { get { return x; } set { x = value; } }
        public float Y { get { return y; } set { y = value; } }
        // x,y
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float[] GetXY()
        {
            return new float[] { x, y };
        }// to String
        public override string ToString()
        {
            return $"Toa do (x,y) = ({x} , {y})";
        }

    }
    public class Point3D : Point2D
    {
        float z = 0.0f;
        // ham khoi toa
        public Point3D() { }
        public Point3D(float z) : base()
        {
            this.z = z;
        }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        //get and set
        public float Z { get { return z; } set { z = value; } }
        //set XYZ
        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y);
            this.z = z;
        }

        public float[] GetXYZ()
        {
            return new float[] { X, Y, z }; 
        }
        // toStrong
        public  string ToString()
        {
            return $"ToDo (x,y,z) = ({X} , {Y} ,{z})";
        } 

    }


}