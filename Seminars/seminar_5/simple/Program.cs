// Вывести список простых чисел от 1 до N
int n = 20;

for (int number = 2; number <= n; number++)
{

    if (isPrime(number))
    {
        System.Console.Write(number + " ");
    }
}

bool isPrime (int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}