//2.Написать программу возведения числа А в целую стень B

int DegreeOfNumber (int a, int b)
{
     return n == 0 ? 1 : DegreeOfNumber(a, b -1) * a;
}

Console.WriteLine(DegreeOfNumber(5, 3));

//////////////////////////////////////////////
int PowerRecMath(int a, int n)
{
    if(n == 0) return 1;
    else if (n % 2 == 0) PowerRecMath(a * a, n / 2);
    return PowerRecMath(a, n -1) * a;
}
Console.WriteLine(PowerRecMath(5, 3));