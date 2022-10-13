using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
  class FizzBuzz
  {
    IList<string> result;
    public FizzBuzz() { }
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
        result.Add(value);
      }
      return result;
    }

    public void Print(IEnumerable<string> fizzBuzz)
    {
      fizzBuzz.ToList().ForEach(num => Console.Write(num));
    }
  }
}