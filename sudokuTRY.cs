using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string tempVar = ConsoleInput.ScanfRead();
            if (tempVar != null)
            {
                N = int.Parse(tempVar);
            }
            int[][] A = RectangularArrays.RectangularIntArray(100, 100);
            for (int i = 0; i < N * N; ++i)
            {
                for (int j = 0; j < N * N; ++j)
                {
                    string tempVar2 = ConsoleInput.ScanfRead();
                    if (tempVar2 != null)
                    {
                        A[i][j] = int.Parse(tempVar2);
                    }
                }
            }
            int[] B = new int[101];
            for (int i = 0; i <= N * N; ++i)
            {
                B[i] = 0;
            }
            int k;
            k = 0;
            for (int i = 0; i < N * N; ++i) // проверка по строкам
            {
                for (int j = 0; j < N * N; ++j)
                {
                    B[A[i][j]] += 1;
                }
                for (int col = 1; col <= N * N; ++i)
                {
                    if (B[col] == 0)
                    {
                        ++k;
                    }
                }
                for (int row = 1; row <= N * N; ++i)
                {
                    B[row] = 0;
                }
            }
            for (int j = 0; j < N * N; ++j) // проверка по столбцам
            {
                for (int i = 0; i < N * N; ++i)
                {
                    B[A[i][j]] += 1;
                }
                for (int j = 1; j <= N * N; ++j)
                {
                    if (B[j] == 0)
                    {
                        ++k;
                    }
                }
                for (int j = 1; j <= N * N; ++j)
                {
                    B[j] = 0;
                }
            }
            for (int i = 0; i < N; ++i) // проверка по подмассивам
            {
                for (int j = 0; j < N; ++j)
                {
                    for (int m = 0; m <= N * N; ++m)
                    {
                        B[m] = 0;
                    }
                    for (int y = i * N; y < i * N + N; ++y)
                    {
 
                        for (int x = j * N; x < j * N + N; ++x)
                        {
                            B[A[y][x]] = 1;
                        }
                    }
                    for (int c = 1; c <= N * N; ++c)
                    {
                        if (B[c] == 0)
                        {
                            ++k;
                        }
                    }
                }
            }
            if (k == 0)
            {
                Console.Write("Correct");
            }
            else
            {
                Console.Write("Incorrect");
            }
        }
    }
}