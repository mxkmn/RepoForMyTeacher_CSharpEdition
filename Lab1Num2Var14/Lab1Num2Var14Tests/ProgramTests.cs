using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1Num2Var14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Num2Var14.Tests {
  [TestClass()]
  public class ProgramTests {
    [TestMethod()]
    public void IsBetweenTest1() {
      //Assert.AreEqual(false, Program.IsBetween(6, 3, 4));
    }
    [TestMethod()]
    public void IsBetweenTest2() {
      //Assert.AreEqual(true, Program.IsBetween(4, 5, 6));
    }
    [TestMethod()]
    public void GetTripletTest1() {
     // Assert.AreEqual("Тройка чисел найдена, их порядковые номера 3, 1 и 5", Program.GetTriplet(new int[] { 6, 3, 5, 6, 7 }, 5));
    }
    [TestMethod()]
    public void GetTripletTest2() {
      //Assert.AreEqual("Тройка чисел не найдена", Program.GetTriplet(new int[] { 1, 2 }, 2));
    }
  }
}