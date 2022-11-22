//1.Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

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
//2) В этом методе (return) мы возвращаем результат из метода 
//и можем сним взаимодействовать дальше в основной программе

//2.Напищите программу, которая принимает на вход число и выдает количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*
int CountOfDigits(int number)
{
    int current = 1;
    while (number >= 10)
    {
        number = number / 10;  // 123 / 10 -> 12 / 10 -> 1 / 10 -> 0 
        current++;
    }
    return current;
}

Console.WriteLine("Input your number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int countDigit;
int userNum1 = (-1) * userNum;  //*= (userNum = userNum * (-1)) / += (userNum = userNum + (-1)) / -= (userNum = userNum - (-1))
    countDigit = CountOfDigits(userNum1);

if (userNum >= 0)
    countDigit = CountOfDigits(userNum);
else
    countDigit = CountOfDigits(userNum1);

Console.WriteLine($"Your number {userNum} has {countDigit} digits");
*/

//3)Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N. (факториал) 
//4 -> 24
//5 -> 120

/*
void Factorial (int n)
{
    int multi = 1;
    for (int cur = 1; cur <= n; cur++)
    {
        multi *= cur;       //multi = multi * cur
    }
    Console.WriteLine($" {n} -> {multi} "); 
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    while (number < 0)
    {
        Console.WriteLine("Pls, input POSITIVE int number");
        number = Convert.ToInt32(Console.ReadLine());
    }
}

Factorial(number);
*/

//4)