Console.Clear();
//Принимаем за уточнение, что необходимо выводить все четные числа, включая ноль и само введенное число, если оно четное.
Console.WriteLine("Please, enter your number");
Int32.TryParse(Console.ReadLine(), out int number);
int count=0;
while (count<=number)
{
    if (count%2 == 0)
    {
        Console.Write(count+" ");
    }
    count++;
}
