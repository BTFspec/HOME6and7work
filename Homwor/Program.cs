//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


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
char[] chars = {'H', 'O', 'M', 'E', ' ', 'W', 'O', 'R', 'K' }; // массив с символами 
//Console.WriteLine($"Массив: [{string.Join("; ", chars)}]"); 
string res = GetStringFromCharArray(chars);// массив склеиваем в одну большую строчку и потом эту строчку сохраняем в res // ФУНКЦИЯ КОТОРАЯ ИСПОЛЬЗУЕТ МАССИВ ДАСТ СТРОКУ res
Console.WriteLine(res); //показать строку res

                                                                         //Задача 2:


// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

//“aBcD1ef!-” => “abcd1ef!-”

string str = "aBcD1ef!-";
 
 for (int i = 0; i < str.Length; i++)
 {
    
 }