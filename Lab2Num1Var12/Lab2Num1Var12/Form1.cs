using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Num1Var12 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }
    private void numData_Changed(object sender, EventArgs e) {
      outLabel.Text = Convert.ToString(this.numData.Value);
    }
  }
}
