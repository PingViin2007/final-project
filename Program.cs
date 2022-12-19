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