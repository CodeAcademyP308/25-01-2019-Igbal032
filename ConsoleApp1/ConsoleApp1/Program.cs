using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            Console.WriteLine("Fennlerin sayini daxil edin:");
            var n = int.Parse(Console.ReadLine());
            int[] grades = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(""+(i+1)+".fenni daxil edin:");
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ortalamaniz :"+ prg.CalculateAvarage(grades));

        }
        double CalculateAvarage(int[] grade)
        {
            double avarage;
            int sum = 0;
            for(int i = 0; i < grade.Length; i++)
            {
                sum += grade[i];
            }
            avarage = sum / grade.Length;

            return avarage;
        }
     
     
    }
}
