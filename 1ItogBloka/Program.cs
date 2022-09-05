// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


Console.WriteLine("Введите строки массива через пробел: \n");
string text = Console.ReadLine();
string[] massString = text.Split(' ');

var res = from word in massString
          where word.Length <= 3
          select word;
if (res.Count() == 0)
{
    Console.WriteLine("Нет строк, длина которых меньше либо равна 3 символа");
}
else
{
    Console.Write("\nМассив из строк, длина которых меньше либо равна 3 символа -> [ ");
    for (int i = 0; i < massString.Length; i++)
    {
        if (massString[i].Length <= 3)
            Console.Write(massString[i] + " ");
    }
    Console.Write(']');
}
