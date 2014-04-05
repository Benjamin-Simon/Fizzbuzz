using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dataToDisplay = Enumerable.Range(1, 100);

            Console.WriteLine(new FbProceeder().GetCombinedResult(dataToDisplay));
        }
    }
}
