using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Num2Var14.Tests {
  [TestClass()]
  public class Form1Tests {
    [TestMethod()]
    public void GetNTest1() {
      Assert.AreEqual("2-ка чисел 1231231231 найдена. Она была введена с 3 по 4 число.", Logic.GetN("123 21 1231231231 1231231231", 2));
    }
    [TestMethod()]
    public void GetNTest2() {
      Assert.AreEqual("Ошибка ввода!", Logic.GetN("123 вфы 1231231231 1231231231", 2));
    }
    [TestMethod()]
    public void GetNTest3() {
      Assert.AreEqual("Возможен ввод только натуральных чисел!", Logic.GetN("123 -21 1231231231 1231231231", 2));
    }
    [TestMethod()]
    public void GetNTest4() {
      Assert.AreEqual("3-ка чисел не найдена.", Logic.GetN("123 21 1231231231 1231231231", 3));
    }
  }
}