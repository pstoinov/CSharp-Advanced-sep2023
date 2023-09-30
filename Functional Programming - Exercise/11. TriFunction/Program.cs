

using System.IO.Pipes;

Func<string, int, bool> checkEqualOrLargerNameSum = (name, sum) => name.Sum(ch => ch) >= sum;

Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match ) => names.FirstOrDefault(name => match(name, sum)) ;