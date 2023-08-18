// Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа 
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число >");
if (number < 100 || number >= 10000)
{
    Console.WriteLine("Это некорректное число, попробуйте еще раз:");
    return;

}
Console.WriteLine($"Введенное число {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра данного числа {secondRank}");