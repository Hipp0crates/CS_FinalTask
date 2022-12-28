Console.Clear();

// Создание массива строк рандомного размера от 3 до 6 элементов
string[] GetArray() 
{
    int size = new Random().Next(3, 7);
    string[] array = new string[size];
    return array;
}

// Наполнение массива с клавиатуры и его вывод
void FillArray(string?[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($"Введите элемент массива {i + 1}: ");
        array[i] = Convert.ToString(Console.ReadLine());
        i++;
    }
    Console.WriteLine();
    Console.WriteLine($"Создан первоначальный массив строк. Количество элементов: {i}");
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}