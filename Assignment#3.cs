using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicate();
            LargestAndSecondLargest();
            ZerosAtEnd();
            FirstNonRepeatingChar();
            SingleSortedArray();
            MissingNumberInArray();
            ArmstrongNumber();
            LargestCommonPrefix();
            FibonacciSequence();
            PositiveNegativeAverage();


        }

        //Task#10: Write a program that reads N integers, determines how many positive and negative values have been read and computes the total and average of input values.
        static void PositiveNegativeAverage()
        {
            // Prompt user for the number of integers (N)
            Console.Write("Enter the number of integers (N): ");
            int numIntegers = Convert.ToInt32(Console.ReadLine());

            // Validate input for N (must be positive)
            if (numIntegers <= 0)
            {
                Console.WriteLine("Number of integers must be positive.");
                return;
            }

            // Array to store N integers
            int[] numbers = new int[numIntegers];

            // Initialize counters and sum variables
            int positiveCount = 0, negativeCount = 0;
            int totalSum = 0;

            // Read integers and compute statistics
            for (int i = 0; i < numIntegers; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                // Count positive and negative numbers
                if (numbers[i] > 0)
                    positiveCount++;
                else if (numbers[i] < 0)
                    negativeCount++;

                // Calculate total sum
                totalSum += numbers[i];
            }

            // Calculate average (use double for precision)
            double average = (double)totalSum / numIntegers;

            // Output results
            Console.WriteLine("\nPositive Numbers: " + positiveCount);
            Console.WriteLine("Negative Numbers: " + negativeCount);
            Console.WriteLine("Total sum: " + totalSum);
            Console.WriteLine($"Average: {average:F2}");
        }

        //Task#9: Write a program that prints the Fibonacci sequence up to n terms (where n is user input).
        static void FibonacciSequence()
        {
            // Read input size
            Console.Write("Enter the number of terms in the Fibonacci sequence: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (size <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }

            // Array to store Fibonacci sequence
            int[] fibonum = new int[size];

            // Handle base cases
            if (size >= 1)
                fibonum[0] = 0;
            if (size >= 2)
                fibonum[1] = 1;

            // Compute Fibonacci sequence
            for (int i = 2; i < size; i++)
            {
                fibonum[i] = fibonum[i - 1] + fibonum[i - 2];
            }

            // Output the Fibonacci sequence
            Console.WriteLine("\nFibonacci Sequence:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(fibonum[i]);
                if (i < size - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        // Task#8 : Write a program to find the longest common prefix in an array of strings.
        static void LargestCommonPrefix()
        {
            // Input strings
            Console.WriteLine("Enter the number of strings:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter string {i + 1}: ");
                strings[i] = Console.ReadLine();
            }

            // Find the shortest string in the array
            string shortest = strings[0];
            foreach (string str in strings)
            {
                if (str.Length < shortest.Length)
                {
                    shortest = str;
                }
            }

            // Initialize variables
            int prefixLength = shortest.Length;
            bool match = true;

            // Compare characters across all strings
            for (int i = 0; i < prefixLength; i++)
            {
                char currentChar = shortest[i];
                for (int j = 0; j < n; j++)
                {
                    if (strings[j][i] != currentChar)
                    {
                        match = false;
                        break;
                    }
                }
                if (!match)
                {
                    prefixLength = i;
                    break;
                }
            }

            // Output the longest common prefix
            string longestCommonPrefix = shortest.Substring(0, prefixLength);
            Console.WriteLine($"The longest common prefix is: {longestCommonPrefix}");
        }

        //Task#7: Write a program to check whether a number is Armstrong number or not.
        static void ArmstrongNumber()
        {
            // Read input number
            Console.Write("Enter a number to check if it is an Armstrong number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if number is Armstrong
            bool isArmstrong = IsArmstrong(number);

            // Output the result
            if (isArmstrong)
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }

        // Function to check if a number is Armstrong
        static bool IsArmstrong(int num)
        {
            int originalNumber = num;
            int numDigits = num.ToString().Length;
            int sum = 0;

            // Calculate sum of digits raised to the power of numDigits
            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, numDigits);
                num /= 10;
            }

            // Check if sum equals the original number
            return sum == originalNumber;
        }

        // Task#6: Write a program to find the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n. 
        static void MissingNumberInArray()
        {
            // Read and convert input into integer array
            Console.Write("Enter array elements separated by spaces: ");
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] intArray = Array.ConvertAll(inputArray, int.Parse);

            // Find the missing number
            int missingNumber = FindMissingNumber(intArray);

            // Output the missing number
            Console.WriteLine($"\nMissing number is: {missingNumber}");
        }

        // Function to find the missing number in an array of distinct numbers
        static int FindMissingNumber(int[] nums)
        {
            int n = nums.Length; // Length of the array
            int expectedSum = (n * (n + 1)) / 2; // Sum of first n natural numbers
            int actualSum = 0;

            // Calculate actual sum of elements in the array
            foreach (int num in nums)
            {
                actualSum += num;
            }

            // The missing number is the difference between expected and actual sums
            int missingNumber = expectedSum - actualSum;

            return missingNumber;
        }

        // Task#5: Write a program to merge two sorted arrays into a single sorted array.
        static void SingleSortedArray()
        {
            // Read and convert first sorted array
            Console.Write("Enter first sorted array (space-separated integers): ");
            string[] firstArrayStr = Console.ReadLine().Split(' ');
            int[] firstArray = Array.ConvertAll(firstArrayStr, int.Parse);

            // Read and convert second sorted array
            Console.Write("Enter second sorted array (space-separated integers): ");
            string[] secondArrayStr = Console.ReadLine().Split(' ');
            int[] secondArray = Array.ConvertAll(secondArrayStr, int.Parse);

            // Calculate the size of the final merged array
            int finalSize = firstArray.Length + secondArray.Length;
            int[] mergedArray = new int[finalSize];

            // Merge the two sorted arrays into a single sorted array
            MergeSortedArrays(firstArray, secondArray, mergedArray);

            // Print the merged and sorted array
            Console.WriteLine("\nMerged and Sorted Array:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Function to merge two sorted arrays into a single sorted array
        static void MergeSortedArrays(int[] arr1, int[] arr2, int[] result)
        {
            int i = 0, j = 0, k = 0;

            // Traverse both arrays and compare elements
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                }
                else
                {
                    result[k] = arr2[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements of first array, if any
            while (i < arr1.Length)
            {
                result[k] = arr1[i];
                i++;
                k++;
            }

            // Copy remaining elements of second array, if any
            while (j < arr2.Length)
            {
                result[k] = arr2[j];
                j++;
                k++;
            }
        }

        //Task#4: Write a program to find the first non-repeating character in a string.
        static void FirstNonRepeatingChar()
        {
            Console.Write("Enter a string to find the first non-repeating character: ");
            string input = Console.ReadLine();

            char firstNonRepeatingChar = FindFirstNonRepeatingChar(input);

            if (firstNonRepeatingChar != '\0')
            {
                Console.WriteLine($"The first non-repeating character in \"{input}\" is '{firstNonRepeatingChar}'.");
            }
            else
            {
                Console.WriteLine("No non-repeating character found in the string.");
            }
        }

        // Function to find the first non-repeating character in a string
        static char FindFirstNonRepeatingChar(string input)
        {
            // Dictionary to store character frequencies
            Dictionary<char, int> charFrequencies = new Dictionary<char, int>();

            // Populate the dictionary with character frequencies
            foreach (char c in input)
            {
                if (charFrequencies.ContainsKey(c))
                {
                    charFrequencies[c]++;
                }
                else
                {
                    charFrequencies[c] = 1;
                }
            }

            // Find the first character with frequency 1 (non-repeating)
            foreach (char c in input)
            {
                if (charFrequencies[c] == 1)
                {
                    return c; // Found the first non-repeating character
                }
            }

            return '\0'; // Return null character if no non-repeating character found
        }

        //Task#3: Write a program that places all the zeros in an array at the end of the list.
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
            for (index = 0; index < arraySize; index++)
            {
                if (arr[index] > max1)
                {
                    max2 = max1;
                    max1 = arr[index];
                }
                else if (arr[index] > max2)
                {
                    max2 = arr[index];
                }
            }
            Console.WriteLine("First Largest Number= " + max1);
            Console.WriteLine("Second Largest Number= " + max2);

           

            Console.ReadLine();
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
    }

}
