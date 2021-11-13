using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace sem9_dynamicPrg.task_2
{
    public class dOReboot
    {
        public static void max_work(int n, int[] X, int[] S)
        {
            int ind_min = findIND_min_el(X, n);
            int[] reboot_day = new int[n];
            int sum = 0;

            for (int i = 0, j = 0; i < n; i++)
            {
                if (i != ind_min)
                {
                    reboot_day[i] = Math.Min(X[i], S[j]);
                    j++;
                }
                else
                {
                    reboot_day[i] = 0;
                    j = 0;
                }
                sum += reboot_day[i];
            }
            
            Console.WriteLine(sum);
            for(int i=0;i<n;i++)
                Console.Write($"{reboot_day[i]} ");
        }
        public static int findIND_min_el(int[] arr, int n)
        {
            int ind_min = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[ind_min])
                    ind_min = i;
            }

            return ind_min;
        } 
    }
}