/* Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int len = Convert.ToInt32(Console.ReadLine());
List<int> array = new List<int>();
Random rnd = new Random();
for (int i = 0; i < len; i++)
{
    array.Add(rnd.Next(0, 10000));
}
Console.Write(String.Join(", ", array));
