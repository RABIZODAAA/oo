
// // // int n = Convert.ToInt32(Console.ReadLine());

// // // Console.WriteLine("Even: " + EvenCount(n));
// // // Console.WriteLine("Odd: " + OddCount(n));
// // // Console.WriteLine("Zero: " + ZeroCount(n));
// // // Console.WriteLine("Digit count: " + DigitCount(n));
// // // Console.WriteLine("Min: " + MinDigit(n));
// // // Console.WriteLine("Max: " + MaxDigit(n));
// // // Console.WriteLine("Sum: " + SumDigit(n));

// // // int EvenCount(int n)
// // // {
// // //     int count = 0;

// // //     while (n > 0)
// // //     {
// // //         int digit = n % 10;

// // //         if (digit % 2 == 0)
// // //             count++;

// // //         n /= 10;
// // //     }

// // //     return count;
// // // }

// // // int OddCount(int n)
// // // {
// // //     int count = 0;

// // //     while (n > 0)
// // //     {
// // //         int digit = n % 10;

// // //         if (digit % 2 != 0)
// // //             count++;

// // //         n /= 10;
// // //     }

// // //     return count;
// // // }

// // // int ZeroCount(int n)
// // // {
// // //     int count = 0;

// // //     while (n > 0)
// // //     {
// // //         int digit = n % 10;

// // //         if (digit == 0)
// // //             count++;

// // //         n /= 10;
// // //     }

// // //     return count;
// // // }

// // // int DigitCount(int n)
// // // {
// // //     int count = 0;

// // //     if (n == 0)
// // //         return 1;

// // //     while (n > 0)
// // //     {
// // //         count++;
// // //         n /= 10;
// // //     }

// // //     return count;
// // // }

// // // int MinDigit(int n)
// // // {
// // //     int min = 9;

// // //     while (n > 0)
// // //     {
// // //         int digit = n % 10;

// // //         if (digit < min)
// // //             min = digit;

// // //         n /= 10;
// // //     }

// // //     return min;
// // // }

// // // int MaxDigit(int n)
// // // {
// // //     int max = 0;

// // //     while (n > 0)
// // //     {
// // //         int digit = n % 10;

// // //         if (digit > max)
// // //             max = digit;

// // //         n /= 10;
// // //     }

// // //     return max;
// // // }

// // // int SumDigit(int n)
// // // {
// // //     int sum = 0;

// // //     while (n > 0)
// // //     {
// // //         int digit = n % 10;
// // //         sum += digit;
// // //         n /= 10;
// // //     }

// // //     return sum;
// // // }


// // // int grade = Convert.ToInt32(Console.ReadLine());

// // // Console.WriteLine(CheckGrade(grade));

// // // char CheckGrade(int grade)
// // // {
// // //     if (grade >= 90)
// // //     {
// // //         return 'A';
// // //     }
// // //     else if (grade >= 80)
// // //     {
// // //         return 'B';
// // //     }
// // //     else if (grade >= 70)
// // //     {
// // //         return 'C';
// // //     }
// // //     else if (grade >= 60)
// // //     {
// // //         return 'D';
// // //     }
// // //     else
// // //     {
// // //         return 'F';
// // //     }
// // // }


// // int n = Convert.ToInt32(Console.ReadLine());

// // string[] numbers = Console.WriteLine()Split();

// // int negative = 0;
// // int positive = 0;
// // int zeros = 0;
// // int even = 0;
// // int odd = 0;

// // int max = int.MinValue;
// // int min = int.MaxValue;
// // int sum = 0;

// // for (int i = 0; i < n; i++)
// // {
// //     int num = Convert.ToInt32(numbers[i]);

// //     if (num < 0)
// //         negative++;

// //     if (num > 0)
// //         positive++;

// //     if (num == 0)
// //         zeros++;

// //     if (num % 2 == 0)
// //         even++;
// //     else
// //         odd++;

// //     if (num > max)
// //         max = num;

// //     if (num < min)
// //         min = num;

// //     sum += num;
// // }

// // Console.WriteLine("Negative = " + negative);
// // Console.WriteLine("Positive = " + positive);
// // Console.WriteLine("Zeros = " + zeros);
// // Console.WriteLine("Even = " + even);
// // Console.WriteLine("Odd = " + odd);
// // Console.WriteLine("Max = " + max);
// // Console.WriteLine("Min = " + min);
// // Console.WriteLine("Sum of Digits = " + sum);


// int n = Convert.ToInt32(Console.ReadLine());

// int negative = 0;
// int positive = 0;
// int zeros = 0;
// int even = 0;
// int odd = 0;

// int max = int.MinValue;
// int min = int.MaxValue;
// int sum = 0;

// for (int i = 0; i < n; i++)
// {
//     int num = Convert.ToInt32(Console.ReadLine());

//     if (num < 0)
//         negative++;

//     if (num > 0)
//         positive++;

//     if (num == 0)
//         zeros++;

//     if (num % 2 == 0)
//         even++;
//     else
//         odd++;

//     if (num > max)
//         max = num;

//     if (num < min)
//         min = num;

//     sum += num;
// }

// Console.WriteLine("Negative = " + negative);
// Console.WriteLine("Positive = " + positive);
// Console.WriteLine("Zeros = " + zeros);
// Console.WriteLine("Even = " + even);
// Console.WriteLine("Odd = " + odd);
// Console.WriteLine("Max = " + max);
// Console.WriteLine("Min = " + min);
// Console.WriteLine("Sum = " + sum);

int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i += 2)
{
    Console.Write(a[i] + " ");
}