using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class FizzBuzz
  {
    public FizzBuzz() { }
    public void Calculate(int start, int end)
    {
      for (var i = 0; i < end; i++)
      {
        if (i % 3 != 0 && i % 5 != 0)
        {
          Console.WriteLine(i);
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Fizz")
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Buzz");
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("FizzBuzz");
        }
      }
    }
  }
}
