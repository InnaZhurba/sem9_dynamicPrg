using System;
using System.Collections.Generic;
using sem9_dynamicPrg.task_1;
using sem9_dynamicPrg.task_2;
using sem9_dynamicPrg.task_3;
using sem9_dynamicPrg.task_7;

namespace sem9_dynamicPrg
{
    class Program
    {
        public static void call_task1()
        {
            int n = 4;
            int M = 10;
            int[] a = {1, 3, 20, 30},
                b = {50, 20, 2, 4};
            min_cost.solve(n,M,a,b);
        }
        public static void call_task2()
        {
            int n = 4;
            int[] X = {10, 1, 7, 7},
                S = {8, 4, 2, 1};

            dOReboot.max_work(n, X, S);
        }

        public static void call_task3()
        {
            int r = 1;
            int c = 10;
            int[] S = {11, 9, 9, 12, 12, 12, 12, 9, 9, 11};
            
            AorB.solve(r,c,S);
        }

        public static void call_task7()
        {
            /*string T = "helloworld";
            List<string> Dict = new List<string>()
                {"hello", "world", "earth"};*/
            
            /*string T = "breaksandown";
            List<string> Dict = new List<string>()
                {"breaks", "sand", "down"};*/
            
            string T = "solvemesolve";
            List<string> Dict = new List<string>()
                {"solve", "me"};

            Console.WriteLine(split_dictionary.solve(T, Dict));
        }
        static void Main(string[] args)
        {
           //call_task1();
           //call_task2();
           //call_task3();
           call_task7();
           
           Console.WriteLine();
        }
    }
}