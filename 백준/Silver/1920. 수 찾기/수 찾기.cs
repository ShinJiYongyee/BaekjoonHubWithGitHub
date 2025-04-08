namespace empty
{

    public class Program
    {
        private const int bufferSize = 131072;
        public static readonly StreamReader input = new(new
    BufferedStream(Console.OpenStandardInput(), bufferSize));
        public static readonly StreamWriter output = new(new
            BufferedStream(Console.OpenStandardOutput(), bufferSize));

        static int[] A;
        static int[] arr;

        static int BinarySearch(int[] arr, int key)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == key)
                {
                    return 1;
                }
                else if (arr[mid] < key)
                {
                    start = mid + 1;
                }
                else /*if (list[mid] > key)*/
                {
                    end = mid - 1;
                }

            }
            return 0;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(input.ReadLine());

            A = Array.ConvertAll<string, int>(input.ReadLine().Split(), int.Parse);

            Array.Sort(A);

            int M = int.Parse(input.ReadLine());


            arr = Array.ConvertAll<string, int>(input.ReadLine().Split(), int.Parse);

            foreach (int i in arr)
            {
                output.WriteLine(BinarySearch(A, i));
            }

            output.Flush();
        }
    }
}
