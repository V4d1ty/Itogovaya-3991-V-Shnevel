using System;

public class IsItPrime {
    public static bool IsPrime(int n) {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }

    public static int[] Check(int n) {
        int[] check = new int[100];
        int count = 0;
        for (int i = 2; i <= n; i++) {
            while (n % i == 0) {
                check[count] = i;
                count++;
                n /= i;
            }
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++) {
            result[i] = check[i];
        }

        return result;
    }
}