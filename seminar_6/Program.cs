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

char[] ConvertStringToCharArray (string str)           // ПИШЕМ char[] Т.К. ПОСЛЕ ФУНКЦИИ ХОТИМ ПОЛУЧИТЬ МАССИВ А ИСПОЛЬЗОВАТЬ БУДЕМ СТРОКУ  str
{
    char[] chars = new char[str.Length]; // Создаем массив chars и выделяем ему место [str.Length] столько элементов массива сколько букв в строке string str
    // "hi" => [,], str.Length = 2, массив на 2 элемента
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i]; // 1й элемент массива равен пермому символу строки
        //chars[0] = str[0], chars[0]=h
        //chars[1] = str[1], chars[1]=i
        // chars = ['h', 'i']
    }
    return chars;  // возвращаем заполненый массив chars строкой str
    // str = "hi" => [h,i]
    // "hi" => [str[0], str[1]]
}
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
string str = "Hello world";                     // НАША СТРОКА КОТОРУЮ ФУНКЦИЯ ConvertStringToCharArray БУДЕТ ВОЗВОДИТЬ В МАССИВ
Console.WriteLine($"Строчка исходная: {str}");  // ВЫВОД СТРОКИ 
char[] chars = ConvertStringToCharArray(str);   // ВЫЗОВ ФУНКЦИИ ОНА БЕРЕТ СТРОКУ str И ОТДАЕТ МАССИВ chars
Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); // ВЫВОД МАССИВЫ 


                                                                             // ЗАДАЧА 3