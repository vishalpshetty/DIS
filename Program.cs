using System;
using System.Linq;
namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Executing the 1st method: \n");
            Console.WriteLine("printing the Pattern: \n");
            PrintPattern(n);
            Console.WriteLine();

            int n2 = 6;
            Console.WriteLine("Executing the 2rd method: \n");
            Console.WriteLine("printing the series for a given input: \n");
            PrintSeries(n2);
            Console.WriteLine();

            string s = "11:15:35PM";
            string t = UsfTime(s);
            Console.Write("\nExecuting the 3rd method: \n");
            Console.Write(t);

            int n3 = 110;
            int k = 11;
            Console.WriteLine();
            Console.WriteLine("\nExecuting the 4th method: \n");
            Console.Write("printing the pattern: \n");
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            Console.WriteLine();
            Console.WriteLine("Executing the 5th method: \n");
            Console.WriteLine("indices of the words which are palindromes: \n");
            PalindromePairs(words);

            int n4 = 15;
            Console.WriteLine();
            Console.Write("Executing the 6th method: \n");
            Console.Write("Printing the moves: \n");
            Stones(n4);
        }
        //first
        private static void PrintPattern(int n)
        {
            try
            {
                if (n >= 0)
                {
                    for (int j = n; j >= 1; j--) // Running the for loop from j=n until j become zero
                    {
                        Console.Write(j + " "); //Printing the value of j
                    }
                    Console.WriteLine(" "); 
                    PrintPattern(n - 1); //calling the function recurrsively with value of n less than one
                }
                else 
                {
                    //do nothing
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }
        //second
        private static void PrintSeries(int n2)
        {
            try
            {
                int i, j = 1, k = 1;
                for (i = 1; i <= n2; i++) // For loop to run from 1 to the input number.
                {
                    Console.Write(j + " "); // will print the value of j
                    k = k + 1; // this will add 1 to the value of k.
                    j = j + k; // the temp variable is initialized with 1, and adding k to j.
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }
        //Third
        public static string UsfTime(string s)
        {
            try
            {
                int U_time, earth_time, difference, U_hour, S_minutes, F_seconds;
                int  k= 60*45; //seconds for one hour on usf time
                string[] array_1 = s.Split(':'); //splitting the input string by delimiter ':'
                string str = new String(array_1[2].Where(Char.IsDigit).ToArray()); //separating the PM in the string
                string time;
                if (s.Contains("PM")) //block will execute if the string contains PM
                {
                    U_time = (Convert.ToInt32(array_1[0]) + 12) * 60 * 45 + (Convert.ToInt32(array_1[1])) * 45 + (Convert.ToInt32(str)); //converting the U_time into seconds
                    earth_time = (Convert.ToInt32(array_1[0]) + 12) * 60 * 60 + (Convert.ToInt32(array_1[1])) * 60 + Convert.ToInt32(str); //converting the earth time into seconds
                    difference = earth_time - U_time; //calculating the difference in seconds between earth and usf times
                    U_hour = (Convert.ToInt32(array_1[0]) + 12) + (difference / k);// adding the hours to earth time to get usf time
                    S_minutes = (Convert.ToInt32(array_1[1])) + ((difference % k) / 45);//adding the minutes to earth time to get usf time
                    F_seconds = (Convert.ToInt32(str)) + ((difference % k) % 45);//adding the seconds to earth time to get usf time

                    if (S_minutes>=60) //if minutes value is greater than 60 it will be converted to hour
                    {
                        U_hour = U_hour + (S_minutes / 60);
                        S_minutes = S_minutes % 60;
                        time = U_hour + " : " + S_minutes + " : " + F_seconds;
                    }
                    else
                    {
                        time = U_hour + " : " + S_minutes + " : " + F_seconds;
                    }
                   

                }
                else //for AM calculations
                {
                    U_time = (Convert.ToInt32(array_1[0])) * 60 * 45 + (Convert.ToInt32(array_1[1])) * 45 + Convert.ToInt32(str);
                    earth_time = (Convert.ToInt32(array_1[0])) * 60 * 60 + (Convert.ToInt32(array_1[1])) * 60 + Convert.ToInt32(str);
                    difference = earth_time - U_time;
                    U_hour = (Convert.ToInt32(array_1[0])) + (difference / k);
                    S_minutes = (Convert.ToInt32(array_1[1])) + ((difference % k) / 45);
                    F_seconds = (Convert.ToInt32(str)) + ((difference % k) % 45);
                    if(S_minutes >= 60)
                    {
                        U_hour = U_hour + (S_minutes / 60);
                        S_minutes = S_minutes % 60;
                        time = U_hour + " : " + S_minutes + " : " + F_seconds;
                    }
                    else
                    {
                        time = U_hour + " : " + S_minutes + " : " + F_seconds;
                    }
                }
                return time;
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }
        //Fourth
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                
                for (int i = 1; i <= n3; i++) //incrementing for loop from one to input number
                {
                    
                    if (i % k != 0) //checking if the number is multiple of k
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                            Console.Write(" " + "US");
                        else if (i % 5 == 0 && i % 7 == 0)
                            Console.Write(" " + "SF");
                        else if (i % 3 == 0 && i % 7 == 0)
                            Console.Write(" " + "UF");
                        else if (i % 3 == 0)
                            Console.Write(" " + "U");
                        else if (i % 5 == 0)
                            Console.Write(" " + "S");
                        else if (i % 7 == 0)
                            Console.Write(" " + "F");
                        else
                            Console.Write(" " + i);
                    }
                    else //if the number is multiple of k then jump to next line
                        Console.Write(" " + i + "\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
        //Fifth
        public static void PalindromePairs(string[] words)
        {
            try
            {
                string k;
                for (int a = 0; a < words.Length; a++)//the two for loops are to be used for conccatenating
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        if (a != b) // avoiding concatenating with the word itself
                        {
                            k = words[a] + words[b];//concatenating the elements
                            string reversed_string = ""; 
                            for (int j = k.Length - 1; j >= 0; j--) // running for loop from reverse
                            {
                                reversed_string= reversed_string +k[j];// to store the reversed string
                            }
                            if (reversed_string == k)// checking if the reversed string equals the string and return the indices
                            {
                                Console.WriteLine(a +" "+ b);
                            }
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }
        //Sixth
        public static void Stones(int n4)
        {
            try
            {
                
                int k = n4 / 4; //dividing by 4 and saving quotient
                int j = k * 4; //step to calculate the number of moves
                int n = (j / 2) + 1; //step to calculate the total number of moves
                int move1;
                if (n4 % 4 != 0) //if the number is divisible by 4, there is no chance of winning
                {
                    move1 = n4 % 4;
                    Console.WriteLine(move1); //first move will be the reminder of number divided by 4
                    for (int i = 1; i <= n / 2; i++) //for loop from 1 to half of the total number of moves
                    {
                        Console.WriteLine('3'); //with 3 as his move in all chances we can compute the set moves for winning
                        Console.WriteLine('1'); //our moves
                    }
                }
                else
                {
                    Console.WriteLine(false); //write false
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing moves in the Stones()");
            }
        }
    }
}
