using System.Text;

namespace Empty_Csharp
{
    internal class Program
    {
        private const int bufferSize = 131072;
        public static readonly StreamReader input = new(new BufferedStream(Console.OpenStandardInput(), bufferSize));
        public static readonly StreamWriter output = new(new BufferedStream(Console.OpenStandardOutput(), bufferSize));

        static int[,,] RecursiveResults = new int[100, 100, 100];
        static StringBuilder stringBuilder = new StringBuilder();
        static int Recursive(int a, int b, int c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                return 1;
            }
            else if (a > 20 || b > 20 || c > 20)
            {
                if (RecursiveResults[a, b, c] != 0)
                {
                    return RecursiveResults[a, b, c];
                }
                else
                {
                    return 
                        RecursiveResults[a, b, c] = 
                        Recursive(20, 20, 20);
                }
            }
            else if ( a < b && b < c)
            {
                if (RecursiveResults[a, b, c] != 0)
                {
                    return RecursiveResults[a, b, c];
                }
                else
                {
                    return
                        RecursiveResults[a, b, c] =
                        Recursive(a, b, c - 1) +
                        Recursive(a, b - 1, c - 1) -
                        Recursive(a, b - 1, c);
                }
            }
            else
            {
                if (RecursiveResults[a, b, c] != 0)
                {
                    return RecursiveResults[a, b, c];
                }
                else
                {
                    return
                        RecursiveResults[a, b, c] =
                        Recursive(a - 1, b, c) +
                        Recursive(a - 1, b - 1, c) +
                        Recursive(a - 1, b, c - 1) -
                        Recursive(a - 1, b - 1, c - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] inputs = new int[3];
            int a = 0, b = 0, c = 0, result = 0;
            while (true)
            {
                string inputString = input.ReadLine();
                if (inputString == "-1 -1 -1") 
                    break;
                string[] splitted = inputString.Split(' ');
                int i = 0;
                foreach(string s in splitted)
                {
                    inputs[i] = int.Parse(s);
                    i++;
                }

                a = inputs[0];
                b = inputs[1];
                c = inputs[2];

                // 문자열 입력 시험용 코드
                //Console.WriteLine(a + " " + b + " " + c); 

                result = Recursive(a, b, c);
                stringBuilder.Append($"w({a}, {b}, {c}) = {result}\n");
            }

            output.WriteLine(stringBuilder.ToString());
            output.Flush();
        }
    }
}
