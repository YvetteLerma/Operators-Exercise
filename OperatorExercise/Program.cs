namespace OperatorExercise
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int add = a + b;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)

                Console.WriteLine($"{quotient} with {remainder}");

            double AreaOfCircle(double r)
            {
                double radius = Math.PI * Math.Pow(r, 2);
                return radius;
            }

            Console.Write("What is the radius of a circle?");
            var r = double.Parse(Console.ReadLine());
            double x = AreaOfCircle(r);
            Console.WriteLine($"The area of a circle with a radius of {r} is {x}.");

        }
    }
}