//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


// string GetStringFromCharArray(char[] array) // ФУНКЦИЯ КОТОРАЯ БЕРЕТ ТИП ДАННЫХ char и возводит в string 
// {
//     // array = [‘a’, ‘b’, ‘c’, ‘d’] 
//     string result = string.Empty; // ""   // Empty создает пустую строчку; 
//     foreach (char symbol in array) // цикл foreach проходит все символы массива char и закидывает их в переменную symbol
//     // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
//     {
//         result += symbol;                   // result = result + symbol //изначально result был пустым и потом += symbol туда зашли все символы 
//         // result = "" + "a"; result = "a"
//         // result = "a" +"b"; result = "ab"
//         // result = "ab" + "c"; result = "abc"
//         // result = "abc" + "d"; result = "abcd"
//     }
//     return result; // после прохода циклом foreach обновим переменную result; ч 
// }
// // '1' - char,символ одинарные кавычки  "3rr2" - string строка двойные кавычки
// char[] chars = { 'H', 'O', 'M', 'E', ' ', 'W', 'O', 'R', 'K' }; // массив с символами 
// //Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); 
// string res = GetStringFromCharArray(chars);// массив склеиваем в одну большую строчку и потом эту строчку сохраняем в res // ФУНКЦИЯ КОТОРАЯ ИСПОЛЬЗУЕТ МАССИВ ДАСТ СТРОКУ res
// Console.WriteLine(res); //показать строку res

// //Задача 2:


// // Задача 2: Задайте строку, содержащую латинские буквы
// // в обоих регистрах. Сформируйте строку, в которой все
// // заглавные буквы заменены на строчные.

// //“aBcD1ef!-” => “abcd1ef!-”

// Console.Write("Введите строчку: "); // подсказка
// string inputString = Console.ReadLine(); // функция считывания строки 
// inputString = inputString.ToLower(); // нижний регистр, "HI" -> "hi" //ToLower() если есть заглавные буквы переведет их в нижний регистр 
//                                      // ToUpper() - верхний ("hi" => "HI")
// Console.WriteLine(inputString);

//Задача 3:

//Задайте произвольную строку. Выясните,
//является ли она палиндромом.

//  “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да                
using System;
using System.Runtime.InteropServices;

Console.Write("Введите строчку: ");
string? inputiString = Console.ReadLine();
inputiString = inputiString?.ToLower(); // нижний регистр, "HI" -> "hi"

//Console.WriteLine(inputiString);
// object objValue = Convert.ChangeType(inputiString,typeof(int));
//  Console.WriteLine(objValue);

char[] ConvertStringToCharArray(string inputiString)           // ПИШЕМ char[] Т.К. ПОСЛЕ ФУНКЦИИ ХОТИМ ПОЛУЧИТЬ МАССИВ А ИСПОЛЬЗОВАТЬ БУДЕМ СТРОКУ  str
{
    char[] chars = new char[inputiString.Length]; // Создаем массив chars и выделяем ему место [str.Length] столько элементов массива сколько букв в строке string str
    // "hi" => [,], str.Length = 2, массив на 2 элемента

    for (int i = 0; i < inputiString.Length; i++)
    {
        chars[i] = inputiString[i]; // 1й элемент массива равен пермому символу строки
        //chars[0] = str[0], chars[0]=h
        //chars[1] = str[1], chars[1]=i
        // chars = ['h', 'i']
    }
    return chars;  // возвращаем заполненый массив chars строкой 
}


// НАША СТРОКА КОТОРУЮ ФУНКЦИЯ ConvertStringToCharArray БУДЕТ ВОЗВОДИТЬ В МАССИВ
//Console.WriteLine($"Строчка исходная: {inputiString}");  // ВЫВОД СТРОКИ 
void MyFunction(string? inputiString) // убираем значение NULL
{
    if (inputiString == null)
    {
        throw new
        ArgumentNullException(nameof(inputiString));
    }
    char[] chars = ConvertStringToCharArray(inputiString);   // ВЫЗОВ ФУНКЦИИ ОНА БЕРЕТ СТРОКУ inputiString И ОТДАЕТ МАССИВ chars
    {
        Array.Reverse(chars); // разворот массива
    }
    Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); // ВЫВОД МАССИВЫ 
}
MyFunction(inputiString);


 static bool IsPalindrome(char[] chars)
{
    int length = chars.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (chars[i] != chars[length - i - 1])
        {
            return false;
        }
    }

    return true;
}


//  static void Main(char[] chars)
// {
//     bool isPalindrome = IsPalindrome(chars);

//     if (isPalindrome)
//     {
//         Console.WriteLine("Массив является палиндромом.");
//     }
//     else
//     {
//         Console.WriteLine("Массив не является палиндромом.");
//     }
// }

// Main(char);


//Задача 4 (необязательная): Обратный порядок слов в строкеpublic class Task4
//{
 static void Main(string[] args)
{
// Входная строка со словами, разделенными пробелами
string input = "Hello my world";
// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);
// Вывод результата
Console.WriteLine(result);
}
// Метод для обращения порядка слов в строке
 static string ReverseWords(string str)
{
// Разделение строки на слова
string[] words = str.Split(' ');
// Обращение порядка слов
Array.Reverse(words);
// Соединение слов обратно в строку с пробелами
return string.Join(" ", words);
}
//}