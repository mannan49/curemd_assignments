using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RemoveDuplicate();
            //LargestAndSecondLargest();
            ZerosAtEnd();
           
        }
     //Task#1 : Write a program to delete the duplicates from an array
        static void RemoveDuplicate()
        {

            int arraySize, currentIndex, nextIndex, shiftIndex;
            int[] arr = new int[50];

            Console.WriteLine("Enter the array size : ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Elements of Array: ");
            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                arr[currentIndex] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array: ");
            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                Console.WriteLine(arr[currentIndex]);
            }

            Console.WriteLine("Array After Removing Duplicate Elements: ");
            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                for (nextIndex = currentIndex + 1; nextIndex < arraySize;)
                {
                    if (arr[currentIndex] == arr[nextIndex])
                    {
                        for (shiftIndex = nextIndex; shiftIndex < arraySize - 1; shiftIndex++)
                        {
                            arr[shiftIndex] = arr[shiftIndex + 1];
                        }
                        arraySize--;
                    }
                    else
                    {
                        nextIndex++;
                    }
                }
            }

            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                Console.WriteLine(arr[currentIndex]);
            }

            Console.ReadLine();
        }
    //Task#2 : Write a program to find the largest and the second largest number in an array.
     static void LargestAndSecondLargest()
    {
            int arraySize, index, max1, max2;
            int[] arr = new int[50];

            Console.WriteLine("Enter the Size of Array : ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Elements of Array : ");
            for (index = 0; index < arraySize; index++)
            {
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }

            max1 = max2 = int.MinValue;
            for(index = 0; index < arraySize; index++)
            {
                if(arr[index] > max1)
                {
                    max2 = max1;
                    max1 = arr[index];
                }
                else if(arr[index] > max2)
                {
                    max2 = arr[index];
                }
            }
            Console.WriteLine("First Largest Number= " +  max1);
            Console.WriteLine("Second Largest Number= " +  max2);
            
            ////

            Console.ReadLine();
    }
        static void ZerosAtEnd()
        {
            int[] arr = { 3, 2, 0, 4, 0, 8, 5 };
            int cnt = 0; // Counter for non-zero elements

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[cnt] = arr[i];
                    cnt++;
                }
            }

            // Now all non-zero elements have been shifted to the front
            // Fill remaining elements with zero
            while (cnt < arr.Length)
            {
                arr[cnt] = 0;
                cnt++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
