namespace Empty_Csharp
{
    internal class Program
    {
        static int[] tmp = new int[1_000_000];
        static int target = -1;
        static int K;
        static int saveCount = 0;
        static void merge_sort(int[] A, int headIndex, int tailIndex)
        {
            if (headIndex < tailIndex)
            {
                int middleIndex = (headIndex + tailIndex) / 2;
                merge_sort(A, headIndex, middleIndex);
                merge_sort(A, middleIndex + 1, tailIndex);
                merge(A, headIndex, middleIndex, tailIndex);
            }
        }
        static void merge(int[] A, int headIndex, int middleIndex, int tailIndex)
        {
            int i = headIndex;
            int j = middleIndex + 1;
            int t = 1;
            while (i <= middleIndex && j <= tailIndex)
            {
                if (A[i] <= A[j])
                {
                    tmp[t++] = A[i++];
                }
                else
                {
                    tmp[t++] = A[j++];
                }
                saveCount++;
                if (saveCount == K)
                {
                    target = tmp[t - 1];
                }
            }
            while (i <= middleIndex)
            {
                tmp[t++] = A[i++];
                saveCount++;
                if (saveCount == K)
                {
                    target = tmp[t - 1];
                }
            }
            while (j <= tailIndex)
            {
                tmp[t++] = A[j++];
                saveCount++;
                if (saveCount == K)
                {
                    target = tmp[t - 1];
                }
            }
            i = headIndex;
            t = 1;
            while (i <= tailIndex)
            {
                A[i++] = tmp[t++];     
            }
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] nums1 = s1.Split(' ');
            int N = int.Parse(nums1[0]);
            K = int.Parse(nums1[1]);

            int[] arr = new int[N];

            string s2 = Console.ReadLine();
            string[] nums2 = s2.Split(' ');
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(nums2[i]);
            }

            merge_sort(arr, 0, N - 1);

            /*
            // 정렬 기능 점검용 출력 코드
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            */

            Console.WriteLine(target);

        }
    }
}
