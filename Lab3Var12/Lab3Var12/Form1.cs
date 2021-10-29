using System;
using System.Windows.Forms;

namespace Lab3Var12 {
  public partial class Form1 : Form {
    private readonly Color color = new Color(); // создаём объект
    public Form1() { // при запуске программы
      InitializeComponent(); // инициализируем интерфейс
      UpdateLabels(); // модифицируем поля в соответствии с введёнными данными
    }
    private void UpdateLabels() { // вывод данных
      // отображаем текущий цвет в квадрате сверху
      colorSquare.BackColor = System.Drawing.Color.FromArgb(255, color.R, color.G, color.B);

      // изменение значений лейблов и изменяльщиков
      hLabel.Text = "H: " + color.H;
      sLabel.Text = "S: " + color.S; sChanger.Value = color.S;
      vLabel.Text = "V: " + color.V; vChanger.Value = color.V;
      rLabel.Text = "R: " + color.R; rChanger.Value = color.R;
      gLabel.Text = "G: " + color.G; gChanger.Value = color.G;
      bLabel.Text = "B: " + color.B; bChanger.Value = color.B;
    }
    private void ChangeRgb(object sender, EventArgs e) { // меняем RGB значения в зависимости от ввода
      color.R = decimal.ToInt32(rChanger.Value);
      color.G = decimal.ToInt32(gChanger.Value);
      color.B = decimal.ToInt32(bChanger.Value);
      UpdateLabels();
    }
    private void KeyPressedRgb(object sender, KeyEventArgs e) { // кнопка нажата в полях R/G/B
      if (e.KeyCode == Keys.Enter) // при нажатии Enter
        ChangeRgb(null, null); // устанавливаем введённые значения
    }
    private void ChangeHsv(object sender, EventArgs e) { // меняем SV значения в зависимости от ввода
      color.S = decimal.ToInt32(sChanger.Value);
      color.V = decimal.ToInt32(vChanger.Value);
      UpdateLabels();
    }
    private void KeyPressedHsv(object sender, KeyEventArgs e) { // кнопка нажата в полях S/V
      if (e.KeyCode == Keys.Enter) // при нажатии Enter
        ChangeHsv(null, null); // устанавливаем введённые значения
    }
  }
}
