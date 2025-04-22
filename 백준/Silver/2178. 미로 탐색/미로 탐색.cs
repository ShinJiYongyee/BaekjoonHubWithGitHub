namespace empty
{

    public class Program
    {
        static string[] map;    //입력받는 맵
        static int[,] distance = new int[104, 104];     // 좌표별 거리
        static bool[,] isVisited = new bool[104, 104];  // 좌표별 방문 여부
        static int[] dirX = { 1, -1, 0, 0 };    // x방향 탐색 가짓수
        static int[] dirY = { 0, 0, 1, -1 };    // y방향 탐색 가짓수
        static int N, M;

        public static void BFS(int x, int y)
        {
            // 튜플 형식의 BFS 큐 선언
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            // 시작 좌표 삽입
            q.Enqueue(new Tuple<int, int>(x, y));
            // 시작 좌표 방문 여부를 참으로 변경
            isVisited[x, y] = true;

            while (q.Count > 0)
            {
                Tuple<int, int> now = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int newX = now.Item1 + dirX[i];
                    int newY = now.Item2 + dirY[i];
                    // 시작좌표로 되돌아올 경우 재탐색
                    if (newX == 0 && newY == 0)
                    {
                        continue;
                    }
                    // 무효한 좌표일 경우 재탐색
                    if (newX < 0 || newY < 0)
                    {
                        continue;
                    }
                    if (newX >= N || newY >= M)
                    {
                        continue;
                    }
                    // 길이 아닐 경우 재탐색
                    if (map[newX][newY] == '0')
                    {
                        continue;
                    }
                    // 이미 방문한 곳일 경우 재탐색
                    if (isVisited[newX, newY])
                    {
                        continue;
                    }
                    //경로 탐색 성공시 거리+1, 방문 여부 참으로 변경, 큐 삽입
                    if (map[newX][newY] == '1')
                    {
                        distance[newX, newY] = distance[now.Item1, now.Item2] + 1;
                        isVisited[newX, newY] = true;
                        //Console.WriteLine($"visited {newX}, {newY}, distance to {newX},{newY} is {distance[newX, newY]}");
                        q.Enqueue(new Tuple<int, int>(newX, newY));
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            N = inputs[0];
            M = inputs[1];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    isVisited[i, j] = false;
                }
            }

            map = new string[N];

            for (int i = 0; i < N; i++)
            {
                map[i] = Console.ReadLine();
            }

            BFS(0, 0);

            // 좌표[N, M] -> 인덱스 [N-1, M-1]의 거리 출력
            Console.Write(distance[N-1, M-1] + 1);


        }
    }
}

