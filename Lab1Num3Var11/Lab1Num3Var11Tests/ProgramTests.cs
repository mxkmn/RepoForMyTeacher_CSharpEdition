using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1Num3Var11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Num3Var11.Tests {
  [TestClass()]
  public class ProgramTests {
    [TestMethod()]
    public void GetCharsFromWordTest1() {
      Assert.AreEqual("процес", Program.GetCharsFromWord("процессор"));
    }
    [TestMethod()]
    public void GetCharsFromWordTest2() {
      Assert.AreEqual("процеСс", Program.GetCharsFromWord("процеСсор"));
    }
    [TestMethod()]
    public void GetCharsFromWordTest3() {
      Assert.AreEqual("проц", Program.GetCharsFromWord("проц"));
    }
    [TestMethod()]
    public void GetCharsFromWordTest4() {
      Assert.AreEqual("new", Program.GetCharsFromWord("newnew"));
    }
  }
}