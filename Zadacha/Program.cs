//Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать н астарте выполнения алгоритма. При решении не реокмендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
void Zadacha()
{
    string[] array = { "hello", "2", "world", ":-)" };
    string[] newArrey = new string[array.Length];
    Console.WriteLine($"Исходный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + $" ");
    }
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Новый массив:");


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArrey[i] = array[i]; ;
            Console.Write(" " + newArrey[i]);
        }

    }
    Console.WriteLine();
}
Zadacha();


