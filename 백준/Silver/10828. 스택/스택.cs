using System.Text;

namespace empty
{

    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>(10_000);
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            string input;
            string[] inputs;

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine();
                if (input.Contains("push"))
                {
                    inputs = input.Split(' ');
                    st.Push(int.Parse(inputs[1]));
                }
                else if (input.Contains("pop"))
                {
                    if (st.Count > 0)
                    {
                        sb.Append(st.Pop()+"\n");
                    }
                    else
                    {
                        sb.Append(-1 + "\n");
                    }
                }
                else if (input.Contains("size"))
                {
                    sb.Append(st.Count() + "\n");
                }
                else if (input.Contains("empty"))
                {
                    if (st.Count > 0)
                    {
                        sb.Append(0 + "\n");
                    }
                    else
                    {
                        sb.Append(1 + "\n");
                    }
                }
                else if (input.Contains("top"))
                {
                    if (st.Count > 0)
                    {
                       sb.Append( st.Peek() + "\n");
                    }
                    else
                    {
                        sb.Append(-1 + "\n");
                    }
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}

