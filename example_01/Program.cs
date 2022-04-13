// Задача 1. Принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа 

Console.Clear();

Console.WriteLine("Задача № 1. Последняя цифра трёхзначного числа");
Console.Write("Введи трёхзначное число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber / 100 < 10) {    // проверка что число не больше 3 знаков
  if (threeDigitNumber / 100 > 1) {   // проверка что число не меньше 3 знаков

    int lastDigit = threeDigitNumber % 10;
    Console.WriteLine("Последняя цифра вашего числа: " + lastDigit);
  }
  else {
  Console.WriteLine("Слишком маленькое число");
  }
}
else {
  Console.WriteLine("Слишком большое число");
}

//  Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое  число большее, а какое меньшее

Console.WriteLine();
Console.WriteLine("Задача № 2. Максимальное из двух чисел");
Console.Write("Введи первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber>secondNumber) {
  Console.WriteLine("MAX= " + firstNumber);
}
else {
  Console.WriteLine("MAX= " + secondNumber);
}

//  Задача 3. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine();
Console.WriteLine("Задача № 3. Максимальное из трёх чисел");

Console.Write("Введи первое число: ");
int firstNumberOfThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int secondNumberOfThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int thirdNumberOfThree = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumberOfThree;   // дополнительная переменная

if (maxNumber < secondNumberOfThree) {
  maxNumber = secondNumberOfThree;
}
if (maxNumber < thirdNumberOfThree) {
  maxNumber = thirdNumberOfThree;
}
Console.WriteLine("MAX= " + maxNumber);


// Задача № 4. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine();
Console.WriteLine("Задача № 4. Чётное или нет?");

Console.Write("Введи тестируемое число: ");
int testNumber = Convert.ToInt32(Console.ReadLine());

if (testNumber % 2 == 1) {
   Console.WriteLine("Введенное число " + testNumber + " - нечётное");
}
else {
  Console.WriteLine("Введенное число " + testNumber + " - чётное"); 
}


// Задача № 5. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine();
Console.WriteLine("Задача № 5. Чётные от 1 до N");

Console.Write("Введи число N: ");
int theNumberN = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= theNumberN)
{
  if (counter % 2 != 1) {
    Console.Write(counter);
    if (counter < (theNumberN - 1)) {     // расстановка запятых
      Console.Write(", ");        
    }
  }
  counter += 1;
}


