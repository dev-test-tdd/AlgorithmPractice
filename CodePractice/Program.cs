using System;
using System.Linq;

namespace CodePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string");
            var sourceString = Console.ReadLine();
            var result = IsPalindrome3(sourceString);

            if(result)
            {
                Console.WriteLine("The given string " + sourceString + " is a palindrome");
            }
            else
            {
                Console.WriteLine("The given string " + sourceString + " is not a palindrome");
            }
            Console.ReadLine();
        }

        #region Palindrome
        public static bool IsPalindrome1(string sourceString)
        {
            int len = sourceString.Length;
            return sourceString.Take(len / 2).All(o => o == sourceString[--len]);
            ////int i = 0;
            ////int j = sourceString.Length - 1;

            ////while(i<j)
            ////{
            ////    if(sourceString[i] != sourceString[j])
            ////    {
            ////        return false;
            ////    }
            ////    i++;
            ////    j--;
            ////}
            //return true;
        }

        public static bool IsPalindrome2(string source)
        {
            var first = source.Substring(0, source.Length / 2);
            char[] arr = source.ToCharArray();
            Array.Reverse(arr);
            var temp = new string(arr);
            var second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);   
        }

        public static bool IsPalindrome3(string source)
        {
            int min = 0;
            int max = source.Length - 1;
            while(true)
            {
                if(min > max)
                {
                    return true;
                }
                char a = source[min];
                char b = source[max];

                if(char.ToLower(a)!= char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }    
           
        }

        public static bool IsPalindrome4(string source)
        {
            var characterPairs = source.Zip(source.Reverse(), (l, r) => l == r);
            return characterPairs.Take(source.Length / 2).All(isMatch => isMatch);
        }

        public static bool IsPalindromeRecursive(string source)
        {
            int length = source.Length - 1;
            return source[0] == source[length] && 
                (length <= 1 || IsPalindromeRecursive(source.Substring(1, length)));
          
        }
        #endregion

        public static string RemoveCharacter(string source, string character)
        {
            //int index1 = source.IndexOf(character[0]);
            //string result = string.Empty;
            //if(index1 != -1)
            //{
            //    result = source.Remove(index1, 1);
            //}

            //return result;

            var result = source.Replace("s", " ");
            return result;
        }

    }


}
