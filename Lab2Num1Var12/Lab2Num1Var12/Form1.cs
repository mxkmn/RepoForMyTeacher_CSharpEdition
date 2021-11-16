using System;
using System.Windows.Forms;

namespace Lab2Num1Var12 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      numData.Value = Properties.Settings.Default.savedNumData;
      ChangeText();
    }
    private void ChangeText() { // логика
      outLabel.Text = Logic.GetMoney(Decimal.ToInt32(this.numData.Value)); // вывод на лейбл

      // сохранение данных
      Properties.Settings.Default.savedNumData = this.numData.Value;
      Properties.Settings.Default.Save();
    }
    private void numData_Changed(object sender, EventArgs e) { // при изменении поля
      ChangeText();
    }
    private void numData_KeyUp(object sender, KeyEventArgs e) { // при нажатии кнопки (ввода данных)
      ChangeText();
    }
    private void PrintInfo(object sender, EventArgs e) {
      MessageBox.Show("Задача на If – вариант 12. Дано натуральное число 1 ≤ n ≤ 9999, определяющее стоимость товара в копейках. Выразить стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей 5 копеек, 1 рубль ровно и т. п.");
    }
  }
  public class Logic {
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
  }
}
