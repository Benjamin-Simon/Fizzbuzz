using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD
{
    public class FbProceeder
    {
        public bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        public bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        public bool IsFizzOrBuzz(int number)
        {
            return IsFizz(number) || IsBuzz(number);
        }

        public bool IsFizzAndBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

        public string GetCombinedResult(IEnumerable<int> collection)
        {
            var strBuilder = new StringBuilder();

            foreach (var item in collection)
            {
                strBuilder.Append(string.Format("{0} ", GetModifiedItem(item)));
            }

            return strBuilder.Remove(strBuilder.Length - 1, 1).ToString();
        }

        public string GetModifiedItem(int number)  //TODO: public because of tests
        {
            var strBuilder = new StringBuilder();

            if (IsFizzOrBuzz(number))
            {
                if (IsFizzAndBuzz(number))
                {
                    strBuilder = SbAppend(strBuilder, "FizzBuzz");
                }
                else if (IsFizz(number))
                {
                    strBuilder = SbAppend(strBuilder, "Fizz");
                }
                else if (IsBuzz(number))
                {
                    strBuilder = SbAppend(strBuilder, "Buzz");
                }
            }
            else
            {
                strBuilder = SbAppend(strBuilder, number.ToString());
            }

            return strBuilder.ToString();
        }

        private StringBuilder SbAppend(StringBuilder sb, string toAppend) 
        {
            if (sb.Length == 0)
            {
                sb.Append(toAppend);
            }

            return sb;
        }
    }
}
