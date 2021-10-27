namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      var fb = new FizzBuzz();
      fb.Print(fb.Calculate(0, 100));
    }
  }
}
