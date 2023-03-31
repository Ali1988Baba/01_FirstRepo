namespace Second_GitHub_Calculator_CW12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator\n");

            Console.WriteLine("Enter     Number 1:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Select a Process(+,-,*,/,%):");
            char process = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            double number2 = double.Parse(Console.ReadLine());

            double result = 0;
            double operation = process switch
            {
            '+'=> result = number1 + number2,
            '-' when(number1 > number2)=> result = number1 - number2,
            '*'=> result = number1 * number2,
            '/' when(number1 != 0)=> result = number1 / number2,
              '%' => result = number1 % number2,
            };
            Console.WriteLine("{0} {1} {2} = {3}", number1, process, number2, result);
        }
    }
}