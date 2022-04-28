Console.Write("Enter how many numbers you want:" + " ");
var x = int.Parse(Console.ReadLine());
var a = 3;
var b = 5;
int n;
// main algorithm
for (n = 1; n <= x; n++)
{
    if (n % a == 0 && n % b == 0) // Numbers both divided by 3 and 5
    {
        Console.WriteLine("The Number is: Fizz And Buzz");
        continue;
    }

    if (n % a == 0) // Numbers divided by 3
    {
        Console.WriteLine("The Number is: Fizz");
        continue;
    }

    if (n % b == 0) // Numbers divided by 5
    {
        Console.WriteLine("The Number is: Buzz");
        continue;
    }

    Console.WriteLine("The number is: " + n);
}

Console.ReadKey();