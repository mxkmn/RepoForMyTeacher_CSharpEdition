using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Num1Var12.Tests {
  [TestClass()]
  public class Form1Tests {
    [TestMethod()]
    public void GetMoneyTest1() {
      Assert.AreEqual("15 рублей ровно", Logic.GetMoney(1500));
    }
    [TestMethod()]
    public void GetMoneyTest2() {
      Assert.AreEqual("1 копейка", Logic.GetMoney(1));
    }
    [TestMethod()]
    public void GetMoneyTest3() {
      Assert.AreEqual("99 рублей 99 копеек", Logic.GetMoney(9999));
    }
    [TestMethod()]
    public void GetMoneyTest4() {
      Assert.AreEqual("1 рубль 1 копейка", Logic.GetMoney(101));
    }
  }
}