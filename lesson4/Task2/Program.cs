// Задача №2
// • Назовём число «интересным» если его сумма
// цифр чётная
// • Создать двумерный массив, состоящий из
// целых чисел. Вывести на экран «интересные»
// элементы массива

// вывод в виде функции (которая сформирует дввумерный массив из случайных целых чисел)
int [,] CreateMatrix (int rowCount, int colomsCount) // функция создания двухмерного массива колич столбцов и кол-во строк
{
int[,] matrix = new int[rowCount,colomsCount]; // выделим память на кол-во массивов и кол-во элементов массивов
Random rnd = new Random();
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rnd.Next(1, 1000); //от 1 до 999
    }
}
return matrix; // ВОЗВРАТ ГОТОВОГО МАССИВА
}
int[,] matrix = CreateMatrix(3, 4); // ФУНКЦИЯ СОЗДАНИЯ ДВУХМЕРНОГО МАССИВА СЮДА ПИШЕМ КОЛ-ВО МАССИВОВ 1ЦИФРА
 ShowMatrix (matrix);  // эта функция покажет весь массив который мы создали                                                                                 // И КОЛ-ВО СТРОК 2 ЦИФРА

// ЦИКЛ foreach 
 
foreach (int e in matrix) // цикл перебора елементов массива
 {
    if(IsInteresting(e) == true)    // если элемент интересный то выведем его через терминал; ниже напишем функцию;
    {
        System.Console.WriteLine(e);
    }
}       

 // ФУНКЦИЯ IsInteresting

bool IsInteresting(int value) // value это целое число массива которое будет проверяться функцией
{
    int SumOfDigits = GetSumOfDigits(value);

    if(SumOfDigits % 2 == 0) //сумма цифр одного из числа массива /2 без остатка
    {
        return true;
    }
    //else{   сокращение кода
        return false;
   // }
}

int GetSumOfDigits (int value)
{
    int sum = 0; // переменная для хранения суммы цифр цифре из массива 
    while(value > 0) // пока число больше 0 
    {
        sum = sum + value % 10; // сначала получаем самое правую цифру нашего числа 
        value = value / 10; // потом число  еще делим на 10 пока число больше 
    }
    return sum; // обновляем переменную которая хранит сумму цифр числа 
}


void ShowMatrix(int[,] matrix) //  эта функция покажет весь массив который мы создали      
{
    for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i,j]} "); // такой вывод называется интерполяция строк
    }
    System.Console.WriteLine();
}
}