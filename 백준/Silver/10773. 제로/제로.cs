using System.Text;

namespace empty
{
    public class MyStack
    {
        private int[] ints;
        private int index = -1;

        public MyStack(int K)
        {
            ints = new int[K];
        }

        public void push(int value)
        {
            if (value == 0)
            {
                this.pop();
            }
            else
            {
                ints[++index] = value;
            }
        }
        public void pop()
        {
            ints[index--] = 0;
        }

        public int GetSum()
        {
            int sum = 0;    
            foreach (int i in ints)
            {
                sum += i;
            }

            return sum;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            MyStack stack = new MyStack(K);

            for (int i = 0; i < K; i++)
            {
                stack.push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(stack.GetSum());
        }
    }
}

