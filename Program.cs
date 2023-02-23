Console.Write("Введите размер массива строк: ");
int n = int.Parse(Console.ReadLine());
string[] arr = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    arr[i] = Console.ReadLine();
}

string[] result = new string[n];
int index = 0;
foreach (string str in arr)
{
    if (str.Length <= 3)
    {
        result[index] = str;
        index++;
    }
}

Console.WriteLine("Новый массив строк с длиной не более 3 символов:");
for (int i = 0; i < index; i++)
{
    Console.Write(result[i]);
    if (i != index - 1)
    {
        Console.Write(", ");
    }
}