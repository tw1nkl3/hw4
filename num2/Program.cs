/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(figuresSum(num));

int figuresSum(int a)
{
    a = Math.Abs(a);
    int result = 0;
    while (a > 0)
    {
        result += a % 10;
        a /= 10;
    }
    return result;
}