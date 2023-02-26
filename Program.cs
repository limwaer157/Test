//  Напиать программу которая из имеющегося массива строк формирует массив из строк , длина которых меньше ли равна 3 символа . 
//  первоначально массив можно ввести с клавиатуры , либо задать на старте выполнения алгоритма .  


Console.Write("Количество слов, которые хотите вести  -  ");
int string_size = Int32.Parse(Console.ReadLine()!);
int size_word = 0;
string[] text = new string[string_size];

void FullArray(string[] text)
{
    for (int i = 0; i < string_size; i++)
    {
        Console.Write("Введите текст для записи его в массив ");
        text[i] = Console.ReadLine()!;
        if (text[i].Length <= 3) size_word = size_word + 1;

    }
}


void PrintFirstArray(string[] text)
{
    Console.Write(string.Join(",", text));
    Console.WriteLine();
    Console.WriteLine("В заданом массиве" + $" {size_word} " + " элемента(ов) которые меньше или равны трем символам");
}


void SaveNumbers(string[] text, string[] newText)
{
    for (int i = 0, j = 0; i < string_size; i++)
    {
        if (text[i].Length <= 3)
        {
            newText[j] = text[i];
            j++;
        }
    }
}

void PrintSecondArry(string[] newText)
{
    Console.Write(string.Join(",", newText));
}

FullArray(text);
PrintFirstArray(text);
string[] newText = new string[size_word];
SaveNumbers(text, newText);
PrintSecondArry(newText);