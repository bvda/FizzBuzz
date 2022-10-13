using System.Collections.Generic;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();
            IEnumerable<string> result = fb.Calculate(0, 100);         
            fb.WriteToFile(result);
        }
    }
}
