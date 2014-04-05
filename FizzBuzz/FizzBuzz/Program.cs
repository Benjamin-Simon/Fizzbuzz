using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Enumerable.Range(1, 100);
            var strBuilder = new StringBuilder();

            foreach(var item in collection)
            {
                strBuilder.Append(string.Format("{0} ", GetModifiedItem(item)));
            }

            Console.WriteLine(strBuilder);
        }

        static bool IsFizz(int number) 
        {
            return number % 3 == 0;
        }

        static bool IsBuzz(int number) 
        {
            return number % 5 == 0;
        }

        static bool IsFizzOrBuzz(int number) 
        {
            return IsFizz(number) || IsBuzz(number);
        }

        static bool IsFizzAndBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

        static string GetModifiedItem(int number) 
        {
            if (IsFizzOrBuzz(number))
            {
                if (IsFizzAndBuzz(number))
                {
                    return "FizzBuzz";
                }
                if (IsFizz(number))
                {
                    return "Fizz";
                }
                if (IsBuzz(number))
                {
                    return "Buzz";
                }
            }

            return number.ToString();
        }
    }
}
