
Console.WriteLine("Введите число:");
string num1 = Console.ReadLine();
Console.WriteLine("Введите число:");
string num2 = Console.ReadLine();
GetMax(num1,num2);





int GetMax(string firstValue,string secondValue)
{
    if (firstValue != secondValue)
    {
        return firstValue > secondValue ? firstValue : secondValue;
    }
    else return firstValue;
}
