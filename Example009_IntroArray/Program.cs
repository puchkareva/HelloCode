﻿using System;

namespace Example009_IntroArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // int Max(int arg1, int arg2, int arg3)
            // {
            //    int result = arg1;
            //    if(arg2> result) result = arg2;
            //    if(arg3> result) result = arg3;
            //    return result;
            // }
            //              0   1  2   3   4   5    6   7  8
            // int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};
            // array[0] = 12;
            // Console.WriteLine(array[4]); 

          // int result = Max(
             //  Max(array[0], array[1], array[2]),
              // Max(array[3], array[4], array[5]),
              // Max(array[6], array[7], array[8])
          // );
          // Console.WriteLine(result);

          // int[] array = { 1, 12, 31, 18, 4, 15, 16, 17, 18 };

          // int n = array.Length;
          // int find = 18;

          // int index = 0;

          // while (index < n)
          // {

             // if(array[index] == find)
            // {
               //   Console.WriteLine(index);
                 // break;
              // }
              //index = index + 1;
              // index++;
          // }

          void FillArray(int[] collection)
          {
              int length = collection.Length;
              int index = 0;
              while (index < length)
              {
                  collection[index] = new Random().Next(1, 10);
                  //index = index + 1;
                  index ++;
              }
          }
          
          void PrintArray(int[] col)
          {
              int count = col.Length;
              int position = 0;
              while (position < count)
              {
                  Console.WriteLine(col[position]);
                  position++;
              }
          }
          
          int IndexOf(int[] collection, int find)
          {
              int count = collection.Length;
              int index = 0;
              int position = -1;

              while (index < count)
              {
                  if (collection[index] == find)
                  {
                      position = index;
                      break;
                  }
                  index++;
              }
              return position;
          }

          int[] array = new int[10];

          FillArray(array);
          array[4] = 4;
          array[6] = 4;
          PrintArray(array);
          Console.WriteLine();

          int pos = IndexOf(array, 44);
          Console.WriteLine(pos);




        }
    }
}
