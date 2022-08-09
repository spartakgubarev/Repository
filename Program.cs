// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3
// символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
int count = 0;

void CreateArray (string [] array) // Заполняем созданный массив
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите текст массива {i} - ");
        array[i]= Console.ReadLine();
    }
}

CreateArray(array);

Console.WriteLine($"Массив: [{string.Join(",", array)}]");

Console.ReadKey();