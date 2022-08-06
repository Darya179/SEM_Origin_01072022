Console.WriteLine("Введите число: ");
int t = int.Parse(Console.ReadLine());

int getSum(int tLoc)
{
    int sum = 0;

    while (tLoc > 0)
    {
        int temp = tLoc%10;
        sum+= temp;
        tLoc/= 10;

    }

    return sum;
}

Console.WriteLine(getSum(t));