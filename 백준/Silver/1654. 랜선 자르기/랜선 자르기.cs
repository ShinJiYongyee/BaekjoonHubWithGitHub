namespace empty
{

    public class Program
    {
        private const int bufferSize = 131072;
        public static readonly StreamReader input = new(new BufferedStream(Console.OpenStandardInput(), bufferSize));
        public static readonly StreamWriter output = new(new BufferedStream(Console.OpenStandardOutput(), bufferSize));

        static long K, N;   //int형은 overflow가 날 수 있으므로 long형 사용
        static long minX = int.MaxValue; //maxValue = int32의 최대값, 2147483647
        static long[] lan = new long[10_000]; //이미 가지고 있는 랜선의 수, 최대 10_000개

        static void Main(string[] args)
        {
            // 두 입력값 K, N
            long[] inputs = Array.ConvertAll(input.ReadLine().Split(), long.Parse);
            K = inputs[0];
            N = inputs[1];

            // K 개의 랜선 길이 입력받기
            for (int i = 0; i < K; i++)
            {
                lan[i] = long.Parse(input.ReadLine());  // 문자열을 읽어 수로 변환, lan[]에 저장
                minX = Math.Max(minX, lan[i]);          // minX와 lan[i]중 작은 값을 minX에 저장
            }

            // [1, 가장 짧은 랜선의 길이] 범위 내에서 이진 탐색
            long start = 1;
            long end = minX;

            long result = 0;    // 결과(정답이 될 길이0를 저장할 변수

            while (start <= end)
            {
                long mid = (start + end) / 2; // 최대값과 최소값 중간에 위치한 임의의 해

                long sum = 0;   // 해당 길이로 잘라 낸 랜선의 수 합계
                for (int i = 0; i < K; ++i)
                {
                    sum += lan[i] / mid;   // K개 전선을 mid(cm) 길이로 잘라낸 몫을 합산한다
                }
                if (sum >= N) //자를 수 있는 전선의 수가 필요한 수 이상일 때(즉 답으로 기능할 때)
                {
                    result = Math.Max(result, mid); // 현재까지 결과와 중간값 중 큰 값을 결과에 저장
                    start = mid + 1;  //탐색 범위의 시작점을 mid + 1(cm)로 이동, 더 큰 결과값을 탐색
                }
                else    //자를 수 있는 전선의 수가 필요한 수 이하일 때(답으로 기능하지 않을 때)
                {
                    end = mid - 1;  //탐색 범위의 종점을 mid - 1(cm)로 이동, 더 작은 결과값을 탐색
                }
            }

            output.WriteLine(result);
            output.Flush();

        }
    }
}
