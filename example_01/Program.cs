// Задача 1. Принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа 

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

int maxNumber = firstNumberOfThree;

if (maxNumber < secondNumberOfThree) {
  maxNumber = secondNumberOfThree;
}
if (maxNumber < thirdNumberOfThree) {
  maxNumber = thirdNumberOfThree;
}
Console.WriteLine("MAX= " + maxNumber);