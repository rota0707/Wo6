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
            Student s1 = new Student(1, "Nam");
            Student s2 = new Student(2, "Ngoc");
            Student s3 = new Student(3, "Tu");
            Student.Change();
            s1.GetDisPlay();
            s2.GetDisPlay();
            s3.GetDisPlay();
         
           
            Console.ReadKey();

        }
    }
    public class Student
    {
        private int id;
        private string name;
        static string college;
        // hàm khơi tạo
       public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
           
        }
        public static void Change()
        {
            college = "DHQGHN";
        }
        // hienr thi
        public void GetDisPlay()
        {
            Console.WriteLine(id + " " + name + " " + college);
        }
    }
   


}
