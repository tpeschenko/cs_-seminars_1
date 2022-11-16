// Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

int input_number = 30;
int output_number = 1;

while (output_number <= input_number)
{
    if (output_number % 2 == 0)
    {
        Console.Write(output_number);
        Console.Write(" ");
    }
    output_number += 1;
}


