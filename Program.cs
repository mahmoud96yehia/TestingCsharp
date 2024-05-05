

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stars();
            //Star2();
            // CalculateCentury();

            //FindTheLargestAndLowest();

            // LoopwithSummation();
            // DeclareAndPrintArrayElements();
            //  PersonHeightCategory();

            SeperateEvenAndOdd();
        }

         static void SeperateEvenAndOdd()
        {
            int[] array = new int[10]; // length of array 
         
            Console.WriteLine("Input 10 elements into the array : \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"element - {i} :");

                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();    

          //  oddNumbers.Add(newElement) ;
          //  oddNumbers.Remove(newElement);
          //for loop
          //pass over every element of the array
          // check if it's odd or even

        }

        static void DeclareAndPrintArrayElements()
        {

            int[] array = new int[10]; // length of array 
            //string[] students = new string[10]; // names of students
            Console.WriteLine("\n");
            Console.WriteLine("input and print element of array : \n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\n");
            // but array not dinamic
            Console.WriteLine("Input 10 elements into the array : \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"element - {i} :");

                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n Elements in the array are : ");

            for(int i = 0;i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }

        }

        static void PersonHeightCategory()
        {

            Console.WriteLine("\n");
            Console.WriteLine("Accept the height of a person in cm then categories him : \n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\n");

            //getting your height category
            Console.WriteLine("input your height (in centimeters) : ");
            int personHeightInCm = int.Parse(Console.ReadLine());

            if (personHeightInCm <= 150)
            {

                Console.WriteLine("Height category is Dwarf. \n \n ");
            }
            else if (personHeightInCm > 150 && personHeightInCm <= 165)
            {
                Console.WriteLine("Height category is average heighted");
            }
            else if (personHeightInCm > 165 && personHeightInCm <= 195)
            {
                Console.WriteLine("Height category is average heighted");
            }
            else
            {
                Console.WriteLine("abnormal Height Detected");
            }
        }

        static void LoopwithSummation()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Print the sum of first 10 natural numbers : \n");
            Console.WriteLine("--------------------------");

            int sum = 0;    
            // add 1+2+3+....10 = 55
            for (int i = 1; i <= 10; i++) { 
            
           sum += i; //sum = sum + i ;
                Console.WriteLine(i);
            }
            Console.WriteLine($"\n the sum is : {sum}");
        }

        static void Star2()
        {
            Console.Write("please enter the number you want: ");
            var starNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= starNumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

        static void CalculateCentury()
        {
            Console.WriteLine("Type The Year : ");
            int year = int.Parse(Console.ReadLine());
            int century = year / 100 + 1;
            Console.WriteLine($"The {year} Century is : {century}");

        }

        static void Stars()
        {
            Console.Write("Enter the number of rows for the triangle: ");
            int numRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Printing Triangle:");

            // Loop through each row
            for (int i = 1; i <= numRows; i++)
            {
                // Print spaces before the stars
                for (int j = 1; j <= numRows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars for the current row
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line after each row
                Console.WriteLine();
            }

            //  Console.ReadLine(); // To keep the console window open
        
    }

        static void FindTheLargestAndLowest()
        {
            Console.WriteLine("\nInput First Integer");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInput Second Integer");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput Third Integer");
            int z = Convert.ToInt32(Console.ReadLine());
            //to get max between 3 numbers
            Console.WriteLine($"Largest of two : {Math.Max(z,Math.Max(x,y))}");
            //to get min between 3 numbers
            Console.WriteLine($"Lowest of two : {Math.Min(z, Math.Min(x, y))}");

        }
    }
    }

