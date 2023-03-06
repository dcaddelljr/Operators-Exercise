

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCISE 1:");

            var a = 17;
            var b = 4;

            Console.WriteLine("a is 17 and b is 4 \n");
            var sum = a + b;
            Console.WriteLine($" addition: {sum}");
            var sub = a - b;
            Console.WriteLine($" subtraction: {sub}");
            var multi = a * b;
            Console.WriteLine($" multiplication: {multi}");
            var div = a / b;
            Console.WriteLine($" division: {div}");
            var mod = a % b;
            Console.WriteLine($" modulus: {mod}\n");

          var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($" {a}/{b} is {quotient} remainder {remainder}. \n");

            if (a == 17 && b == 4)

            Console.WriteLine ("17/4 is 4 remainder 1.");

           //Exercise 2
           Console.WriteLine("EXERCISE 2:");


           Console.WriteLine("What is the radius of your circle?");
           var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);
            

            Console.WriteLine($"The area of a circle with radius of {radius} is {area} ");

            //Thought Exercise:
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k);

        }
    }
}
