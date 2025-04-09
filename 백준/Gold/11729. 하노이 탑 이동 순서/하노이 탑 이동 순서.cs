using System.Text;

namespace empty
{

    public class Program
    {
        private const int bufferSize = 131072;
        public static readonly StreamReader input = new(new
            BufferedStream(Console.OpenStandardInput(), bufferSize));
        public static readonly StreamWriter output = new(new
            BufferedStream(Console.OpenStandardOutput(), bufferSize));

        static int K = 0;
        static int N;
        static StringBuilder s = new StringBuilder();
        static void Hanoi(int N, int from, int to, int by)
        {
            if (N == 1)
            {
                s.Append($"{from} {to}\n");
                K++;
                return;
            }
            else
            {
                Hanoi(N - 1, from, by, to);
                s.Append($"{from} {to}\n");
                K++;
                Hanoi(N - 1, by, to, from);

            }

        }

        static void Main(string[] args)
        {
            N = int.Parse(input.ReadLine());
            Hanoi(N, 1, 3, 2);
            output.WriteLine(K);

            output.WriteLine(s);
            output.Flush();
        }
    }
}

