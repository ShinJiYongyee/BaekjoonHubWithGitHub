using System.Threading.Channels;

namespace Empty_Csharp
{
    internal class Program
    {
        static int[] Fibonaccis = new int[10000];
        static int code1 = 0;
        static int code2 = 0;
        static int Recursive(int n)
        {
            if (n == 1 || n == 2)
            {
                code1++;
                return 1;
            }
            else
            {
                return Recursive(n - 1) + Recursive(n - 2);
            }
        }
        static int Dynamic(int n)
        {
            Fibonaccis[1] = 1;
            Fibonaccis[2] = 1;
            for(int i = 3; i <= n; i++)
            {
                code2++; 
                Fibonaccis[i] = Fibonaccis[i - 1] + Fibonaccis[i - 2];
            }
            return Fibonaccis[n];
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Recursive(n);
            Dynamic(n);

            Console.WriteLine(code1 + " " + code2);
        }
    }
}
