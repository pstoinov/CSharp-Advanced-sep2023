using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            int diff = DateModifier.GetDifferenceInDays(start, end);
            Console.WriteLine(diff);
        }
    }
}