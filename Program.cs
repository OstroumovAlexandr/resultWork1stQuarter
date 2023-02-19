string[] ReadyArray = { "1234", "1567", "-2", "computer science", ";-)" };
int size = GetCountArray(ReadyArray);
string[] NewArray = CreateNewArray(ReadyArray, size);
Console.WriteLine($"[{String.Join(", ", (ReadyArray))}]");
Console.Write($"[{String.Join(", ", (NewArray))}]");

//метод проверки массива на соответствие условиям
//возвращаем счетик для нового массива
int GetCountArray(string[] ReadyArray)
{
    int count = 0;
    foreach (string el in ReadyArray)
    {
        if (el.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

// //Метод создания массива по условиям задачи
string[] CreateNewArray(string[] ReadyArray, int size)
{
    string[] NewArray = new string[size];
    int count = 0;
    for (int i = 0; i < ReadyArray.Length; i++)
    {
        if (ReadyArray[i].Length <= 3)
        {
            NewArray[count] = ReadyArray[i];
            count++;
        }
    }
    return NewArray;
}