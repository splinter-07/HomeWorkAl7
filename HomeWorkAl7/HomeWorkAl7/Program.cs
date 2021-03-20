using System;

namespace HomeWorkAl7
{
    class Program
    {
        const int N = 5;
        const int M = 5;


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Pr1();
            var i = Task(N, M);
            Console.WriteLine($"Количество возможных вариантов {i}");
        }

        public static int Task(int n, int m)
        {
            if (n == 1) return 1;
            if (m == 1) return 1;
            if (n >= N) Task(n, m - 1);
            if (m >= M) Task(n - 1, m);
            return Task(n - 1, m) + Task(n, m - 1);
        }
        public static void Pr1()
        {
            int[,] A = new int[N, M];
            int i, j;
            for (j = 0; j < M; j++)
                A[0, j] = 1; // Первая строка заполнена единицами
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
            }

            Print2(N, M, A);
        }
        public static void Print2(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.Write("\r\n");
            }
        }
    }
}
