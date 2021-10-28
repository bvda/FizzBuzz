using System.Threading;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var event_1 = new AutoResetEvent(true);
            var event_2 = new AutoResetEvent(false);
            var resultCollector = new ResultCollector(event_1, event_2);
            var t = new Thread(resultCollector.Run);
            t.Start();
            var fb = new FizzBuzz(resultCollector, event_1, event_2);
            var result = fb.Calculate(start: 0, end: 1000, fizz: 7, buzz: 9);
            fb.WriteToFile(result);
        }
    }
}
