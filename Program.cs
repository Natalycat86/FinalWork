string[] array = { "Hello", "2", "world", ":-)" };
int NewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) NewArray++;
}
string[] NewArray = new string[NewArray];
int count = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        NewArray[count] = array[i];
        count++;
    }
}
PrintArray(array);
Console.Write(" -> ");
PrintArray(NewArray);

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}
