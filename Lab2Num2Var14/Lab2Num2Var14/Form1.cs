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
    private void nums_OnChange() {

    }

    private void nums_KeyDown(object sender, KeyEventArgs e) {
      nums_OnChange();
    }

    private void nums_TextChanged(object sender, EventArgs e) {
      nums_OnChange();
    }
  }
}
