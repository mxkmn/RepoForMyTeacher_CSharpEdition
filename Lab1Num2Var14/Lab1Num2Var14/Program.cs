using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Num2Var14 {
  public class Program {
    public static string GetN(int n, int nums) {
      int lastNum = Custom.Unused;
      int sameNums = Custom.Unused;

      for (int i = 1; i <= n; i++) {
        int newNum = Custom.ReadInt(i + "-ое число", 1);

        if (lastNum == newNum) // число идентично прошлому
          sameNums++;
        else { // число не идентично прошлому
          lastNum = newNum;
          sameNums = 1;
        }

        if (sameNums == nums) // найдена последовательность из n одинаковых чисел
          return (nums + "-ка чисел " + lastNum + " найдена. Она была введена с " + (i - nums + 1) + " по " + i + " число.");
      }

      return (nums + "-ка чисел не найдена."); // исключение при ненахождении
    }

    static void Main(string[] args) {
      int n = Custom.ReadInt("количество натуральных чисел в последовательности", 0);
      int nums = Custom.ReadInt("сколько чисел проверять на соседство", 1);

      Console.WriteLine(GetN(n, nums));

      Custom.Exit();
    }
  }

  public class Custom {
    public const int Unused = Int32.MinValue; // константа для неиспользованных переменных
    public const int MinInt = Int32.MinValue; // константа минимального числа для типа Int 
    public const int MaxInt = Int32.MaxValue; // константа максмального числа для типа Int

    public static int ReadInt(string name, int min = MinInt, int max = MaxInt) {
      bool isInputGot = false; // переменная для вывода ошибки при необходимости
      int output = Unused; // тут будет храниться введённое число
      do {
        if (isInputGot) // вывод ошибки при повторном вводе
          Console.Write("Ошибка ввода! ");

        if (min == MinInt && max == MaxInt) // ввод без ОДЗ
          Console.Write("Введите " + name + ": ");
        else if (min != MinInt && max != MaxInt) // ввод с ОДЗ
          Console.Write("Введите " + name + " (в промежутке от " + min + " до " + max + "): ");
        else if (min == MinInt) // ввод числа до заданного
          Console.Write("Введите " + name + " (до " + max + "): ");
        else if (max == MaxInt) // ввод числа от заданного
          Console.Write("Введите " + name + " (от " + min + "): ");

        string input = Console.ReadLine(); // ввод некоторой строки
        isInputGot = true; // изменение переменной для вывода ошибки при необходимости

        // перевод строки input в числовой output, если строка является числом
        if (int.TryParse(input, out int trash)) output = int.Parse(input);
      }
      while (output == Unused || output < min || output > max);

      return output;
    }

    public static void Exit() { // ожидание закрытия консоли пользователем
      Console.Write("\nДля выхода из программы нажмите любую клавишу...");
      Console.ReadKey(true);
    }
  }
}
