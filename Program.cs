using System;

namespace Methods07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char ch;

            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());

            ch = char.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            if (IsMathAction(ch))
            {
                Console.WriteLine(Action(a, ch, b));
            }
            else Console.WriteLine("wrong action");

        }
        static double Action(int a, char ch, int b)
        {
            if (ch == '+') return Add(a, b);
            if (ch == '-') return Sub(a, b);
            if (ch == '/') return Div(a, b);
            return Mult(a,b);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static double Div(int a, int b)
        {
            return (double)a / (double)b;
        }
        static bool IsMathAction(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '/' || ch == '*') return true;
            return false;
        }
    }

}
