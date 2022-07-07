/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите пятизначное число:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}

int number = GetNumber();
string numberStr = number.ToString();

void CheckingNumber(string numberStr){
  if (numberStr[0]==numberStr[4] && numberStr[1]==numberStr[3])
  {
    Console.WriteLine($"Ваше число: {numberStr} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {numberStr} - НЕ палиндром.");

}
if (numberStr!.Length == 5)
{
  CheckingNumber(numberStr);
}
else 
{
    Console.Clear();
    Console.WriteLine($"Вы ввели не пятизначное число.");
}


