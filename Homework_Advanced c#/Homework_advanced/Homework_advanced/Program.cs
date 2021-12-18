using System;
using System.Linq;

namespace Homework_advanced
{
    class Program
    {
        public static int squareDigits(int n)
        {
            string numbers = "";
            foreach(char s in n.ToString())
            {
                int i = Int32.Parse(s.ToString());
                double result = Math.Pow(i, 2);
                numbers += Convert.ToString(result);
            }
            return Convert.ToInt32(numbers);
  
        }

        public static int DescendingOrder(int num)
        {
            int n = Math.Abs(num);
            int l = ((int)Math.Log10(n > 0 ? n : 1)) + 1;
            int[] array = new int[l];
            for(int i =0; i < l; i++)
            {
                array[(l - i) - 1] = n % 10;
                n /= 10;

            }
            if(num < 0)
            {
                array[0] *= 1;                      
            }
            Array.Sort(array);
            Array.Reverse(array);
            int h = 0;
            for(int i =0; i<array.Length; i++)
            {
                int index = array.Length - i - 1;
                h += ((int)Math.Pow(10, index)) * array[i];
            }
            return h;
            

        }
        public static bool IsPangram(string str)
        {
            return str.ToLower().Where(ch => char.IsLetter(ch)).GroupBy(ch => ch).Count() ==26;
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(x => x).Take(2).Sum();
        }

        public static int GetVowelCount(string str)
        {
            int result =0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            result = str.Count(x => vowels.Contains(x));
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(squareDigits(9119));

            Console.WriteLine( DescendingOrder(42145));
            Console.WriteLine( DescendingOrder(145263));
            Console.WriteLine(DescendingOrder(123456789));
         
            string str= ("The quick brown fox jumps over the lazy dog");
            Console.WriteLine("{0} :\"{1}\"", IsPangram(str), str);

            int[] array = { 19, 5, 42, 2, 77 };
            int[] array2 = { 10,343445353, 3453445, 345354533 };
            Console.WriteLine(sumTwoSmallestNumbers(array));
            Console.WriteLine(sumTwoSmallestNumbers(array2));

            Console.WriteLine("Enter sentance to count the vowels:");
            string sentance = Console.ReadLine();
            Console.WriteLine("Number of vowels : ");
            Console.Write(GetVowelCount(sentance));



            Console.ReadLine();
        }
    }
}
