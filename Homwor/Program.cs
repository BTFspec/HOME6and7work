// //Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// char[,] chars = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
// // a b c

// string GetStringFromCharArray(char[,] chars) // ФУНКЦИЯ КОТОРАЯ БЕРЕТ ТИП ДАННЫХ char и возводит в string 
// {
//     // array = [‘a’, ‘b’, ‘c’, ‘d’] 
//     string result = string.Empty; // ""   // Empty создает пустую строчку; 
//     foreach (char symbol in chars) // цикл foreach проходит все символы массива char и закидывает их в переменную symbol
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
// //char[] chars = { 'H', 'O', 'M', 'E', ' ', 'W', 'O', 'R', 'K' }; // массив с символами 
// //Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); 
// string res = GetStringFromCharArray(chars);// массив склеиваем в одну большую строчку и потом эту строчку сохраняем в res // ФУНКЦИЯ КОТОРАЯ ИСПОЛЬЗУЕТ МАССИВ ДАСТ СТРОКУ res
// Console.WriteLine(res); //показать строку res

// //Задача 2:


// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

//“aBcD1ef!-” => “abcd1ef!-”

// Console.Write("Введите строчку: "); // подсказка
// string? inputString = Console.ReadLine(); // функция считывания строки 
// inputString = inputString?.ToLower(); // нижний регистр, "HI" -> "hi" //ToLower() если есть заглавные буквы переведет их в нижний регистр 
//                                      // ToUpper() - верхний ("hi" => "HI")
// Console.WriteLine(inputString);

// Задача 3:

// Задайте произвольную строку. Выясните,
// является ли она палиндромом.

//  “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да                

// Console.Write("Введите строчку: ");
// string? inputiString = Console.ReadLine();
// inputiString = inputiString?.ToLower(); // нижний регистр, "HI" -> "hi"

// //string inputiString = "valav";

// bool Palindrom(string inputiString)
// {
//     for (int i = 0, j = inputiString.Length - 1; i < inputiString.Length; i++, j--)
//     {

//         if (inputiString[i] != inputiString[j])
//         {
//             Console.WriteLine($"NO");
//             return false;
//             // если есть отличие в в зеркале слова то это не палиндром
//         }

//     }
//     Console.WriteLine($"YES");
//     return true;
// }


// //Palindrom(inputiString);

// void MyFunction(string? inputiString) // убираем значение NULL
// {
//     if (inputiString == null)
//     {
//         throw new
//         ArgumentNullException(nameof(inputiString));
//     }
// Palindrom(inputiString);
// }

// MyFunction(inputiString);    // эта функция убирает ошибку warning CS8604: Возможно, аргумент-ссылка, допускающий значение NULL, для параметра "str"

//Задача 4 (необязательная): Обратный порядок слов в строке


// Входная строка со словами, разделенными пробелами
string input = "Hello my world";
Console.WriteLine(input); 


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


// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);
// Вывод результата
Console.WriteLine(result);

