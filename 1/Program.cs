// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Reverse(int number) {
    int answer = 0;
    while (number > 0) {
        answer = answer * 10 + number % 10;
        number /= 10;
    }
    return answer;
}


bool ValidateNumber(int num)
{
    if(num >=10000 && num < 100000)
    {
        return true;
    }
    System.Console.WriteLine("Введенное число не пятизначное");
    return false;
}

bool IsPalindrom(int num)
{
    return num == Reverse(num);    
}

int number = Prompt("Введите пятизначное число");
if(IsPalindrom(number))
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }