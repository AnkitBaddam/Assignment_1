using System;

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
                String final_string = "";
                //searching for each charecter in the given string, eliminate the vowels and print the new string without the vowels
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
                int S = 0;
                int L = bull_bucks.Length;
                //using foreach to pick each integer in the array.
                foreach (int a in bull_bucks)
                {
                    int count = 0;
                    //for loop inside foreach to compare the integers and overwriting the value of "count" if they are equal.
                    for (int i = 0; i < L; i++)
                    {
                        if (a == bull_bucks[i])
                        {
                            count = count + 1;
                        }
                    }
                    //"count" value will be 1 when the integers are not equal. so sum of unique values from above forloop are added to "sum" and the final value is given.
                    if (count == 1)
                    {
                        S = S + a;
                    }
                }
                return sum;

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
                int sum = 0;
                //
                for (int i = 0; i < n; i++)
                {
                    sum = sum + bulls_grid[i, i] + bulls_grid[i, n - i - 1];
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
                string[] x = new string[bulls_string.Length];
                string z = "";
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    int y = indices[i];
                    x[y] = Convert.ToString(bulls_string[i]);
                }
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
                string[] x = new string[bulls_string6.Length];
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if (bulls_string6[i] == ch)
                    {
                        x = bulls_string6.Split(ch);
                    }
                }
                string y = "";
                for (int j = x[0].Length - 1; j >= 0; j--)
                {
                    y = y + bulls_string6[j];
                }
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
        }
    }
}
