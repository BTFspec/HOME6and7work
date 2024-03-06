//СЛОЖЕНИЕ СТРОК КОНКАТЕНАЦИЯ 
//"ПРИВЕТ" + "МИР" = "ПРИВЕТМИР"
// "ПРИВЕТ" СТРОКА СОСТОИТ ИЗ НЕСКОЛЬКИХ символов char
//str = "привет" строка по сути это массив символов(char)
//str[0] = 'п'(char)

                                                                           // ЗАДАЧА 1

//Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 

//[‘a’, ‘b’, ‘c’, ‘d’] => “abcd” 

string GetStringFromCharArray (char[] array) // ФУНКЦИЯ КОТОРАЯ БЕРЕТ ТИП ДАННЫХ char и возводит в string 
{
    // array = [‘a’, ‘b’, ‘c’, ‘d’] 
    string result = string.Empty; // ""   // Empty создает пустую строчку; 
    foreach (char symbol in array) // цикл foreach проходит все символы массива char и закидывает их в переменную symbol
    // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
    {
        result += symbol;                   // result = result + symbol //изначально result был пустым и потом += symbol туда зашли все символы 
        // result = "" + "a"; result = "a"
        // result = "a" +"b"; result = "ab"
        // result = "ab" + "c"; result = "abc"
        // result = "abc" + "d"; result = "abcd"
    }
    return result; // после прохода циклом foreach обновим переменную result; ч 
}
// '1' - char,символ одинарные кавычки  "3rr2" - string строка двойные кавычки
char[] chars = {'1', 'd', '!', '2', 'f'}; // массив с символами 
//Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); 
string res = GetStringFromCharArray(chars);// массив склеиваем в одну большую строчку и потом эту строчку сохраняем в res // ФУНКЦИЯ КОТОРАЯ ИСПОЛЬЗУЕТ МАССИВ ДАСТ СТРОКУ res
Console.WriteLine(res); //показать строку res

                                                                             // ЗАДАЧА 2

// На основе символов строки (тип string) сформировать массив // ЗАДАЧА НАОБОРОТ 
// символов (тип char[]). Вывести массив на экран.

// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] ConvertStringToCharArray (string str)           // ПИШЕМ char[] Т.К. ПОСЛЕ ФУНКЦИИ ХОТИМ ПОЛУЧИТЬ МАССИВ А ИСПОЛЬЗОВАТЬ БУДЕМ СТРОКУ  str
// {
//     char[] chars = new char[str.Length]; // Создаем массив chars и выделяем ему место [str.Length] столько элементов массива сколько букв в строке string str
//     // "hi" => [,], str.Length = 2, массив на 2 элемента
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i]; // 1й элемент массива равен пермому символу строки
//         //chars[0] = str[0], chars[0]=h
//         //chars[1] = str[1], chars[1]=i
//         // chars = ['h', 'i']
//     }
//     return chars;  // возвращаем заполненый массив chars строкой str
//     // str = "hi" => [h,i]
//     // "hi" => [str[0], str[1]]
// }
// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
// string str = "Hello world";                     // НАША СТРОКА КОТОРУЮ ФУНКЦИЯ ConvertStringToCharArray БУДЕТ ВОЗВОДИТЬ В МАССИВ
// Console.WriteLine($"Строчка исходная: {str}");  // ВЫВОД СТРОКИ                                                                      // ТАК ВЫВОДЯТ СТРОКУ
// char[] chars = ConvertStringToCharArray(str);   // ВЫЗОВ ФУНКЦИИ ОНА БЕРЕТ СТРОКУ str И ОТДАЕТ МАССИВ chars
// Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); // ВЫВОД МАССИВЫ                                                        //ТАК ВЫВОДЯТ МАССИВ


                                                                             // ЗАДАЧА 3
                                                                             
 // // Считать строку с консоли, состоящую из латинских
// // букв в нижнем регистре. Выяснить, сколько среди
// // введённых букв гласных.
// // Пример
// // “hello” => 2
// // “world” => 1

int GetVovelsCount (string str)
{
    // str = "hello", 'h' - 1 символ, char
    string vovels = "aoueyi"; // Гласные буквы в англ. алфавите
    int vovelsCount = 0; // Количество гласных 
    foreach (char symbol in str) // Получает каждый символ введенной строчки
    {
        // 'a' == a, o, u, e, y, i
        foreach (char vovel in vovels) // Получаем гласные // ПЕРЕМЕННАЯ vovel ЭТО КАЖДАЯ ГЛАСНАЯ БУКВА В СТРОКЕ vovels
        {
            if (symbol == vovel) // Нашли гласную букву  // ПЕРЕМЕННАЯ symbol ЭТО КАЖДАЯ  БУКВА В СТРОКЕ str //ЕСЛИ БУКВА ИЗ СТРОКИ str ПОДХОДИТ К БУКВАМ ИЗ СТРОКИ vovels
            {
                vovelsCount++; // vovelsCount = vovelsCount + 1
                break; // Если нашли гласную, переходим к след.букве// как только нашли гласную в символе из строки str останавливаем проверку и переходим к следуйщей букве
            }                                        //  +break+      // 1 символ = 1 гласная буква поэтому если цикл foreach нашел ее то проверка переходит на след. символ +break+
        }
    }
    return vovelsCount;
}

Console.Write("Введите строчку: ");
string? str = Console.ReadLine();
str = str?.ToLower(); // нижний регистр, "HI" -> "hi"
// ToUpper() - верхний ("hi" => "HI")
void MyFunction(string? str) // убираем значение NULL
{
    if (str == null)
    {
        throw new
        ArgumentNullException(nameof(str));
    }
Console.WriteLine($"В строчке: {str} в нижн. регистре : {GetVovelsCount(str)} гласных");
}
MyFunction(str);    // эта функция убирает ошибку warning CS8604: Возможно, аргумент-ссылка, допускающий значение NULL, для параметра "str"
