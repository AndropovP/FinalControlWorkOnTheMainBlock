// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arr1 = new string [4] {"Hello", "2", "world", ":-)"};
// string[] arr1 = new string [4] {"1234", "1567", "-2", "computer science"};
// string[] arr1 = new string [3] {"Russia", "Denmark", "Kazan"};

void PrintArray (string[] array)        //Функция печати массива
{
    foreach (var item in array)
    {
        System.Console.Write($"“{item}” ");    
    }
    if (array.Length == 0) System.Console.WriteLine("“ ”");
    System.Console.WriteLine();
}

string[] CreateNewArray(string[] array)     //Функция создания нового массива
{
    string[] arr2 = new string [SizeArray(arr1)];
    int j = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
           arr2[j] = item;
           j++;
        }
    }
    return arr2;
}

int SizeArray(string[] array)                   //Функция определения длинны нового массива
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3) count ++;
    }
    return count;
}

PrintArray(arr1);                       //Вывод на печать входящего массива
PrintArray(CreateNewArray(arr1));       //Вывод на печать исходящего массива