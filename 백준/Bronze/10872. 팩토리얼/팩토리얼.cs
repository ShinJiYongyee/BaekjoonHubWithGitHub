namespace empty
{

    public class Program
    {
        static int MyFactorial( int n)
        {
            if (n <= 1) 
                return 1;
            else
            {
                return n*MyFactorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int answer = MyFactorial(n);
            Console.WriteLine(answer);
        }
    }
}
