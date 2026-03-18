// See https://aka.ms/new-console-template for more information

Console.WriteLine("Prosty Kalkulator ");


Console.Write("Podaj pierwszą liczbę: ");
string input1 = Console.ReadLine();
double num1 = Convert.ToDouble(input1);


Console.Write("Wybierz działanie (+, -, *, /, **, ***, ****): ");
string op = Console.ReadLine();


Console.Write("Podaj drugą liczbę: ");
string input2 = Console.ReadLine();
double num2 = Convert.ToDouble(input2);

double result = 0;


switch (op)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Wynik: {num1} + {num2} = {result}");
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine($"Wynik: {num1} - {num2} = {result}");
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Wynik: {num1} * {num2} = {result}");
        break;
    case "/":
        if (num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine($"Wynik: {num1} / {num2} = {result}");
        }
        else
        {
            Console.WriteLine("nie dzielimy przez 0");
        }
        break;
    case "**":
    {
        result = num1 * num1;
        Console.WriteLine($"Wynik: {num1} * {num1} = {result}");

    }
        break;
    case "***":
    {
        result = num1 * num1 * num1;
        Console.WriteLine($"Wynik: {num1} * {num1} * {num1} = {result}");
// kom
    }
        break;
    case "****":
    {
        result = num1 * num1 * num1 * num1;
        Console.WriteLine($"Wynik: {num1} * {num1} * {num1} * {num1} = {result}");

    }
        break;
    default:
        Console.WriteLine("nieprawidłowy znak działania.");
        break;
}