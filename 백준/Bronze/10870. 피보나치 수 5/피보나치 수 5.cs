namespace empty
{

    public class Program
    {
        static int MyFibonacci( int n)
        {
            if (n == 0) 
                return 0;
            else if(n==1)
                return 1;
            else
            {
                return MyFibonacci(n - 1) + MyFibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int answer = MyFibonacci(n);
            Console.WriteLine(answer);
        }
    }
}
