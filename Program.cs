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

//4)Напишите программу , которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке. 
//[1,0,1,1,0,1,0,0]

int [] CreateNewArray (int size, int min, int max)     //метод для создания и заполнения массива
{
    int [] array = new int [size];    // форма записи для объявления массива, int() тип данных массива [] array - имя массива new int[размер массива]
    for (int i = 0; i < size; i++)    // цикл для заполнения массива 
        array[i] = new Random().Next(min, max + 1);   // (min, max + 1) / .Next(0, 2) - от нуля ДО 2(2 не будет бать)
    return array;
}

void ShowArray(int [] array)    // метод который показывает нам созданный массив
{
    for (int i = 0; i < array.Length; i++)    // array.Length (тк size в предыдущем методе)
    {
        Console.Write (array[i] + " ");
    }
}

Console.WriteLine("Input count of elements: ");
int countOfElem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max value elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreateNewArray(countOfElem, minValue, maxValue);
ShowArray(array1);

// ShowArray(CreateNewArray(countOfElem));   //вызов метод в методе, заменяет поочередный вывод методов (две предыдцщие строки)