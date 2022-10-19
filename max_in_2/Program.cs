Console.Clear();
Console.Write("Please, enter first number:");
//Непонятно какого типа должны быть числа, но ориентируясь на пример, решила, что целые
Int32.TryParse(Console.ReadLine(),out int FirstNumber);
Console.Write("Please, enter second number:");
Int32.TryParse(Console.ReadLine(),out int SecondNumber);
if (FirstNumber > SecondNumber)
{
    Console.WriteLine("First number " + FirstNumber + " is larger");
}
else if (SecondNumber > FirstNumber)
{
    Console.WriteLine("Second number " + SecondNumber + " is larger");
}
else
{
    Console.WriteLine("The numbers are equal");
}