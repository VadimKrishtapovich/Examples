/* Метод 1. Метод который ничего не возвращает и ничего не принимает.

void Method1()
{
    Console. WriteLine("Автор Криштапович Вадим Сергеевич");
}

Method1();
*/

/* Меотд 2. Этот метод ничего не возвращает, но принимает аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;        // Инкремент - увеличение счётчика на еденичку.
                   // Декримент - уменьшение счётчика на еденичку.     
    }
}

// Method21("Текст", 4);
Method21(count: 5, msg: "новый текст");
*/

/* Метод 3. Этот метод которые что-то возвращают но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

/* Метод 4. Что-то принимает и что-то возвращает.

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    
    while(i < count)
    {
    result = result + c;
    i++;
    }
    return result;
}

string res = Method4(10, "Hello World, ");
Console.WriteLine( );
Console.WriteLine(res);


string Method4(int count, string c)
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
        {
    result = result + c;
    
    }
    return result;
}

string res = Method4(10, "Hello World, ");
Console.WriteLine( );
Console.WriteLine(res);
*/

/* Цикл for, и цикл for в цикле for.

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j}= {i * j}");
    }
    Console.WriteLine();
}
*/

/* =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// sring s = "qwerty"
//            012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

*/

/* Работа с массивом.т алгоритм сортировки методом минимакса или
// иногда просто называют методом максимального, или выбора максимального или выбора
// минимального и так далее. Узнаем, в чём особенность (суть) этого алгоритма. Есть какая-то
// последовательность чисел. Наша задача — выбрать самый первый элемент и в оставшейся
// части, с учётом нашей текущей позиции определить минимальный. После того как он найден,
// нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, это
// 6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.
// Было: 6 8 3 2 1 4 5 7
// Стало: 1 8 3 2 6 4 5 7

// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[]array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

// PrintArray(arr);

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

*/