using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Num1Var12 {
  public class Program {
    public static string GetMoney(int n) { // отдаёт строку с количеством денег
      string output = "";
      int rubs = n / 100, kops = n % 100;
      if (rubs > 0) { // если есть рубли
        output += rubs;
        if (5 <= rubs && rubs <= 20)
          output += " рублей ";
        else if (rubs % 10 == 1)
          output += " рубль ";
        else if (rubs % 10 == 2 || rubs % 10 == 3 || rubs % 10 == 4)
          output += " рубля ";
        else
          output += " рублей ";
      }
      if (kops == 0) // если нет копеек
        output += "ровно";
      else {
        output += kops;
        if (5 <= kops && kops <= 20)
          output += " копеек";
        else if (kops % 10 == 1)
          output += " копейка";
        else if (kops % 10 == 2 || kops % 10 == 3 || kops % 10 == 4)
          output += " копейки";
        else
          output += " копеек";
      }
      return output;
    }
    static void Main(string[] args) {
      int n = Custom.ReadInt("число n", 1, 9999); // ввод числа
      Console.WriteLine(GetMoney(n)); // вывод количества денег
      Custom.Exit(); // ожидание закрытия консоли пользователем
    }
  }

  public class Custom {
    public const int unused = Int32.MinValue; // константа для неиспользованных переменных
    public const int minInt = Int32.MinValue; // константа минимального числа для типа Int 
    public const int maxInt = Int32.MaxValue; // константа максмального числа для типа Int

    public static int ReadInt(string name, int min = minInt, int max = maxInt) {
      bool isInputGot = false; // переменная для вывода ошибки при необходимости
      int output = unused; // тут будет храниться введённое число
      do {
        if (isInputGot) Console.Write("Ошибка ввода! "); // вывод ошибки при повторном вводе

        if (min == minInt && max == maxInt) // ввод без ОДЗ
          Console.Write("Введите " + name + ": ");
        else if (min != minInt && max != maxInt) // ввод с ОДЗ
          Console.Write("Введите " + name + " (в промежутке от " + min + " до " + max + "): ");
        else if (min == minInt) // ввод числа до заданного
          Console.Write("Введите " + name + " (до " + max + "): ");
        else if (max == maxInt) // ввод числа от заданного
          Console.Write("Введите " + name + " (от " + min + "): ");

        string input = Console.ReadLine(); // ввод некоторой строки
        isInputGot = true; // изменение переменной для вывода ошибки при необходимости

        // перевод строки input в числовой output, если строка является числом
        if (int.TryParse(input, out int trash)) output = int.Parse(input);
      }
      while (output == unused || output < min || output > max);

      return output;
    }

    public static void Exit() { // ожидание закрытия консоли пользователем
      Console.Write("\nДля выхода из программы нажмите любую клавишу...");
      Console.ReadKey(true);
    }
  }
}
