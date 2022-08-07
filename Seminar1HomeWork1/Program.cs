
Console.WriteLine("Введите 2 числа через пробел:");
var numbers = Console.ReadLine().Split(" ");
Console.WriteLine($"{Max.GetMax(numbers[0], numbers[1])}");
Console.WriteLine("Введите 3 числа через пробел:");
numbers = Console.ReadLine().Split(" ");
Console.WriteLine($"{Max.GetMax(numbers[0], numbers[1], numbers[2])}");
Console.ReadLine();
public class Max
{
    public static string GetMax(string firstValue, string secondValue)
    {
        if (firstValue != secondValue)
        {
            return int.Parse(firstValue) > int.Parse(secondValue) ? $"Число {firstValue} больше" : $"Число {secondValue} больше";
        }
        else return "Они равны";
    }
    public static string GetMax(string firstValue, string secondValue, string thirdValue)
    {
        if ((int.Parse(firstValue) + int.Parse(secondValue) + int.Parse(thirdValue)) / 3 != int.Parse(firstValue))
        {
            string maxOfTwo = int.Parse(firstValue) > int.Parse(secondValue) ? firstValue : secondValue;
            return int.Parse(maxOfTwo) > int.Parse(thirdValue) ? $"Число {maxOfTwo} больше" : $"Число {thirdValue} больше";
        }
        else return "Они равны";

    }
}
