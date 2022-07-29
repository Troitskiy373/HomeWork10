// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1


/*string[] massive = { "qwe", "wer", "ert", "rty", "tyu" };

int MassiveCount(string[] massive)// метод который считает кол-во слов в массиве, начинающихся на гласную букву.
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i][0] == 'a' ||
            massive[i][0] == 'e' ||
            massive[i][0] == 'i' ||
            massive[i][0] == 'o' ||
            massive[i][0] == 'u' ||
            massive[i][0] == 'y')
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(MassiveCount(massive));*/


// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}



string[] massive = { "qwe", "wer", "ert", "rty", "tyu", "yui" };

string[] MergeIndex(string[] massive)// метод объединяя элементы исходного массива попарно
{
    string[] Merge = new string[massive.Length / 2];
    for (int i = 0; i < massive.Length; i += 2)
    {
        Merge[i / 2] = massive[i] + massive[i + 1];
    }
    return Merge;
}

void PrintMassive(string[] mass)// метод вывода
{
    foreach (string massive in mass)
    {
        Console.WriteLine(massive);
    }
}

PrintMassive(MergeIndex(massive));