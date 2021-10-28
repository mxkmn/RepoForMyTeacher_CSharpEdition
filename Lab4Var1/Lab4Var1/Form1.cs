using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Var1 {
  public partial class Form1 : Form {
    ToolTip helperTip = new ToolTip();
    List<Drink> drinksList = new List<Drink>();
    public Form1() {
      InitializeComponent();

      AddDrinks_Click(null, null);
    }
    private void AddDrinks_Click(object sender, EventArgs e) {
      var rnd = new Random();
      for (var i = 0; i < 3; ++i) {
        switch (rnd.Next() % 3) {
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

      if (drinksList.Count != 0) {
        RedrawQueue();
        if (newDrink.BackgroundImage == null)
          buyDrink.Enabled = true;
      }
    }
    private void RedrawQueue() {
      DrinksCounter.Text = "Количество доступных напитков: " + drinksList.Count;
      List<PictureBox> pictureBoxList = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
      for (var i = 0; i < 5; ++i) {
        if (drinksList.Count > i) {
          pictureBoxList[i].BackgroundImage = drinksList[i].GetPicture();
          helperTip.SetToolTip(pictureBoxList[i], drinksList[i].GetInfo());
        }
        else {
          pictureBoxList[i].BackgroundImage = null;
          helperTip.SetToolTip(pictureBoxList[i], null);
        }
      }
    }
    private void buyDrink_Click(object sender, EventArgs e) {
      newDrink.BackgroundImage = drinksList[0].GetPicture();
      helperTip.SetToolTip(newDrink, drinksList[0].GetInfo());

      drinksList.RemoveAt(0);
      RedrawQueue();

      buyDrink.Enabled = false;
      getDrink.Enabled = true;
    }

    private void getDrink_Click(object sender, EventArgs e) {
      newDrink.BackgroundImage = null;
      helperTip.SetToolTip(newDrink, null);

      getDrink.Enabled = false;
      if (drinksList.Count != 0)
        buyDrink.Enabled = true;
    }
  }
}
