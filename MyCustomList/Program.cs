﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> testList = new List<int> { 1, 2, 3, 2 };

            testList.Remove(2);
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(5);
            test.Add(6);
            test.Add(8);
            test.Add(3);
            test.Remove(5);

            //List<int> test = new List<int>();
            //test.Add(1);
            //test.Add(2);
            //test.Add(3);
            //test.Add(4);
            //test.Add(5);
            //bool x = test.Remove(0);
            //test.Remove(2);
            //test.Remove(3);
            //test.Remove(1);
            //test.Remove(4);


        }
    }
}
