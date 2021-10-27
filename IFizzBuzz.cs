using System.Collections.Generic;

namespace FizzBuzz
{
  public interface IFizzBuzz
  {
    IEnumerable<string> Calculate(int start, int end);
    void Print(IEnumerable<string> list);
  }
}