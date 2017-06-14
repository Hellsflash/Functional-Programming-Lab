using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            text.Where(checker)
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
