namespace Empty_Csharp
{
    internal class Program
    {
        static string whatisRecursive = "\"재귀함수가 뭔가요?\""; // 긁어올 때 \r 따라오지 않도록 주의
        static string recursiveHead1 = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.";
        static string recursiveHead2 = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.";
        static string recursiveHead3 = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"";
        static string recursiveTail = "라고 답변하였지.";
        static string recursiveAnswer = "\"재귀함수는 자기 자신을 호출하는 함수라네\"";
        static string tab = "____";
        static int depth = 0;
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
            Recursive(a, depth);
        }

        static void Recursive(int n, int depth)
        {
            if (n == 0)
            {
                Tab(depth);
                Console.WriteLine(whatisRecursive);
                Tab(depth);
                Console.WriteLine(recursiveAnswer);
            }
            else if (n < 0) return;
            else
            {
                Tab(depth);
                Console.WriteLine(whatisRecursive);
                Tab(depth);
                Console.WriteLine(recursiveHead1);
                Tab(depth);
                Console.WriteLine(recursiveHead2);
                Tab(depth);
                Console.WriteLine(recursiveHead3);
            }
            Recursive(n - 1, depth + 1);
            Tab(depth);
            Console.Write(recursiveTail);
            if(depth > 0) Console.WriteLine(); // 잘못된 출력 형식 에러 대응
        }
        static void Tab(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(tab);
            }
        }
    }
}
