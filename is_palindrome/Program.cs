// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите любое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>9999 && number<=99999) {
  int numberReverse = 0;
  int numberCopy = number;
  while (number > 0)
  {
    int digit = number % 10;
    numberReverse = numberReverse * 10 + digit;
    number = number / 10;
  };
  if (numberReverse == numberCopy) Console.WriteLine("Это палиндром!");
  else Console.WriteLine("Это не палиндром!");
} 
else 
{
  Console.Write("Ваше число должно быть в диапазоне от 10000 до 99999 включительно");
};
