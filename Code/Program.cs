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

// Определение размера нового массива, его создание, наполнение по заданному условию и вывод
void GetNewArray(string[] array)
{
    // Определение размера нового массива
    int newArraySize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newArraySize++;
    }
    // Создание нового массива
    string[] newArray = new string[newArraySize];
    // Наполнение нового массива
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сформирован массив из строк, длинна которых меньше или равна 3 символам. Количество элементов: {newArraySize}");
    Console.WriteLine("[" + string.Join(", ", newArray) + "]");
}