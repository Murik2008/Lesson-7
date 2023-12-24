// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
int GetStringToInteger(int number)
{
    Console.WriteLine($"Введите {number} число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
void ValuesBetweenTwoNumbers(int number1, int number2)
{
    if (number1>number2)
    {
        Console.WriteLine(number1-1);
        ValuesBetweenTwoNumbers(number1-1,number2);
    }
    else if (number2>number1)
    {
        Console.WriteLine(number2-1);
        ValuesBetweenTwoNumbers(number2-1,number1);
    }
}
int m = Convert.ToInt32(GetStringToInteger(1));
int n = Convert.ToInt32(GetStringToInteger(2));
Console.WriteLine();
ValuesBetweenTwoNumbers(m,n);