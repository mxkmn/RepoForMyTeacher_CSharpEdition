using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Var12 {
  public partial class Form1 : Form {
    Color color = new Color();
    public Form1() {
      InitializeComponent();
      UpdateLabels();
    }
    private void UpdateLabels() {
      colorSquare.BackColor = System.Drawing.Color.FromArgb(255, color.R, color.G, color.B);

      hLabel.Text = "H: " + color.H;
      sLabel.Text = "S: " + color.S;
      vLabel.Text = "V: " + color.V;
      rLabel.Text = "R: " + color.R;
      gLabel.Text = "G: " + color.G;
      bLabel.Text = "B: " + color.B;

      ChangeNumericLabels(0, 255, color.R, rBetween, rChanger);
      ChangeNumericLabels(0, 255, color.G, gBetween, gChanger);
      ChangeNumericLabels(0, 255, color.B, bBetween, bChanger);

      ChangeNumericLabels(0, 100, color.S, sBetween, sChanger);
      ChangeNumericLabels(0, 100, color.V, vBetween, vChanger);
    }
    private void ChangeNumericLabels(int min, int max, int current, System.Windows.Forms.Label label, System.Windows.Forms.NumericUpDown box) {
      int from = min - current;
      int to = max - current;

      box.Minimum = from;
      box.Maximum = to;
      box.Value = 0;
      label.Text = "от " + from + " до " + to;
    }
    private void ChangeRgb(object sender, EventArgs e) {
      color.R = (int)rChanger.Value + color.R;
      color.G = (int)gChanger.Value + color.G;
      color.B = (int)bChanger.Value + color.B;
      UpdateLabels();
    }
    private void ChangeHsv(object sender, EventArgs e) {
      color.S = (int)sChanger.Value + color.S;
      color.V = (int)vChanger.Value + color.V;
      UpdateLabels();
    }
  }
}
