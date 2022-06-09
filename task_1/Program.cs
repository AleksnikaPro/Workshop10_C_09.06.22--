//1.Найти сумму цифр числа.

int n = 123;
int Sum(int n)
{
 if(n < 1) return 0;
 else return Sum (n / 10) + n % 10;
}
Console.WriteLine(Sum(n));

//////////////////////////////////

uint SumDigits(uint n) => n<10 ? n : n%10 + SumDigits(n/10);
Console.Write("Enter your number: ");
uint n = uint.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Sum of digits {SumDigits(n)}");