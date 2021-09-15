using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1Num1Var12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Num1Var12.Tests {
  [TestClass()]
  public class ProgramTests {
    [TestMethod()]
    public void GetMoneyTest1() {
      Assert.AreEqual("15 рублей ровно", Program.GetMoney(1500));
    }
    [TestMethod()]
    public void GetMoneyTest2() {
      Assert.AreEqual("1 копейка", Program.GetMoney(1));
    }
    [TestMethod()]
    public void GetMoneyTest3() {
      Assert.AreEqual("99 рублей 99 копеек", Program.GetMoney(9999));
    }
  }
}