public class Program
{
    public static void Main(string[] args)
    {
        do
        {
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        Console.WriteLine("--------------");
        Console.WriteLine("Calculator Program");
        Console.WriteLine("--------------");

        
            Console.WriteLine("Enter First Number");
            num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an option");
            Console.WriteLine("+/Add");
            Console.WriteLine("-/Subtract");
            Console.WriteLine("*/Multiply");
            Console.WriteLine("//Divide");
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} is {num1+num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} is {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"{num1} * {num2} is {num1 * num2}");
                    break;

                case "/":
                    Console.WriteLine($"{num1} / {num2} is {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
            Console.WriteLine("would you like to continue y/n ?");
        }while(Console.ReadLine().ToLower()=="y");
        Console.WriteLine("Thanks");
    }
}