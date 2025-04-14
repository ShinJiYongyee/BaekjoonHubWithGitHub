using System.Text;

namespace empty
{


    public class MYQueue
    {
        private int[] queue = new int[2_000_000];
        private int head = 0;
        private int tail = 0;

        public void Push(int value)
        {
            queue[tail++] = value;
        }
        public int Pop()
        {
            if (head != tail)
            {
                int a = queue[head++];
                //for (int i = 0; i < tail-1; i++)
                //{
                //    queue[i] = queue[i+1];
                //}
                //head = 0;
                //tail--;
                return a;
            }
            else
            {
                return -1;
            }

        }
        public int Size() => tail - head;

        public int Empty()
        {
            if (head >= tail)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Front()
        {
            if (head < tail)
            {
                return queue[head];
            }
            else
            {
                return -1;
            }
        }
        public int Back()
        {
            if (head < tail)
            {
                return queue[tail - 1];
            }
            else
            {
                return -1;
            }
        }


    }
    public class Program
    {
        private const int bufferSize = 131072;
        public static readonly StreamReader input = new(new
            BufferedStream(Console.OpenStandardInput(), bufferSize));
        public static readonly StreamWriter output = new(new
            BufferedStream(Console.OpenStandardOutput(), bufferSize));

        static void Main(string[] args)
        {

            int N = int.Parse(input.ReadLine());
            StringBuilder sb = new StringBuilder();
            MYQueue mYQueue = new MYQueue();

            for (int i = 0; i < N; i++)
            {
                string[] inputs = input.ReadLine().Split();
                if (inputs[0].Contains("push"))
                {
                    mYQueue.Push(int.Parse(inputs[1]));
                }
                else if (inputs[0].Contains("pop"))
                {
                    sb.Append(mYQueue.Pop() + "\n");
                }
                else if (inputs[0].Contains("size"))
                {
                    sb.Append(mYQueue.Size() + "\n");
                }
                else if (inputs[0].Contains("empty"))
                {
                    sb.Append(mYQueue.Empty() + "\n");
                }
                else if (inputs[0].Contains("front"))
                {
                    sb.Append(mYQueue.Front() + "\n");
                }
                else if (inputs[0].Contains("back"))
                {
                    sb.Append(mYQueue.Back() + "\n");
                }

            }
            Console.WriteLine(sb);
        }
    }
}

