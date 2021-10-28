using System.Threading;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
  class FizzBuzz : IFizzBuzz
  {
    private readonly AutoResetEvent _event_1;
    private readonly AutoResetEvent _event_2;
    private readonly ResultCollector _resultCollector;
    public FizzBuzz(ResultCollector resultCollector, AutoResetEvent event_1, AutoResetEvent event_2) {
      _event_1 = event_1;
      _event_2 = event_2;
      _resultCollector = resultCollector;
    }

    public IEnumerable<string> Calculate(int start, int end, int fizz = 3, int buzz = 5)
    {
      IEnumerable<int> range = Enumerable.Range(0, end);
      foreach (var i in range)
      {
        string value = "";
        if (i % fizz == 0 && i % buzz == 0)
        {
          value = "FizzBuzz";
        }
        else if (i % fizz != 0 && i % buzz != 0)
        {
          value = i.ToString();
        }
        else if (i % fizz == 0)
        {
          value = "Fizz";
        }
        else if (i % buzz == 0)
        {
          value = "Buzz";
        }
        _resultCollector.nextValue = value;
        _event_2.Set();
        _event_1.WaitOne();
      }
      _resultCollector.Running = false;
      _event_2.Set();
      _event_1.WaitOne();
      return _resultCollector.result;
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