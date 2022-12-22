using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Qwer"); // 줄에 글을 쓰고, 줄을 넘긴다. 
            //Console.Write("qwer"); 줄에 글을 쓴다.
            //문자열을 변수에 넣을 수 있고, 문자열 덧셈이 가능하다. 
            //int[] a = new int[4];
            //배열의 생성 방법
            //초기화 하기 위해서는 {} 안에 값을 입력한다. 
            //index의 사용 또한 c와 동일
            //Console.ReadLine();
            //int[,] b = new int[2, 3];
            //2차원 배열의 선언(행, 열 순으로)
            //int[,,] c = new int[2, 3, 4];
            int[] a = { 1, 2, 3, 4 };

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);

            int[,] b =
            {
                {10, 20 },
                {30, 40 },
                {50, 60 }
            };

            b[1, 1] = 70;
            Console.WriteLine(b[0, 0]);
            Console.WriteLine(b[1, 1]);
            Console.WriteLine("b[2 ,1]=" + b[2, 1]);

            int[][] c = new int[3][];
            c[0] = new int[3] { 10, 20, 30 };
            c[1] = new int[2] { 40, 50 };
            c[2] = new int[1] { 60 };

            Console.WriteLine(c[0][1]);
            Console.WriteLine(c[2][0]);

            int[][] d = new int[][]
            {
                new int[] {10, 20, 30 },
                new int[] {40, 50},
                new int[] {60}
            };

            Console.WriteLine(d[0][1]);
            Console.WriteLine(d[2][0]);

            Console.WriteLine("b.Length = " + b.Length);
            Console.WriteLine("d.Length = " + d[0].Length);
        }
    }
}

