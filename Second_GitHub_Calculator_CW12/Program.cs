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
            string process = Console.ReadLine();

            Console.WriteLine("Enter Number 2:");
            double number2 = double.Parse(Console.ReadLine());

            double result = 0;
            switch (process)
            {
                case "+": result = number1 + number2; break;
                case "-" when(number1>number2): result = number1 - number2; break;
                case "*": result = number1 * number2; break;
                case "/" when (number1 != 0): result = number1 / number2; break;
                case "%" : result = number1 % number2; break;
                default: Console.WriteLine("Your inputs are wrong"); break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", number1, process, number2, result);
        }
    }
}