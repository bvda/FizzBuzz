using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
  class FizzBuzz : IFizzBuzz
  {
    public FizzBuzz() { }
    public IEnumerable<string> Calculate(int start, int end, int fizz = 3, int buzz = 5)
    {
      IEnumerable<int> range = Enumerable.Range(0, end);
      IList<string> result = new List<string>();
      foreach (var i in range)
      {
        string value = "";
        if (i % fizz != 0 && i % buzz != 0)
        {
          value = i.ToString();
        }
        else if (i % fizz == 0)
        {
          value = "Fizz";
        }
        else if (i % fizz == 0)
        {
          value = "Buzz";
        }
        else if (i % fizz == 0 && i % buzz == 0)
        {
          value = "FizzBuzz";
        }
        result.Add(value);
      }
      return result;
    }

    public void Print(IEnumerable<string> fizzBuzz)
    {
      fizzBuzz.ToList().ForEach(num => Console.WriteLine(num));
    }

    public void WriteToFile(IEnumerable<string> list)
    {
      using (var outFile = new StreamWriter(path: "FizzBuzz.log", encoding: Encoding.UTF8, append: false))
      {
        list.ToList().ForEach(item => outFile.WriteLine(item));
      }
    }
  }
}