using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab4Var1.Tests {
  [TestClass()]
  public class AlcoholTests {
    [TestMethod()]
    public void GetInfoTest() {
      bool isCorrect = true;
      Alcohol drink = new Alcohol();

      drink.volumeInMl = 600;
      drink.type = AlcoholType.beer;
      drink.degree = 4;

      if (drink.GetInfo() != "Алкоголь (пиво, объём 600 мл, крепость 4 градусов)")
        isCorrect = false;

      drink.type = AlcoholType.jaguar;
      drink.degree = 8;

      if (drink.GetInfo() != "Алкоголь (ягуар, объём 600 мл, крепость 8 градусов)")
        isCorrect = false;

      drink.type = AlcoholType.whiskey;
      drink.degree = 40;

      if (drink.GetInfo() != "Алкоголь (виски, объём 600 мл, крепость 40 градусов)")
        isCorrect = false;

      Assert.IsTrue(isCorrect);
    }
  }
  [TestClass()]
  public class SodaTests {
    [TestMethod()]
    public void GetInfoTest() {
      bool isCorrect = true;
      Soda drink = new Soda();

      drink.volumeInMl = 600;
      drink.type = SodaType.baikal;
      drink.bubbleCount = 135;

      if (drink.GetInfo() != "Газировка \"Байкал\" (объём 600 мл, содержит 135 пузырьков)")
        isCorrect = false;

      drink.type = SodaType.buratino;

      if (drink.GetInfo() != "Газировка \"Буратино\" (объём 600 мл, содержит 135 пузырьков)")
        isCorrect = false;

      drink.type = SodaType.fanta;

      if (drink.GetInfo() != "Газировка \"Фанта\" (объём 600 мл, содержит 135 пузырьков)")
        isCorrect = false;

      Assert.IsTrue(isCorrect);
    }
  }
  [TestClass()]
  public class JuiceTests {
    [TestMethod()]
    public void GetInfoTest() {
      bool isCorrect = true;
      Juice drink = new Juice();

      drink.volumeInMl = 500;
      drink.type = JuiceType.apple;
      drink.containsPulp = false;

      if (drink.GetInfo() != "Яблочный сок (объём 500 мл, не содержит мякоть)")
        isCorrect = false;

      drink.type = JuiceType.grape;
      drink.containsPulp = true;

      if (drink.GetInfo() != "Виноградный сок (объём 500 мл, содержит мякоть)")
        isCorrect = false;

      drink.type = JuiceType.orange;

      if (drink.GetInfo() != "Апельсиновый сок (объём 500 мл, содержит мякоть)")
        isCorrect = false;

      Assert.IsTrue(isCorrect);
    }
  }
}