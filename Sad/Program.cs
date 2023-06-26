



// Напешите программу, которая принимает на вход пятизначное число 
// и проверяет,является ли оно палиндромом.










void Number(int number)
{
    int first_digit = number / 10000;
    int last_digit = number % 10;
    int second_digit = number / 1000 % 10;
    int penultimate_digit = number % 100 / 10;
    if(first_digit == last_digit && second_digit == penultimate_digit )
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Даннаое число не является палиндромом");
    }
}






Console.Write("Ведите пятизначное число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if(user_number > 0)
{
    if(user_number >= 10000 && user_number <= 99999)
    {
        Number(user_number);
    }
    else
    {
        Console.WriteLine("Требуется ввусти пятизначное число");
    }
}
else
{
    if(user_number <= -10000 && user_number >= -9999)
    {
        user_number *= (-1);
        Number(user_number);
    }
    else
    {
        Console.WriteLine("Требуется ввести пятизначное число");
    }
}



    





