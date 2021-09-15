using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Num2Var14 {
  public class Program {
    public static bool IsBetween(int first, int second, int third) { // вывод, стоят ли числа рядом
      return (first == second - 1 && second == third - 1);
    }
    public static string GetTriplet(int[] unsorted, int len) { // вывод строки с инф. о 
      // сортируем массив
      int[] sorted = new int[len];
      Array.Copy(unsorted, 0, sorted, 0, len);
      Array.Sort(sorted);

      // инициализируем переменные
      int v1 = Custom.unused, v2 = Custom.unused, v3 = Custom.unused;

      // добавляем в переменные данные и обрабатываем их
      for (int i = 0; i < len; i++) {
        if (v3 != sorted[i]) { // проверка на разницу последних чисел
          // при разнице смещаем значения влево и добавляем в v3 новое число
          v1 = v2; v2 = v3; v3 = sorted[i];

          if (v1 != Custom.unused) { // в случае, если все переменные заполнены
            if (IsBetween(v1, v2, v3)) { // проверяем их на соседство
              // получаем порядковые номера найденых соседей
              int f1 = Array.IndexOf(unsorted, v1) + 1;
              int f2 = Array.IndexOf(unsorted, v2) + 1;
              int f3 = Array.IndexOf(unsorted, v3) + 1;

              // вывод первого вхождения при нахождении
              return ("Тройка чисел найдена, их порядковые номера " + f1 + ", " + f2 + " и " + f3);
            }
          }
        }
      }

      // вывод исключения при ненаходе
      return "Тройка чисел не найдена";
    }
    static void Main(string[] args) {
      int n = Custom.ReadInt("количество натуральных чисел", 0);

      int[] nums = new int[n];
      for (int i = 0; i < n; i++) {
        nums[i] = Custom.ReadInt("число " + (i + 1), 1);
      }

      Console.WriteLine(GetTriplet(nums, n));

      Custom.Exit();
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
      Console.ReadKey();
    }
  }
}
