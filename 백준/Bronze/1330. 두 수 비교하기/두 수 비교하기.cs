namespace empty
{

    public class Program
    {

        static void Main(string[] args)
        {
            int[] a = new int[2];
            var inputArray = Console.ReadLine().Split(' ');
            a[0] = Int32.Parse(inputArray[0]);
            a[1] = Int32.Parse(inputArray[1]);

            if (a[0]-a[1] > 0)
            {
                Console.WriteLine('>');
            }
            else if (a[0] - a[1] < 0)
            {
                Console.WriteLine('<');
            }
            else
            {
                Console.WriteLine("==");
            }
        }

    }
}
