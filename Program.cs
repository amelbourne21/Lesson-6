// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Calculator!");
mainCalculator();

Console.WriteLine("Would you like to do another calculation?");
var answer = Console.ReadLine().ToLower();

if(answer == "yes")
{
    mainCalculator();
}
else
{
   System.Environment.Exit(0);
}

static void mainCalculator()
{
Console.WriteLine("Enter a number: ");
var firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter an operation - (only add, subtract, multiply and divide available): ");
var operation = Console.ReadLine();
Console.WriteLine("Enter a second number: ");
var secondNumber = int.Parse(Console.ReadLine());

switch(operation)
{
    case "add":
    Console.WriteLine(Add(firstNumber, secondNumber));
    break;
    case "subtract":
    Console.WriteLine(Subtract(firstNumber, secondNumber));
    break;
    case "multiply":
    Console.WriteLine(Multiply(firstNumber, secondNumber));
    break;
    case "divide":
    Console.WriteLine(Divide(firstNumber, secondNumber));
    break;
    default:
    Console.WriteLine("an invalid operation was entered");
    break;
}
}

static int Add(int firstNumber, int secondNumber)
{
var addedCalculation = firstNumber + secondNumber;
return addedCalculation;
}

static int Subtract(int firstNumber, int secondNumber)
{
var subtractedCalculation = firstNumber - secondNumber;
return subtractedCalculation;
}

static int Multiply(int firstNumber, int secondNumber)
{
var multipliedCalculation = firstNumber * secondNumber;
return multipliedCalculation;
}

static int Divide(int firstNumber, int secondNumber)
{
var dividedCalculation = firstNumber / secondNumber;
return dividedCalculation;
}
