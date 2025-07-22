using System.Collections.Generic;

public class Program
{
    // Traverse an Array
    public static void TraverseArray()
    {
        Console.WriteLine("Traverse an Array");
        int[] arr = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    //Change value at specific Index
    public static void ChangeValueAtSpecificIndices(int index, int changeValue)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        arr[index] = changeValue;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    //Print elements in reverse.
    public static void PrintReverseArray()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }

    //Find Max and Min
    public static void FindMaxMin()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        int min = arr[0];
        int max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("Max and Min are " + max + " ," + min);
    }

    //Sum and Avg
    public static void SumAndAvg()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        double avg = (double)sum / arr.Length;

        Console.WriteLine("Sum and Avg are " + sum + " ," + avg);
    }


    //Printing even and odd counts separately.

    public static void EvenOdd()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        int odd = 0;
        int even = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                even += 1;
            }
            else
            {
                odd += 1;
            }
        }

        Console.WriteLine("Odd and Even are " + odd + " ," + even);
    }

    //Accepting user input for n elements and storing in an array.

    public static void AcceptingAndStoring()
    {

        Console.Write("Enter 5 digit array");

        var arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("elements of array are ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ,");
        }
    }


    // Find max sum subarray of size k
    public static void MaxSumArray()
    {
        int[] arr = [2, 1, 5, 1, 3, 2];
        int k = 3;

        int slideSum = 0; //8
        int maxSum = 0;  //8

        for (int i = 0; i < k; i++)
        {
            slideSum += arr[i];
        }
        maxSum = slideSum;

        for (int i = k; i < arr.Length; i++)
        {

            slideSum = slideSum + arr[i] - arr[i - k];

            maxSum = Math.Max(slideSum, maxSum);

        }
        Console.WriteLine(maxSum + " is the max sum");
    }


    //Find the average of all subarrays of size k
    public static void AvgSumArray()
    {
        int[] arr = [1, 3, 2, 6, -1, 4, 1, 8, 2];
        int k = 5;

        int slideSum = 0; //8
        int maxSum = 0;  //8

        for (int i = 0; i < k; i++)
        {
            slideSum += arr[i];
        }
        maxSum = slideSum;
        Console.WriteLine((double)slideSum / k);
        for (int i = k; i < arr.Length; i++)
        {

            slideSum = slideSum + arr[i] - arr[i - k];

            Console.WriteLine((double)slideSum / k);

        }

    }

    // Minimum sum subarray of size k
    public static void MinSumArray()
    {

        int[] arr = [2, 1, 5, 1, 3, 2];
        int k = 3;

        int windowSum = 0;
        int minSum = 0;

        for (int i = 0; i < k; i++)
        {
            windowSum += arr[i];
        }
        minSum = windowSum;  // 8,8

        for (int i = k; i < arr.Length; i++)
        {

            windowSum = windowSum + arr[i] - arr[i - k];

            minSum = Math.Min(windowSum, minSum);

        }
        Console.WriteLine(minSum + " is min sum");

    }

    //  First negative integer in every window of size k
    public static void FirstNegativeInteger()
    {


        int[] arr = [12, -1, -7, -9, -15, -30, -16, -28];
        int k = 3;


        Queue<int> negatives = new Queue<int>();

        int start = 0;
        for (int end = 0; end < arr.Length; end++)
        {

            if (arr[end] < 0)
            {
                negatives.Enqueue(arr[end]);
            }

            if (end - start + 1 == k)
            {

                if (negatives.Count() > 0)
                {
                    Console.Write(negatives.Peek() + " ");
                }
                else
                {
                    Console.Write("0 ");
                }

                // Before sliding, remove the element going out of window from queue if it is negative
                if (negatives.Count > 0 && arr[start] == negatives.Peek())
                    negatives.Dequeue();

                start++;


            }

        }


    }
    public static void Main()
    {
        //TraverseArray();
        //ChangeValueAtSpecificIndices(2, 10);
        // PrintReverseArray();
        //FindMaxMin();
        //SumAndAvg();
        //EvenOdd();
        //AcceptingAndStoring();

        //MaxSumArray();
        //AvgSumArray();
        //MinSumArray();
        FirstNegativeInteger();
        Console.ReadLine();
    }
}
