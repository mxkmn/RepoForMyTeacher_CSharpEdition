using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Num3Var11 {
  public class Program {
    public static string GetCharsFromWord(string word) {
      string outWord = "";

      foreach (char c in word.ToCharArray()) { // перебор всех символов
        // добавление символа в строку, если ещё не встречался:
        if (!outWord.Contains(c)) outWord += c;
      }
      return outWord;
    }
    static void Main(string[] args) {
      // получаем первое слово
      string firstWord = "";
      do {
        Console.Write("Введите первое слово: ");
        firstWord = Console.ReadLine();
      } while (firstWord.Contains(' ') || firstWord == "");

      // добываем из слова все входящие в него символы
      string justChars = GetCharsFromWord(firstWord);
      
      // получаем второе слово
      string secondWord = "";
      do {
        Console.Write("Введите второе слово: ");
        secondWord = Console.ReadLine();
      } while (secondWord.Contains(' ') || secondWord == "");

      // перебираем символы, ищем во второй строке
      foreach (char c in justChars.ToCharArray()) { // перебор всех символов
        if (secondWord.Contains(c)) Console.Write("да "); // символ найден
        else Console.Write("нет "); // символ не найден
      }
      Console.WriteLine();

      Custom.Exit(); // ждём закрытия окна пользователем
    }
  }

  public class Custom {
    public static void Exit() { // ожидание закрытия консоли пользователем
      Console.Write("\nДля выхода из программы нажмите любую клавишу...");
      Console.ReadKey(true);
    }
  }
}
