/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(pow(a, b));

int pow(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result *= num1;
    }
    return result;
}