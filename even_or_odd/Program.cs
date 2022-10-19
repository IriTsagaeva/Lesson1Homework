Console.Clear();
Console.WriteLine("Please, enter your number");
Int32.TryParse(Console.ReadLine(), out int number);
if (number%2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}
