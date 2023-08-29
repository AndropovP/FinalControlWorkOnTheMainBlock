// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arr1 = new string [4] {"Hello", "2", "world", ":-)"};

void PrintArray (string[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"“{item}” ");    
    }
}


string[] CreateNewArray(string[] array)
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

int SizeArray(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            count ++;
        }
    }
    return count;
}

PrintArray(arr1);
PrintArray(CreateNewArray(arr1));