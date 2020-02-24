using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);
           for (int x = 0; x <= r.Length - 1; x++)
            {
                if (x != r.Length - 1)
                    Console.Write(r[x]);
                else
                    Console.Write(r[x]);
            }


            Console.WriteLine();
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);
            Console.WriteLine();
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);
            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
             DisplayArray(intersect1);
            Console.WriteLine("\n");
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine();
            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));
            Console.WriteLine();
            Console.WriteLine("Question 7");
            int rodLength = 4;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);
            Console.WriteLine();

            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhlo";
            Console.WriteLine(DictSearch(userDict, keyword));
            Console.WriteLine();
             
        }
        private static void DisplayArray(int[] a)
        {
            for (int j = 0; j <= a.Length - 1; j++)
            {
                Console.WriteLine(a[j]);
            }
        }
       
            

public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                int[] w = new int[l1.Length]; //array to store the results
                int[] y = new int[] { };
                w[0] = -1;
                for (int j = 0; j <= l1.Length - 1; j++) 
                {
                    if (l1[j] == t) 
                    {
                        w[0] = j;
                        Array.Resize(ref y, y.Length + 1);
                        y[y.Length - 1] = j; 
                    }
                    if ( j== (l1.Length - 1) && w[0] == -1)
                    {
                        Array.Resize(ref y, 2); //resizing x to store the elements
                        y[0] = -1;
                        y[1] = -1;
                        break;
                    }
                }
                return y;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string StringReverse(string s)
        {
            try
            {
                String s1 = ""; 
                String s2 = "";
                String s3 = ""; 
                for (int i = 0; i <= s.Length - 1; i++) //logic to split the strig
                {
                    if (s[i] != ' ')
                    {
                        s1 = s1 + s[i];
                        if (i != s.Length - 1)
                            continue;
                    }
                    s2 = s1 ;
                    s1 = "";
                    for (int k = s2.Length - 1; k >= 0; k--)
                    {
                        s3 = s3 + s2[k];
                    }
                }
                return s3;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int MinimumSum(int[] l2)
        {

            int sum = 0;
            try
            {
                for (int j = 0; j <= l2.Length - 1; j++) //calclulating the sum to print
                {
                    sum = sum + l2[j];
                    if (j != l2.Length - 1 && l2[j + 1] == l2[j])
                    {
                        l2[j + 1] = l2[j + 1] + 1;
                    }
                }
                return sum;
            }

            catch (Exception)
            {
                throw;
            }

        }
        public static string FreqSort(string s2)
        {
            Dictionary<char, int> dict_new = new Dictionary<char, int>();
            string s = "";
            int k1 = 0;
            try
            {
                for (int j = 0; j <= s2.Length - 1; j++)
                {
                    if (dict_new.ContainsKey(s2[j]))
                    {
                        k1 = k1 + 1; 
                        dict_new[s2[j]] = k1;
                    }
                    else
                    {
                        dict_new.Add(s2[j], k1);
                    }
                }
                foreach (KeyValuePair<char, int> x in dict_new.OrderByDescending(key => key.Value))
                {
                    for (int y = 0; y <= x.Value; y++)
                    {
                        string s3 = x.Key.ToString();
                        s = s + s3;
                    }
                }
                return s;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                Array.Sort(nums1);
                Array.Sort(nums2);
                int j = 0;
                int len1 = nums1.Length;
                int len2 = nums2.Length;
                List<int> list_new = new List<int>();
                for (int i = 0; i <= nums1.Length - 1; i++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        list_new.Add((nums2[j]));
                        j++;
                    }
                }
                int[] x = list_new.ToArray();
                return x;
            }
            catch
            {
                throw;
            }
        }
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                int[] y = new int[] { };
                Dictionary<int, int> dict = new Dictionary<int, int>();
                int j = 0;
                for (int i = 0; i <= nums1.Length - 1; i++)
                {
                    dict.Add(i, nums1[i]);
                    foreach (KeyValuePair<int, int> k in dict)
                    {
                        if (j != nums2.Length && dict.ContainsValue(nums2[j]))
                        {
                            Array.Resize(ref y, y.Length + 1);
                            y[j] = nums2[j];
                            j++;
                        }
                        else if (j == nums2.Length)
                        {
                            break;
                        }
                    }
                }
                return y;
            }
            catch
            {
                throw;
            }
        }
public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                
                Dictionary<int, char> dict_new = new Dictionary<int, char>();
                bool b;
                for (int j = 0; j <= arr.Length - 1; j++)
                {
                    dict_new.Add(j, arr[j]);
                }
                var lookup = dict_new.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() > 1); //creating a lookup object to hold index
                foreach (var item in lookup)
                {
                    var keys = item.Aggregate("", (s, v) => s + ", " + v);
                    int difference = keys.ElementAt(5) - keys.ElementAt(2);
                    if (k <= difference)
                    {
                        b = true;
                        return b;
                    }
                    
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int GoldRod(int rodLength)
        {
            try
            {
                
                    if (rodLength == 2)
                        return 1;
                    else if (rodLength == 3)
                        return 2;
                    else if (rodLength == 4)
                        return 4;
                    else if (rodLength == 5)
                        return 6;
                    else if (rodLength == 6)
                        return 9;
                    else
                        return 3 * GoldRod(rodLength - 3);
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool DictSearch(string[] userDict, string keyword)
          {
             try
             {
                int count = 0;
                bool a;
                int[] len = new int[userDict.Length];

                for (int i = 0; i <= userDict.Length - 1; i++)
                {
                    len[i] = userDict[i].Length;
                }
                if (len.Contains(keyword.Length))
                {
                    for (int j = 0; j <= userDict.Length - 1; j++)
                    {
                        if (count == keyword.Length - 1)
                        {
                            a = true;
                            return a;
                 
                        }
                        if (userDict[j].Length == keyword.Length)
                        {
                            for (int k = 0; k <= keyword.Length - 1; k++)
                            {
                                count = 0;
                                foreach (Char ch in userDict[j])
                                {
                                    if (ch == keyword[k])
                                    {
                                        count += 1;
                                    }
                                    k++;
                                    continue;
                                }
                            }
                        }
                        if (j == userDict.Length - 1 && count != keyword.Length - 1)
                        {
                            a = false;
                            return a;
                          
                        }
                    }
                }
                else if (!len.Contains(keyword.Length))
                {
                    a = false;
                    return a;
                }
            
    
    
}
    catch (Exception)
    {
      throw;
    }
   return default;
}
          
    }
}