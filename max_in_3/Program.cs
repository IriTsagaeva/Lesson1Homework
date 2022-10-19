Console.Clear();
Console.Write("Please, enter first number:");
//Непонятно какого типа должны быть числа, но ориентируясь на пример, решила, что целые
Int32.TryParse(Console.ReadLine(), out int FirstNumber);
Console.Write("Please, enter second number:");
Int32.TryParse(Console.ReadLine(), out int SecondNumber);
Console.Write("Please, enter third number:");
Int32.TryParse(Console.ReadLine(), out int ThirdNumber);
if (FirstNumber > SecondNumber)
{
    if (FirstNumber > ThirdNumber)
    {
        Console.WriteLine("Max number is " + FirstNumber);
    }
    else 
    {
        Console.WriteLine("Max number is " + ThirdNumber);
    }
}
else 
{
    if (SecondNumber > ThirdNumber)
    {
        Console.WriteLine("Max number is " + SecondNumber);
    }
    else
    {
        Console.WriteLine("Max number is " + ThirdNumber);
    }
}