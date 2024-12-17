using System;

public class Program {
    public static void Main(string[] args) {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number)) {
            if (number == 0) {
                Console.WriteLine("0 не является ни простым, ни составным числом.");
            }
            else if (number == 1) {
                Console.WriteLine("1 не является ни простым, ни составным числом."); 
            }
            else if (number < 0) {
                Console.WriteLine($"{number} является отрицательным числом.");
            }
            else {
                int absNumber = Math.Abs(number);
                if (IsItPrime.IsPrime(absNumber)) {
                    Console.WriteLine($"{number} является простым числом.");
                }
                else {
                    Console.Write($"{number} является составным числом. Множители: ");
                    int[] factors = IsItPrime.Check(absNumber);
                    for (int i = 0; i < factors.Length; i++) {
                        Console.Write(factors[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        else {
            Console.WriteLine("Некорректный ввод.");
        }
    }
}