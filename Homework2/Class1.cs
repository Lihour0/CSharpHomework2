namespace Homework2
{
    internal class Class1
    {
        double riel;
        public void input()
        {
            Console.Write("Input Money: ");
            riel = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            if (riel < 100)
            {
                Console.WriteLine("{0}", Math.Abs(riel -= 100));
            }

        }

    }
}
