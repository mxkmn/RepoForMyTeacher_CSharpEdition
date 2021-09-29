using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Num2Var14 {
  public partial class Form1 : Form {
    public Form1() {
      int csharpIsShit = decimal.ToInt32(Properties.Settings.Default.equalNumsSaved);
      InitializeComponent();
      numsRow.Text = Properties.Settings.Default.numsRowSaved;
      equalNums.Value = csharpIsShit;
      DataProcessing();
    }
    public static string GetN(string numsStr, int equals) {
      int lastNum = Int32.MinValue;
      int sameNums = Int32.MinValue;
      bool isFound = false;
      string outStr = "";

      string[] nums = numsStr.Split();
      for (int i = 0; i < nums.Length; i++) {
        if (!int.TryParse(nums[i], out int newNum))
          return "Ошибка ввода!";
        else if (newNum < 1)
          return "Возможен ввод только натуральных чисел!";

        if (lastNum == newNum) // число идентично прошлому
          sameNums++;
        else { // число не идентично прошлому
          lastNum = newNum;
          sameNums = 1;
        }

        if (sameNums == equals && !isFound) { // найдена последовательность из n одинаковых чисел
          isFound = true;
          outStr = (equals + "-ка чисел " + lastNum + " найдена. Она была введена с " + (i - equals + 2) + " по " + (i + 1) + " число.");
        }
      }

      if (isFound)
        return outStr;
      else
        return (equals + "-ка чисел не найдена."); // исключение при ненахождении
    }
    private void DataProcessing() {
      if (numsRow.Text == "")
        outText.Text = "Ничего не введено";
      else {
        outText.Text = GetN(numsRow.Text, decimal.ToInt32(equalNums.Value));
        Properties.Settings.Default.numsRowSaved = numsRow.Text;
      }  
      Properties.Settings.Default.equalNumsSaved = equalNums.Value;
      Properties.Settings.Default.Save();
    }
    private void OnChange(object sender, EventArgs e) {
      DataProcessing();
    }
    private void OnPress(object sender, KeyEventArgs e) {
      DataProcessing();
    }
    private void ClearData(object sender, EventArgs e) {
      numsRow.Text = "";
      DataProcessing();
    }
    private void PrintInfo(object sender, EventArgs e) {
      MessageBox.Show("Задача на For – вариант 14. Дана последовательность натуральных чисел. Определить, есть ли в последовательности хотя бы одна n-ка одинаковых “соседних” чисел (n и элементы последовательности вводятся с клавиатуры). В случае положительного ответа определить порядковые номера чисел первой из таких пар.");
    }
  }
}
