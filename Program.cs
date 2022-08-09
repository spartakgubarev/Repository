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
string[] array = CreateArray(size);
int count = FindArray(array);
string[] arrayNew = new string[count];

string[] CreateArray(int size) // Создаем и заполняем массив
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите текст массива {i} - ");
        array[i] = Console.ReadLine();
    }
    return array;
}
int FindArray(string[] array) // Поиск удовлетворяющего запроса. Длина элемента массива <= 3
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
void WriteNewArray(string[] array, string[] arrayNew) // Запись нового массива
{
    count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[count] = array[i];
            count++;
        }
    }

    Console.Write($"Массив: [{string.Join(",", array)}] -> [{string.Join(",", arrayNew)}]");
}

WriteNewArray(array, arrayNew);
Console.ReadKey();