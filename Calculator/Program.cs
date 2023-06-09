Console.WriteLine("Type a number");
var firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the operation");
var operation = Console.ReadLine();

Console.WriteLine("Type a number");
var secondNumber = Convert.ToInt32(Console.ReadLine());

if (operation == "+")
    Console.WriteLine(firstNumber + secondNumber);

if (operation == "-")
   Console.WriteLine(firstNumber - secondNumber);

if (operation == "x")
    Console.WriteLine(firstNumber * secondNumber);

if (operation == "/")
    Console.WriteLine(firstNumber / secondNumber);