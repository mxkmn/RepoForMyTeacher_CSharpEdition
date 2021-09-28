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
      InitializeComponent();
    }
    private void DataProcessing() {

    }
    private void OnChange(object sender, EventArgs e) {
      DataProcessing();
    }
    private void OnPress(object sender, KeyEventArgs e) {
      DataProcessing();
    }
  }
}
