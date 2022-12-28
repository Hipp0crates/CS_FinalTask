Console.Clear();

// Создание массива строк рандомного размера от 3 до 6 элементов
string[] GetArray() 
{
    int size = new Random().Next(3, 7);
    string[] array = new string[size];
    return array;
}