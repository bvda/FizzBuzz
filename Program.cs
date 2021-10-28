namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzz();
            var result = fb.Calculate(start: 0, end: 1000, fizz: 7, buzz: 9);
            fb.WriteToFile(result);
        }
    }
}
