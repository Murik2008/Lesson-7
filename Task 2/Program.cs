// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n
int GetStringToInteger(int number)
{
    Console.WriteLine($"Введите {number} число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
string GetFunctionName()
{
    Console.WriteLine("Введите название функции:");
    string functionName = Console.ReadLine();
    return functionName;
}
void WriteFunctionAnswer(int value, string functionName)
{
    Console.WriteLine($"Ответ функции {functionName} равен {value}");
}
int A(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else if ((number1 != 0) && (number2 == 0))
    {
        return A(number1-1, 1);
    }
    else
    {
        return A(number1-1, A(number1, number2-1));
    }
}
int m = GetStringToInteger(1);
int n = GetStringToInteger(2);
WriteFunctionAnswer(A(m,n), GetFunctionName());