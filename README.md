# **Итоговая проверочная работа (1 блок)**
## Условия выполнения задачи
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

.

.

.

-------


# Решение 
## Блок-схема алгоритма:

Блок-схема для проекта.png


## Код программы:


``` 
string[] words(string[] array)
{

    string[] NewWords = new string[11];

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewWords[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref NewWords, count);
    return NewWords;
}

void Print(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

Console.WriteLine("Выберите массив");
Console.WriteLine("1 – использовать массив: [“Hello”, “2”, “world”, “:-)”]");
Console.WriteLine("2 – использовать массив: [“1234”, “1567”, “-2”, “computer science”]");
Console.WriteLine("3 – использовать массив: [“Russia”, “Denmark”, “Kazan”]");
Console.WriteLine();
Console.Write("Массив номер: ");
int numberOfArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string[] firstArray = {"hello", "2", "world", ":-)"};
string[] secondArray = {"1234", "1567", "-2", "computer science"};
string[] thirdArray = {"Russia", "Denmark", "Kazan"};


if (numberOfArray == 1)
{
    Print(words(firstArray));
}
if (numberOfArray == 2)
{
    Print(words(secondArray));
}
if (numberOfArray == 3)
{
    Print(words(thirdArray));
}
if (numberOfArray != 1 && numberOfArray != 2 && numberOfArray != 3)
{
    Console.WriteLine("Такого массива нет");
} 
```