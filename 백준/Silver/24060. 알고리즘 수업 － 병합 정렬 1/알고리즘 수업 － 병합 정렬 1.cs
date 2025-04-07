namespace empty
{

    public class Program
    {
        static int[] tmp;
        static int saveCount = 0;
        static int K;
        static int answer = 0;
        static int trueAnswer = 0;
        static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int i = left;
            int j = middle + 1;
            int t = 0;
            while (i <= middle && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    tmp[t++] = arr[i++];
                }
                else
                {
                    tmp[t++] = arr[j++];
                }
                //PrintArr(tmp);

            }
            while (i <= middle)
            {
                tmp[t++] = arr[i++];
                //PrintArr(tmp);

            }
            while (j <= right)
            {
                tmp[t++] = arr[j++];
                //PrintArr(tmp);

            }
            i = left;
            t = 0;
            while (i <= right)
            {
                arr[i] = tmp[t];
                IncreaseSaveCount(tmp[t]);
                i++;
                t++;
                //PrintArr(tmp);

            }
        }

        //static void PrintArr(int[] arr)
        //{
        //    foreach (int i in arr)
        //    {
        //        //(i + " ");
        //    }
        //    //();

        //}

        static void IncreaseSaveCount(int t)
        {
            if (saveCount == K)
            {
                //("answer is " + answer);
                trueAnswer = answer;
            }
            saveCount++;
            //("savecount is " + saveCount);
            //("saved data is " + t);
            answer = t;
        }

        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] nums1 = s1.Split(' ');
            int N = int.Parse(nums1[0]);
            K = int.Parse(nums1[1]);

            int[] A = new int[N];
            tmp = new int[N];

            string s2 = Console.ReadLine();
            string[] nums2 = s2.Split(' ');
            for (int i = 0; i < nums2.Length; i++)
            {
                A[i] = int.Parse(nums2[i]);
            }

            //("N is " + N + "\n" + "K is " + K);

            //PrintArr(A);

            Sort(A, 0, N - 1);

            //PrintArr(A);
            ////(saveCount);

            if(saveCount >= K)
            {
                //("trueanswer is");
                Console.WriteLine(trueAnswer);
            }
            else
            {
                Console.WriteLine(-1);
            }



        }
    }
}
