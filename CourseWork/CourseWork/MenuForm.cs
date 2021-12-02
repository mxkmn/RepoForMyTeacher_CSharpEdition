using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork {
  public partial class MenuForm : Form {
    public MenuForm() {
      InitializeComponent();
      new DrawerForm().ShowDialog(); // вот эта хрень должна быть убрана. когда-нибудь...
    }

    private void drawerButton_Click(object sender, EventArgs e) {
      new DrawerForm().ShowDialog();
    }
  }
}
