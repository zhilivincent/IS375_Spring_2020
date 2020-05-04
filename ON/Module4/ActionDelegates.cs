﻿using System;

namespace ActionDelegates
{
    class Program
    {
        public static void myfun(int p, int q)
        {
            Console.WriteLine(p - q);
        }

        // Main method
        static public void Main()
        {

            // Using Action delegate
            // Here, Action delegate
            // contains two input parameters
            Action<int, int> val = myfun;
            val(20, 5);
        }
    }
}
