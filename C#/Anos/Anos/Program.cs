using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anos
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Num;
            //Console.WriteLine("Enter Your Lottery Number");
            //Num = int.Parse(Console.ReadLine());
            //switch (Num)
            //{
            //    case 140:
            //        Console.WriteLine("Congrats You Got 1st Prize");
            //        break;

            //    case 180:
            //        Console.WriteLine("Congrats You Got 2nd Prize");
            //        break;

            //    case 200:
            //        Console.WriteLine("Congrats You Got 3rd Prize");
            //        break;

            //    default:
            //        Console.WriteLine("Better Luck Next Time");
            //        break;
            //}



            int[] marks = new int[5];
            int sum = 0;
            Console.WriteLine("Enter Your Marks");
            for (int i = 0; i < 5 ; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Here Your Marks List");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(marks[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            Console.WriteLine("Total Marks Are\t" +sum);


















        }
    }
}
