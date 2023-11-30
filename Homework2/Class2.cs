namespace Homework2
{
    internal class Class2
    {
        double R;
        public void input()
        {
            Console.WriteLine("Enter Radius of Circle: ");
            R = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Area of Circle is: {0}", Math.PI * Math.Pow(R, R));
        }



    }
}
