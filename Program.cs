//Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

//1) void Met1(){} - невозвратный метод (считает, показывает, не возвращает)


//2) int / double / bool /  Met1(){...return args;} - возвратный метод (может вернуть результат или др. данные из метода)

// 1)
/*
void MetFindSum(int a)
{
    int sum = 0;      // переменная, которая в последствии будет накапливать результат
    for (int current = 1; current <= a; current++)  // current -переменная условия цикла(для цикла), =1 -по условию отрезка, <= a -по условию отрезка, ++ -каждый цикл +1.
    {
        sum += current;  // -сокращенная запись для summa = summa + current
    }
    Console.WriteLine ($"Sum of elements from 1 to {a} is {sum} ");
}

Console.WriteLine("Input your number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
MetFindSum(userNum);
*/
//1) В этом методе(void) невозможно в дальнейшем взаимодействие с результатом (только проверка результата)

// 2)
/*
int MetFindSum(int a)
{
    int sum = 0;      // переменная, которая в последствии будет накапливать результат
    for (int current = 1; current <= a; current++)  // current -переменная условия цикла(для цикла), =1 -по условию отрезка, <= a -по условию отрезка, ++ -каждый цикл +1.
    {
        sum += current;  // -сокращенная запись для summa = summa + current
    }
    return sum;
}

Console.WriteLine("Input your number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int result = MetFindSum(userNum);                     //вывод результата из метода, для дальнейшего использования этого результата в методе

Console.WriteLine ($"Sum of elements from 1 to {userNum} is {result} ");
*/
//В этом методе (return) мы возвращаем результат из метода и можем сним взаимодействовать дальше в основной программе






