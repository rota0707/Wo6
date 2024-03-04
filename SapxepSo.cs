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
            int[] number = new int[100000];
            Random r = new Random();
            for(int i=0; i < number.Length; i++)
            {
                number[i] = r.Next(1, 100000);
            }
            Timer timer = new Timer();
            timer.Start();
            SelectionSort(number);
            timer.Stop();
            Console.WriteLine("Thời gian chờ thực thi sắp xếp 100000 số là:" + timer.GetElapsedTime());

 
           
            Console.ReadKey();

        }
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[index])
                    {
                        index = j;
                    }
                }
                int temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }
    }
    class Timer
    {
        DateTime startTime;
        DateTime endTime;
        
        public DateTime StartTime { get => startTime; }
        public DateTime EndTime { get => endTime; }
        
        // timer
        public Timer()
        {
            startTime = DateTime.Now;
        }
        public void Start()
        {
            startTime = DateTime.Now;
            
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        // time chênh lẹch
        public double GetElapsedTime()
        {
            TimeSpan timespan = endTime - startTime;

            return timespan.TotalMilliseconds;
        }
        



    }




}
