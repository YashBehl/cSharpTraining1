using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment27thOctober
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What to do?");
                Console.WriteLine("1. To find if a number is a perfect number or not?");
                Console.WriteLine("2. To find the minimum gap to make the given number a perfect square");
                Console.WriteLine("3. To find pairs whose addition is less than a given number in input array.");
                Console.WriteLine("4. To find if the string number is magical or not?");
                Console.WriteLine("5. To remove multiple spaces from the string and make sure there is single space between all the words");
                Console.WriteLine("6. To find third largest value from array");
                Console.WriteLine("7. To find product array of an input array");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Input choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            
            


            switch(choice)
            {
                case 1:
                    int sum = 0;
                    Console.Write("Enter the input number: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    for (int a = 1; a <= number / 2; a++)
                    {
                        if (number % a == 0)
                        {
                            sum += a;
                        }
                    }
                    if (sum == number)
                        Console.WriteLine(number + " is a perfect number");
                    else
                        Console.WriteLine(number + " is not a perfect number");
                    break;



                case 2:
                    Console.Write("Enter the input number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int minGap = Int32.MaxValue;
                    if (number2 == 0 || number2 == 1)
                    {
                        minGap = 0;
                    }
                    else
                    {
                        for (int b = 1; b <= (number2 / 2) + 1; b++)
                        {
                            if (Math.Abs(number2 - (b * b)) < minGap)
                            {
                                minGap = Math.Abs(number2 - (b * b));
                            }
                        }
                    }
                    Console.WriteLine("The minimum gap to make " + number2 + " a perfect square is " + minGap);
                    break;



                case 3:
                    int[] integerArray = { 10, 12, -4, 0, 18, 11, 21 };
                    Console.Write("Array elements: ");
                    int sumOfPair = 0;
                    foreach (int x in integerArray)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine();
                    for (int c = 0; c < integerArray.Length; c++)
                    {
                        for (int j = 0; j < integerArray.Length; j++)
                        {
                            if (j == c)
                            {
                                continue;
                            }
                            sumOfPair = integerArray[c] + integerArray[j];
                            for (int k = 0; k < integerArray.Length; k++)
                            {
                                if (k == c || k == j)
                                {
                                    continue;
                                }
                                if (sumOfPair < integerArray[k])
                                {
                                    Console.WriteLine("(" + integerArray[c] + "," + integerArray[j] + ")" + " is a pair whose sum is less than a given number in array");
                                    break;
                                }

                            }
                        }
                    }
                    break;


                case 4:
                    Console.Write("Enter input string: ");
                    string stringNumber = Console.ReadLine();
                    long stringNumberAsInteger = long.Parse(stringNumber);
                    long sum4 = 0;
                    while (stringNumberAsInteger > 0 || sum4 > 9)
                     {
                        if (stringNumberAsInteger == 0)
                         {
                             stringNumberAsInteger = sum4;
                             sum4 = 0;
                         }
                            sum4 += stringNumberAsInteger % 10;
                            stringNumberAsInteger /= 10;
                     }

                    if (sum4 == 1)
                    {
                        Console.WriteLine(stringNumber + " is a magical number");
                    }
                    else
                    {
                        Console.WriteLine(stringNumber + " is not a magical number");
                    }
                    break;



                case 5:
                    Console.Write("Enter input string: ");
                    string inputString = Console.ReadLine();
                    StringBuilder outputString = new StringBuilder();
                        int i;
                    for(i=1; i<inputString.Length; i++)
                        {
                            if(inputString[i-1] != ' ' && inputString[i] != ' ')
                            {
                                outputString.Append(inputString[i]);
                            }
                        }
                        Console.WriteLine("Required string is: " + outputString);
                        break;

                case 6:
                    int[] integerArray6 = { 21, 40, 18, 40, 20, -5, 11, 80 };

                    int max = Int32.MinValue;
                    int secondMax = Int32.MinValue;
                    int thirdMax = Int32.MinValue;
                    for (int j = 0; j < integerArray6.Length; j++)
                    {
                        if (integerArray6[j] > max)
                        {
                            max = integerArray6[j];
                        }
                    }
                    for (int j = 0; j < integerArray6.Length; j++)
                    {
                        if ((integerArray6[j] > secondMax) && (integerArray6[j] < max))
                        {
                            secondMax = integerArray6[j];
                        }
                    }
                    for (int j = 0; j < integerArray6.Length; j++)
                    {
                        if ((integerArray6[j] > thirdMax) && (integerArray6[j] < secondMax))
                        {
                            thirdMax = integerArray6[j];
                        }
                    }
                    Console.WriteLine("Third largest element is " + thirdMax);
                    break;


                case 7:
                    int[] integerArray7 = { 21, 40, 18, 40, 20, 5, 11, 80 };
                    Console.WriteLine("Input array is: ");
                    
                    for (i = 0; i < integerArray7.Length; i++)
                    {
                        Console.Write(integerArray7[i] + " ");
                    }
                    Console.WriteLine();
                    int[] productArray = new int[integerArray7.Length];

                    for (int k = 0; k < productArray.Length; k++)
                    {
                        productArray[k] = 1;
                    }

                    for (i = 0; i < integerArray7.Length; i++)
                    {
                        for (int j = 0; j < integerArray7.Length; j++)
                        {
                            if (j == i)
                            {
                                continue;
                            }
                            productArray[i] = productArray[i]*integerArray7[j];
                        }
                    }

                    Console.WriteLine("Product Array is :");
                    for (i = 0; i < productArray.Length; i++)
                    {
                        Console.Write(productArray[i] + " ");
                    }
                    break;

                case 8:
                        Environment.Exit(1);
                        break;

                default:
                    Console.WriteLine("Please enter valid input.");
                    break;
            }
            } while (choice != 8);

            
            Console.ReadKey();
        }
    }
}
