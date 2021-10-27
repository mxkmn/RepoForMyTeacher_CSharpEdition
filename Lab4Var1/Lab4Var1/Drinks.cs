using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Var1 {
  public class Drink {
    public int volumeInMl = 0;
    public virtual String GetInfo() {
      return ("Напиток (объём " + volumeInMl + " мл)");
    }
  }
  public enum FruitType { apple, orange, grape };
  public class Juice : Drink {
    public FruitType type = FruitType.apple;
    public bool containsPulp = false;
    private new String GetType() {
      switch (this.type) {
        case FruitType.apple:
          return "Яблочный";
        case FruitType.orange:
          return "Апельсиновый";
        case FruitType.grape:
          return "Виноградный";
        default:
          return "Неизвестный тип";
      }
    }
    public override String GetInfo() {
      return (GetType() + " сок (объём " + volumeInMl + " мл, " + (containsPulp ? "содержит" : "не содержит") + " мякоть)");
    }
  }
  public enum SodaType { baikal, fanta, buratino };
  public class Soda : Drink {
    public SodaType type = SodaType.baikal;
    public int bubbleCount = 0;
    private new String GetType() {
      switch (type) {
        case SodaType.baikal:
          return "Байкал";
        case SodaType.fanta:
          return "Фанта";
        case SodaType.buratino:
          return "Буратино";
        default:
          return "Неизвестный тип";
      }
    }
    public override String GetInfo() {
      return ("Газировка \"" + GetType() + "\" (объём " + volumeInMl + " мл, содержит " + bubbleCount + " пузырьков)");
    }
  }
  public enum AlcoholType { whiskey, jaguar, beer };
  public class Alcohol : Drink {
    public AlcoholType type = AlcoholType.whiskey;
    public int degree = 0;
    private new String GetType() {
      switch (type) {
        case AlcoholType.whiskey:
          return "виски";
        case AlcoholType.jaguar:
          return "ягуар";
        case AlcoholType.beer:
          return "пиво";
        default:
          return "неизвестный тип";
      }
    }
    public override String GetInfo() {
      return ("Алкоголь (" + GetType() + ", объём " + volumeInMl + " мл, крепость " + degree + " градусов)");
    }
  }
}
