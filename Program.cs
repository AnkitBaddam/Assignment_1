using System;
using System.Linq;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is :{0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is :{0}", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();
        }
        private static string RemoveVowels(string s)
        {
            try
            {
                int len = s.Length;
                if (len > 10000)// Given Contraint
                {
                    Console.WriteLine("Lenght of input string should be less than " + len);
                }
                String final_string = "";
                //looking for character a in the given string ,replacing the vowels in them in "final_string".
                foreach (char a in s)
                {
                    if (a != 'a' & a != 'e' & a != 'i' & a != 'o' & a != 'u' & a != 'A' & a != 'E' & a != 'I' & a != 'O' & a != 'U')
                    {
                        final_string = final_string + a;
                    }
                }

                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                //using the function join to Concatenate the strings in an array without any space and comparing those arrays.
                if (string.Join("", bulls_string1) == string.Join("", bulls_string2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int S = 0; // Sum variable
                int L = bull_bucks.Length; //length of array
                if (L < 1 || L > 100) // Constraint check for Length
                {
                    System.Environment.Exit(1);
                }

                //using foreach to choose each integer in the array.
                foreach (int a in bull_bucks)
                {
                    if(a < 1 || a > 100) //Constraint check for values
                    {
                        System.Environment.Exit(1);
                    }
                    int count = 0;
                    //for loop inside foreach to compare the integers and overwriting the value of "count" if they are equal.
                    for (int i = 0; i < L; i++)
                    {
                        if (a == bull_bucks[i]) // Checking for the unique values and adding them to count  
                        {
                            count = count + 1;
                        }
                    }
                    //"count" will be 1 when the integers are not same.

                    if (count == 1)
                    {
                        S = S + a;
                    }
                }
                return S;

            }
            catch (Exception)
            {
                throw;
            }
        }
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int k = bulls_grid.Length;
                //sqaure root of total length of array will be the matrix
                int n = Convert.ToInt32(Math.Sqrt(k));
                int sum = 0; //Initialising the sum to zero
                //
                for (int i = 0; i < n; i++)
                {
                    sum = sum + bulls_grid[i, i] + bulls_grid[i, n - i - 1]; //Calculating the sum of the diagonal elements
                }
                if (n % 2 != 0)
                {
                    return sum - bulls_grid[(n - 1) / 2, (n - 1) / 2];
                }
                else
                {
                    return sum;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                int len = indices.Length;
                if (len > 100)//user defined constraints
                {
                    Console.WriteLine("Lenght of input string should be less than " + len);
                }
                if (bulls_string.Length != indices.Length)//user defined condition
                {
                    Console.WriteLine("Indices length and bull_string length are not same");
                }
                if (bulls_string.Any(char.IsUpper))//user defined exceptions
                {
                    Console.WriteLine("Input string contains Upper case letter");
                }
                if (indices.Distinct().Count() != indices.Length)//user defined exceptions
                {
                    Console.WriteLine("All the values in indices array should be unique");
                }
                foreach (int i in indices)
                {
                    if (i > bulls_string.Length)
                    {
                        Console.WriteLine("Value in indices is exceeding the number of characters in the string");
                    }
                }
                string[] x = new string[bulls_string.Length];
                string z = "";
                //considering the integers of indices array and using them as index values and comparing them with "bulls_string"
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    int y = indices[i];
                    x[y] = Convert.ToString(bulls_string[i]);
                }
                // Converting the array to string and returnig it
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    z = z + x[i];
                }
                return z;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                int len = bulls_string6.Length;
                if (bulls_string6.Any(char.IsUpper))//user defined Constraint
                {
                    Console.WriteLine("Input string contains Upper case letter");
                }
                if (len > 250)//user defined exceptions
                {
                    Console.WriteLine("Lenght of input string should be less than " + len);
                }
                string[] x = new string[bulls_string6.Length];
                //splitting the given string using for loop and if loop.
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if (bulls_string6[i] == ch)
                    {
                        x = bulls_string6.Split(ch);
                    }
                }
                string y = "";
                // using the loop and storing in the reverse in string "y"
                for (int j = x[0].Length - 1; j >= 0; j--)
                {
                    y = y + bulls_string6[j];
                }
                //joining likewise to get the output
                string prefix_string = ch + y + x[1];
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}