namespace Homework2
{
    internal class Class3
    {
        double F, C;
        public void input()
        {
            Console.Write("Enter Fahrenheit: ");
            F = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Fahrenheit to Celsius: {0}", (F - 32) * 5 / 9);
        }

    }
}
