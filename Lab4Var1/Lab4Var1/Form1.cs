using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4Var1 {
  public partial class Form1 : Form {
    readonly ToolTip helperTip = new ToolTip(); // штука для всплывающей подсказки
    readonly List<Drink> drinksList = new List<Drink>(); // массив напитков внутри автомата
    public Form1() {
      InitializeComponent();

      AddDrinks_Click(null, null); // добавляем какие-то напитки при запуске
    }
    private void AddDrinks_Click(object sender, EventArgs e) { // добавление напитков в очередь автомата
      Random rnd = new Random();
      for (var i = 0; i < 3; ++i) { // добавляем 3 напитка
        switch (rnd.Next() % 3) { // случайно выбираем тип
          case 0:
            this.drinksList.Add(Juice.GenerateRandomly());
            break;
          case 1:
            this.drinksList.Add(Soda.GenerateRandomly());
            break;
          case 2:
            this.drinksList.Add(Alcohol.GenerateRandomly());
            break;
        }
      }

      RedrawQueue(); // перерисовываем очередь
      if (newDrink.BackgroundImage == null) // если напиток не выдан
        buyDrink.Enabled = true; // позволяем купить новый (нужно в случае, когда покупки были заблокированы из-за отсутствия напитков в автомате)
    }
    private void RedrawQueue() { // перерисовка очереди
      DrinksCounter.Text = "Количество доступных напитков: " + drinksList.Count;
      List<PictureBox> pictureBoxList = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
      for (var i = 0; i < 5; ++i) { // проходим по всем 5 лейблам
        if (drinksList.Count > i) { // если напиток на этой позиции существует, показываем
          pictureBoxList[i].BackgroundImage = drinksList[i].GetPicture();
          helperTip.SetToolTip(pictureBoxList[i], drinksList[i].GetInfo());
        }
        else { // если напиток на этой позиции не существует, очищаем лейбл
          pictureBoxList[i].BackgroundImage = null;
          helperTip.SetToolTip(pictureBoxList[i], null);
        }
      }
    }
    private void BuyDrink_Click(object sender, EventArgs e) { // произведена покупка напитка
      // рисуем в большом лейбле
      newDrink.BackgroundImage = drinksList[0].GetPicture();
      helperTip.SetToolTip(newDrink, drinksList[0].GetInfo());

      drinksList.RemoveAt(0); // удаляем напиток в очереди
      RedrawQueue(); // перерисовываем очередь

      // позволяем забрать напиток
      buyDrink.Enabled = false;
      getDrink.Enabled = true;
    }

    private void GetDrink_Click(object sender, EventArgs e) { // напиток решили забрать
      // обнуляем большой лейбл
      newDrink.BackgroundImage = null;
      helperTip.SetToolTip(newDrink, null);

      // позволяем купить напиток
      getDrink.Enabled = false;
      if (drinksList.Count != 0)
        buyDrink.Enabled = true;
    }
  }
}
