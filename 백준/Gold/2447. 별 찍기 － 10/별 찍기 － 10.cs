using System.Text;

namespace Empty_Csharp
{
    internal class Program
    {
        private const int bufferSize = 131072;
        public static readonly StreamReader input = new(new BufferedStream(Console.OpenStandardInput(), bufferSize));
        public static readonly StreamWriter output = new(new BufferedStream(Console.OpenStandardOutput(), bufferSize));
        static StringBuilder stringBuilder = new StringBuilder(); //여기에 입력값을 append 후 출력

        // 풀이 출처
        // https://cryptosalamander.tistory.com/38
        static void PrintStar(int i, int j, int N)
        {
            // 프랙탈의 기본 단위(N == 3)
            // ***
            // * *
            // ***

            // 기본 단위 프랙탈의 가운데 빈 부분 좌표
            if ((i / N) % 3 == 1 && (j / N) % 3 == 1)
            {
                stringBuilder.Append(' ');
            }
            else
            {
                // 재귀적으로 호출된 도형의 최소 단위
                // N == 3^0일 경우의 출력
                if (N / 3 == 0)
                {
                    stringBuilder.Append('*');
                }
                // 재귀적 호출
                else
                {
                    PrintStar(i, j, N / 3);
                }
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(input.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    PrintStar(i, j, N);
                }
                stringBuilder.Append('\n');
            }

            output.WriteLine(stringBuilder);
            output.Flush();
        }
    }
}
