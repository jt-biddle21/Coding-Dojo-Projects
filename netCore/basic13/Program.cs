using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-255
            // for (int i = 0; i < 256; i++)
            // {
            //     Console.WriteLine(i);
            // }
            //
            //
            // 1-255 odd
            // for (int i = 0; i < 256; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            //
            //
            // Print Sum
            // int sum = 0;
            // for (int i = 0; i < 11; i++)
            // {
            //     sum = sum + i;
            //     // Console.Writeline(sum);
            //     // Console.WriteLine(i);
            //     Console.WriteLine("New Number:" + " " + i + " " + "Sum:" + " " + sum);
            // }
            //
            //
            // Iterate Though Array
            // int [] iterateArray = {1, 3, 5, 7, 9, 13};
            // for (int i = 0; i < iterateArray.Length; i++)
            // {
            //     Console.WriteLine(iterateArray[i]);
            // }
            //
            //
            // Find Max
            // int [] maxArray = {3, -5, 20, 5};
            // int max = maxArray[0];
            // for (int i = 0; i < maxArray.Length; i++)
            // {
            //     if (max < maxArray[i])
            //     {
            //         max = maxArray[i];
            //     }
            // }
            // Console.WriteLine(max);
            //
            //
            // Get Average
            // int [] averageArray = {1, 5, 6, 3, 2, 8, 75};
            // int sum = 0;
            // int average = 0;
            // for (int i = 0; i < averageArray.Length; i++)
            // {
            //     sum = sum + averageArray[i];
            //     average = sum / averageArray.Length;
            // }
            // Console.WriteLine(average);
            //
            //
            // Array with Odds
            // List<int> oddList = new List<int>();
            // for (int i = 0; i < 256; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         oddList.Add(i);
            //     }
            // }
            // oddList.ToArray();
            // Console.WriteLine(oddList);
            //
            //
            // Greater than Y
            // int [] greaterArray = {1, 3, 5, 7};
            // int y = 3;
            // int counter = 0;
            // for (int i = 0; i < greaterArray.Length; i++)
            // {
            //     if (greaterArray[i] > y)
            //     {
            //         counter = counter + 1;
            //     }
            // }
            // Console.WriteLine(counter);
            //
            //
            // Square the Values
            // int [] sqArray = {1, 5, 10, -1};
            // for (int i = 0; i < sqArray.Length; i++)
            // {
            //     sqArray[i] = sqArray[i] * sqArray[i];
            // }
            // Console.WriteLine(string.Join(", ", sqArray));
            //
            //
            // Eliminate Negative
            // int[] negativeArray = {1, 5, 10, -2};
            // for (int i = 0; i < negativeArray.Length; i++)
            // {
            //     if (negativeArray[i] < 0)
            //     {
            //         negativeArray[i] = 0;
            //     }
            // }
            // Console.WriteLine(string.Join("<>", negativeArray));
            //
            //
            // Min, Max, Average
            // int[] Array = {1, 5, 10, -2};
            // int max = Array[0];
            // int min = Array[0];
            // int average = 0;
            // int sum = 0;
            // for (int i = 0; i < Array.Length; i++)
            // {
            //     if (max < Array[i])
            //     {
            //         max = Array[i];
            //     }
            //     if (min > Array[i])
            //     {
            //         min = Array[i];
            //     }
            //     sum = sum + Array[i];
            //     average = sum / Array.Length;
            // }
            // Console.WriteLine(max);
            // Console.WriteLine(min);
            // Console.WriteLine(average);
            //
            //
            // Shifting Values
            // int[] shiftArray = {1, 5, 10, 7, -2};
            // for (int i = 0; i < shiftArray.Length - 1; i++)
            // {
            //     shiftArray[i] = shiftArray[i + 1];
            // }
            // shiftArray[shiftArray.Length - 1] = 0;
            // Console.WriteLine(string.Join("<>", shiftArray));
            //
            //
            // Number to String
            // object[] numtoString = {-1, -3, 2};
            // for(int i = 0; i < numtoString.Length; i++) {
            //     if((int)numtoString[i] < 0) {
            //         numtoString[i] = "Dojo";
            //     }
            // }
            // Console.WriteLine(String.Join("<>", numtoString));
        }
    }
}
