using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
  class FizzBuzz
  {
    readonly IList<string> result = new List<string>();
    public FizzBuzz()
    {
    }
    public IEnumerable<string> Calculate(int start, int end)
    {
      for (int i = 0; i < end; i++)
      {
        string value = "";
        if (i % 3 != 0 && i % 5 != 0)
        {
          value = i.ToString();
        }
        else if (i % 3 == 0)
        {
          value = "Fizz";
        }
        else if (i % 5 == 0)
        {
          value = "Buzz";
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
          value = "FizzBuzz";
        }
        using (var outFile = new StreamWriter("FizzBuzz.log", true))
        {
          outFile.WriteLine(value);
        }
        result.Add(value);
      }
      return result;
    }

    public void Print(IEnumerable<string> fizzBuzz)
    {
      fizzBuzz.ToList().ForEach(num => Console.WriteLine(num));
    }
  }
}