using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 알고리즘
            //Random random = new Random();

            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; ++i)
            //    arr[i] = random.Next(0, 10);
            //// arr 안에 있는 가장 큰 수를 int Result에 넣어주세요
            ////int Result = 0;
            ////for(int i = 0; i < arr.Length; ++i)
            ////{
            ////    if (arr[i] > Result)
            ////        Result = arr[i];
            ////}
            ////Console.WriteLine(Result);



            //// int[] ranks 안에다가 arr의 숫자가 큰 순서대로 넣어주세요
            //int[] ranks = new int[arr.Length];

            //for(int i = 0; i < arr.Length; ++i)
            //{
            //    ranks[i] = arr[i];
            //    for(int j = 0; j < i; ++j)
            //    {
            //        if(ranks[i] < ranks[j])
            //        {
            //            int g = ranks[i];
            //            ranks[i] = ranks[j];
            //            ranks[j] = g;
            //        }
            //    }
            //}

            //Console.Write("Arr: ");
            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    Console.Write("{0} ", arr[i]);
            //}
            //Console.WriteLine();
            //Console.Write("Ranks: ");
            //for (int i = 0; i < ranks.Length; ++i)
            //{
            //    Console.Write("{0} ", ranks[i]);
            //}
            //Console.WriteLine();
            //#region 내가 짠 이전 코드
            ////int Max = 0;
            ////int except = -1;
            ////int Count = -1;
            ////
            ////while (Count != arr.Length -1)
            ////{
            ////    Count += 1;
            ////    for(int i = 0; i < arr.Length; ++i)
            ////    {
            ////        if(arr[i] > Max)
            ////        {
            ////            if (i == except)
            ////                continue;
            ////            Max = arr[i];
            ////            except = i;
            ////        }
            ////    }
            ////    ranks[Count] = Max;
            ////    Max = 0;
            ////}
            ////
            //#endregion

            //char[] strs = { 'a', 'b', 'c', 'b', 'a', 'a'};
            //char[] results = new char[strs.Length];

            //char a = strs[0];
            //char s = '\0' ;

            //int count = 1;

            //for(int i = 0; i < strs.Length; ++i)
            //{
            //    results[i] = strs[i];
            //}

            //for(int i = 1; i < results.Length; ++i)
            //{
            //    if (results[i] == a)
            //    {
            //        s = results[count];
            //        results[count] = results[i];
            //        results[i] = s;
            //        count++;
            //    }
            //}

            //arrange();
            //arrange();
            //arrange();

            //void arrange()
            //{
            //    char w = strs[count];
            //    for (int i = count; i < results.Length; ++i)
            //    {
            //        if (results[i] == w)
            //        {
            //            s = results[count];
            //            results[count] = results[i];
            //            results[i] = s;
            //            count++;
            //        }
            //    }
            //}

            //// 같은 문자끼리 붙여서, 정렬해보세요.
            //// Output : aaabbc
            //for(int i = 0; i < results.Length; ++i)
            //    Console.Write(results[i]);
            #endregion

            // Queue?
            // FIFO(First in first out)
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("주찬");
            queue.Enqueue("지현");

            Console.WriteLine($"기다리고 있는 손님 : {queue.Count}");
            string guest = queue.Dequeue();
            Console.WriteLine($"다음 손님 : {guest}");

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(5);

            //stack.Count

            int result = stack.Pop();

            Stack<string> A = new Stack<string>();
            Stack<string> B = new Stack<string>();
            Stack<string> C = new Stack<string>();

            const string BigBlock = "Big";
            const string MiddleBlock = "Mid";
            const string SmallBlock = "Sml";

            C.Push(BigBlock);
            C.Push(MiddleBlock);
            C.Push(SmallBlock);


            string Move(Stack<string> Q, Stack<string> W)
            {
                string value = Q.Pop();
                W.Push(value);
                return value;
            }
            Console.WriteLine($"C에서A로{Move(C, A)}이동");
            Console.WriteLine($"C에서B로{Move(C, B)}이동");
            Console.WriteLine($"A에서B로{Move(A, B)}이동");
            Console.WriteLine($"C에서A로{Move(C, A)}이동");
            Console.WriteLine($"B에서C로{Move(B, C)}이동");
            Console.WriteLine($"B에서A로{Move(B, A)}이동");
            Console.WriteLine($"C에서A로{Move(C, A)}이동");

            Console.WriteLine($"A 상 {A.Pop()}");
            Console.WriteLine($"A 중 {A.Pop()}");
            Console.WriteLine($"A 하 {A.Pop()}");
        }
    }
}
