// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography;

Console.WriteLine("What is your name");
string Userinput = Console.ReadLine();
Console.WriteLine($"Hello, {Userinput} !");

int a  = 0;
int b = 0;
int c = 0;
Console.WriteLine();
Console.ReadKey();

//Declaration variables 
var num1 = 0; var num2 = 0;

//Display the Title in the C# Calculator 
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine(" ------------------------\n ");

Console.WriteLine("Fill in the first number and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());
Console.ReadKey();


Console.WriteLine("Fill in the second number and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());
Console.ReadKey();

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("\tp - Percentage");
Console.WriteLine("\tt - to the power");
Console.Write("Your option? ");

// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        var resulta = (num1 + num2);
        Console.WriteLine($"Your result: {num1} + {num2} = " +resulta);
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        double resultd = ((double)num1 /(double)num2);
        Console.WriteLine($"Your result: {num1} / {num2} = " +resultd);
        break;
    case "p":
        double resultp = ((double) num1 / (double) num2)*100;
        Console.WriteLine($"Your result: " + resultp + "%");
        break;
    case "t":
        int resultt=(int)num1*(int)num1;
        Console.WriteLine($"your result:{resultt}");
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();