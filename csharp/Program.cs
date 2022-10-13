namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      FizzBuzz fb = new FizzBuzz();
      fb.Print(fb.Calculate(0, 100));
    }
  }
}
