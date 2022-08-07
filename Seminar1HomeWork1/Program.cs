
Console.WriteLine("Введите 2 числа через пробел для нахождения максимального:");
var numbers = Console.ReadLine().Split(" ");
Console.WriteLine($"{Max.GetMax(numbers[0], numbers[1])}");

Console.WriteLine("Введите 3 числа через пробел для нахождения максимального:");
numbers = Console.ReadLine().Split(" ");
Console.WriteLine($"{Max.GetMax(numbers[0], numbers[1], numbers[2])}");

Console.WriteLine("Введите число для проверки на четность:");
Console.WriteLine(EvenNumbersProcessing.ParityCheck(Console.ReadLine()));


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
public class EvenNumbersProcessing 
{
    public static string ParityCheck(string number)
    {
        return int.Parse(number) % 2 == 0 ? $"Число {number} четное" : $"Число {number} не четное";

    }

}