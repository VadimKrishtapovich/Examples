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
*/