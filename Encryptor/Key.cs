using System;
namespace encryption
{
  static class Key
  {
    private static int[] primeNum1 = {
      3, 5, 7, 11, 13, 17,
      19, 23, 29, 31, 37, 41,
      43, 47, 53, 59, 61, 67,
      71, 73, 79, 83, 89, 97,
    };
    private static int[] primeNum2 = {
      101, 103, 107, 109, 113, 127,
      131, 137, 139, 149, 151, 157,
      163, 167, 173, 179, 181, 191,
      193, 197, 199, 211, 223, 227
    };
    private static int F, E;
    static public int GetN(string password)
    {
                                                                                 //Алгоритм RSA
      int hash = HashFunction(password);
      int p = primeNum1[hash / 24];                                              //выбор случайной пары простых чисел.
      int q = primeNum2[hash % 24];                                              //совпадение p и q исключено, как и недобор p*q для диапазона ASCII
      F = EulerFunction(p, q);
      int N = p * q;
      return N;
    }
    public static int GetE()                                                     //выбор е: е - простое; е < F; е и F взаимопростые (НОД(е,F) == 1)) 
    {
      for (E = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(F))); E >= 2; E--)     //чтобы E было не очень большое начнем перебор с корня.
      {                                                                          //в таком диапазоне точно найдется подходящее Е
        if (IsPrime(E) && (GreatestCommonDiv(E,F) == 1))
        {
          break;
        }
      }
      return E;
    }
    public static int GetD()
    {
      int E = GetE();
      int D;
      for (D = 3; true; D++)
      {
        if ((D * E) % F == 1)
          break;
      }
      return D;
    }
    private static int HashFunction(string word)                                  //почти ASCII-сумма
    {
      int hash = 0;
      foreach(char ch in word)
      {
        hash += Convert.ToInt32(ch) * 9001;                                       //9001 - простое. Для разнообразия хеша
      }
      return hash % 553;                                                          //hash в диапазоне [0; 552]; 552 = 24 * 24 - 24; 
    }                                                                             //т.е. все пары {primeNum1[i], primeNum2[j]} без повторений

    private static int EulerFunction(int p, int q)
    {
      return (p - 1) * (q - 1);
    }

    private static bool IsPrime(int x)                                            //проверка на простоту
    {
      for(int i = 2; i < x; i++)
      {
        if(x % i == 0)
        {
          return false;
        }
      }
      return true;
    }
    private static int GreatestCommonDiv(int a, int b)                            //Алгоритм Евклида для нахождения НОД
    {
      if (a < b)
      {
        return GreatestCommonDiv(b, a);
      }
      if (b == 0)
      {
        return a;
      }
      return GreatestCommonDiv(b, a % b);
    }
  }
}
