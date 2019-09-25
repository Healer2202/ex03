using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            HLine(10, '*');
            Console.WriteLine();
            HLine(10, '*');
            Console.WriteLine();
            DLine(10, '*');
            Console.WriteLine();
            DrawTriangle(10, '*');
            Console.WriteLine();
            DrawN(10, '*');
            Console.WriteLine();
            int number = Convert.ToInt32(Console.ReadLine());
          

        }
        static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }

        static void VLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(c);
            }
        }

        //static void DLine(int n, char c)
        //{
        //    String s = "";
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine(s + c);
        //        s += " ";
        //    }
        //
        //}
        static void DLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                HLine(i, ' ');
                Console.WriteLine(c);
            }
        }

        

        static void DrawN(int n, char c)
        {
            int b = n - 3;
            HLine(1, c);
            HLine(n - 2, ' ');
            HLine(1, c);
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                HLine(1, c);
                HLine(i, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b--;
            }
            HLine(1, c);
            HLine(n - 2, ' ');
            HLine(1, c);
            Console.WriteLine();
        }
        static void CreateHorizon(int number, char c)
        {
            //plus space then print *
            for (int i = 0; i < number; i++)
            {
                Console.Write(c);
            }
        }
        static void CreateVertical(int number, char c)
        {
            //plus space then print *
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        static void Dline(int number, char c)
        {
            //plus space then print *
            for (int i = 0; i < number; i++)
            {
                CreateHorizon(i, ' ');
                Console.WriteLine(c);
            }
        }
    
      static void DrawTriangle(int number, char c)
         //line 1 : n-1 space / 1 star
        // line 2 : n-2 space/ 1 star, 1 space/1 star
         //line 3 : n-3 space/ 1 star, 3 space/1 star
         //last line 2n-1 star 
        {
            //first line
            CreateHorizon(number - 1, ' '); CreateHorizon(1, c); Console.WriteLine();
             //i-th line           
            int line = 1, space = number + 1;
            for (int i = 1; i < number; i++)
             {
                line = line + 1;
                CreateHorizon(number - line, ' '); CreateHorizon(1, c);
                // we got space = number+1 - 2, because Value (number - space) must grow 2 time/ 1 it's only a oDD 
                space = space - 2;
                CreateHorizon(number - space, ' '); CreateHorizon(1, c); Console.WriteLine();
            }
            // last line
            CreateHorizon(number * 2 - 1, c);
        }
    }
}


