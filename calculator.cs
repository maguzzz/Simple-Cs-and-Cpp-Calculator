// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

string option = "";
do
{
    Console.Write("First number | ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    do
    {
        Console.Write("+   -  *  /  % | ");
        string zeichen = Console.ReadLine();
        Console.Write("Second number | ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (zeichen)
        {
            case "+":
                num1 += num2;
                break;
            case "-":
                num1 -= num2;
                break;
            case "*":
                num1 *= num2;
                break;
            case "/":
                num1 /= num2;
                break;
            case "%":
                num1 %= num2;
                break;
            default:
                Console.WriteLine("ERROR");
                break;
        }
        Console.WriteLine(num1);

        Console.WriteLine("(E)xit | (C)alc more | (R)estart");
        option = Console.ReadLine();
    }
    while (option == "C" || option == "C");
}
while (option == "R" || option == "R");
