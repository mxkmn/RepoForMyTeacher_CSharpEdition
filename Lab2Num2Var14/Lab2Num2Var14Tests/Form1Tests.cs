using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2Num2Var14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Num2Var14.Tests {
  [TestClass()]
  public class Form1Tests {
    [TestMethod()]
    public void GetNTest1() {
      Assert.AreEqual("2-ка чисел 1231231231 найдена. Она была введена с 3 по 4 число.", Form1.GetN("123 21 1231231231 1231231231", 2));
    }
    [TestMethod()]
    public void GetNTest2() {
      Assert.AreEqual("Ошибка ввода!", Form1.GetN("123 вфы 1231231231 1231231231", 2));
    }
    [TestMethod()]
    public void GetNTest3() {
      Assert.AreEqual("Возможен ввод только натуральных чисел!", Form1.GetN("123 -21 1231231231 1231231231", 2));
    }
    [TestMethod()]
    public void GetNTest4() {
      Assert.AreEqual("3-ка чисел не найдена.", Form1.GetN("123 21 1231231231 1231231231", 3));
    }
  }
}