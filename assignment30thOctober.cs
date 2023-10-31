using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment30thOctober
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=0, i, j ,k ;
            

            do
            {                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. To find the balanced index number");
                Console.WriteLine("2. To find the leaders in an array");
                Console.WriteLine("3. Lazy Person's Switch action");
                Console.WriteLine("4. To find maximum subarray in an array");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter desired length of array: ");
                        int length = Convert.ToInt32(Console.ReadLine());

                        int[] integerArray = new int[length];
                        Console.Write("Input array elements: ");

                        for (i = 0; i < integerArray.Length; i++)
                        {
                            integerArray[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("Input Array is: ");
                        for (i = 0; i < integerArray.Length; i++)
                        {
                            Console.Write(integerArray[i] + " ");
                        }
                        Console.WriteLine();

                        for (i = 0; i < integerArray.Length; i++)
                        {
                            int leftSum = 0;
                            int rightSum = 0;
                            for (j = 0; j<i; j++)
                            {
                                leftSum += integerArray[j];
                            }
                            for(k=integerArray.Length-1; k>i; k--)
                            {
                                rightSum += integerArray[k];
                            }
                            if(leftSum == rightSum)
                            {
                                Console.WriteLine(i + " is a balanced index.");
                                break;
                            }
                        }
                        if(i == integerArray.Length)
                        {
                            Console.WriteLine("There are no balanced indices");
                        }
                        break;


                    case 2:
                        Console.WriteLine("Enter desired length of array: ");
                        int length2 = Convert.ToInt32(Console.ReadLine());

                        int[] integerArray2 = new int[length2];
                        Console.Write("Input array elements: ");

                        for (i = 0; i < integerArray2.Length; i++)
                        {
                            integerArray2[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("Input Array is: ");
                        for (i = 0; i < integerArray2.Length; i++)
                        {
                            Console.Write(integerArray2[i] + " ");
                        }
                        Console.WriteLine();

                        int count = 0;
                        int max = Int32.MinValue;
                        for(i = integerArray2.Length-1; i>=0; i--)
                        {
                            if(integerArray2[i] > max)
                            {
                                max = integerArray2[i];
                                count++;
                            }
                        }
                        Console.WriteLine("There are " + count + " leaders in the array");
                        break;

                    case 3:
                        Console.Write("Enter desired number of switches: ");
                        int length3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        int[] integerArray3 = new int[length3];
                        Console.Write("Input array elements(0s and 1s only): ");

                        for (i = 0; i < integerArray3.Length; i++)
                        {
                            integerArray3[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("Input Array is: ");
                        for (i = 0; i < integerArray3.Length; i++)
                        {
                            Console.Write(integerArray3[i] + " ");
                        }
                        Console.WriteLine();

                        int count3 = 0;
                        for(i=0; i<integerArray3.Length; i++)
                        {
                            if(integerArray3[i] == 0)
                            {
                                count3++;
                                integerArray3[i] = 1;
                                for(j=i+1; j<integerArray3.Length; j++)
                                {
                                    integerArray3[j] = Math.Abs(integerArray3[j] - 1);
                                }
                            }
                        }
                        Console.WriteLine(count3 + " switches needed to make every switch on");
                        break;



                    case 4:
                        Console.WriteLine("Enter desired length of array: ");
                        int length4 = Convert.ToInt32(Console.ReadLine());

                        int[] integerArray4 = new int[length4];
                        Console.Write("Input array elements: ");

                        for (i = 0; i < integerArray4.Length; i++)
                        {
                            integerArray4[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("Input Array is: ");
                        for (i = 0; i < integerArray4.Length; i++)
                        {
                            Console.Write(integerArray4[i] + " ");
                        }
                        Console.WriteLine();


                        int maxSum = Int32.MinValue;
                        for(i=0; i<integerArray4.Length; i++)
                        {
                            int currentSum = 0;
                            for(j=i; j<integerArray4.Length; j++)
                            {
                                currentSum += integerArray4[j];
                                if(currentSum > maxSum)
                                {
                                    maxSum = currentSum;
                                }
                            }
                        }
                        Console.WriteLine(maxSum + " is the sum from contigous array which gives maximum sum");
                        break;

                    case 5:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Please enter valid input");
                        break;
                }
            } while (choice != 5);
        }
    }
}