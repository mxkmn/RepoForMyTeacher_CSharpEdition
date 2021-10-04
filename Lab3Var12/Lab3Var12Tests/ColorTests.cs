using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3Var12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Var12.Tests {
  [TestClass()]
  public class ColorTests {
    [TestMethod()]
    public void ColorsCreateTest1() {
      Assert.ThrowsException<System.ArgumentException>(() => new Color(ColorModels.HSV, 100, 100, 101));
    }
    [TestMethod()]
    public void ColorsCreateTest2() {
      Assert.ThrowsException<System.ArgumentException>(() => new Color(ColorModels.HSV, 100, 100, -1));
    }
    [TestMethod()]
    public void ColorsCreateTest3() {
      Assert.ThrowsException<System.ArgumentException>(() => new Color(ColorModels.RGB, 100, 100, 256));
    }
    [TestMethod()]
    public void ColorsCreateTest4() {
      Assert.ThrowsException<System.ArgumentException>(() => new Color(ColorModels.RGB, -101, 100, 100));
    }
    [TestMethod()]
    public void ColorsCreateTest5() {
      Assert.ThrowsException<System.ArgumentException>(() => new Color(ColorModels.HSV, 361, -100, 0));
    }
    [TestMethod()]
    public void ColorsCreateTest6() {
      Assert.ThrowsException<System.ArgumentException>(() => new Color(ColorModels.HSV, -1, 100, 100));
    }
    [TestMethod()]
    public void ColorsCreateTest7() {
      Color color = new Color();
      Assert.AreEqual(180, color.H);
    }
    [TestMethod()]
    public void ColorsCreateTest8() {
      Color color = new Color(ColorModels.HSV, 100, 100, 0);
      Assert.AreEqual(100, color.S);
    }
    [TestMethod()]
    public void ColorsCreateTest9() {
      Color color = new Color(ColorModels.RGB, 100, 255, 0);
      Assert.AreEqual(255, color.G);
    }
  }
}