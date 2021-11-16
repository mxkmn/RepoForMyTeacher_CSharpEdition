using Lab4Var1.Properties;
using System;
using System.Drawing;

namespace Lab4Var1 {
  public class Drink {
    protected static Random rnd = new Random();
    public int volumeInMl;
    public virtual String GetInfo() {
      return ("Напиток (объём " + volumeInMl + " мл)");
    }
    public virtual Image GetPicture() {
      return null;
    }
  }
  public enum JuiceType { apple, orange, grape };
  public class Juice : Drink {
    public JuiceType type = JuiceType.apple;
    public bool containsPulp = false;
    public static Juice GenerateRandomly() {
      return new Juice {
        volumeInMl = rnd.Next(5, 16) * 100, // от 500 до 1500 мл
        type = (JuiceType)rnd.Next(3), // выбираем тип
        containsPulp = rnd.Next(2) == 0 // true/false
      };
    }
    private String GetDescription() {
      switch (this.type) {
        case JuiceType.apple:
          return "Яблочный";
        case JuiceType.orange:
          return "Апельсиновый";
        case JuiceType.grape:
          return "Виноградный";
        default:
          return "Неизвестный тип";
      }
    }
    public override Image GetPicture() {
      switch (type) {
        case JuiceType.apple:
          return new Bitmap(Resources.apple);
        case JuiceType.orange:
          return new Bitmap(Resources.orange);
        case JuiceType.grape:
          return new Bitmap(Resources.grape);
        default:
          return null;
      }
    }
    public override String GetInfo() {
      return (GetDescription() + " сок (объём " + volumeInMl + " мл, " + (containsPulp ? "содержит" : "не содержит") + " мякоть)");
    }
  }
  public enum SodaType { baikal, fanta, buratino };
  public class Soda : Drink {
    public SodaType type = SodaType.baikal;
    public int bubbleCount = 0;
    public static Soda GenerateRandomly() {
      return new Soda {
        volumeInMl = rnd.Next(5, 16) * 100, // от 500 до 1500 мл
        type = (SodaType)rnd.Next(3), // выбираем тип
        bubbleCount = rnd.Next(501) // 0..500 пузырьков
      };
    }
    private String GetDescription() {
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
    public override Image GetPicture() {
      switch (type) {
        case SodaType.baikal:
          return new Bitmap(Resources.baikal);
        case SodaType.fanta:
          return new Bitmap(Resources.fanta);
        case SodaType.buratino:
          return new Bitmap(Resources.buratino);
        default:
          return null;
      }
    }
    public override String GetInfo() {
      return ("Газировка \"" + GetDescription() + "\" (объём " + volumeInMl + " мл, содержит " + bubbleCount + " пузырьков)");
    }
  }
  public enum AlcoholType { whiskey, jaguar, beer };
  public class Alcohol : Drink {
    public AlcoholType type;
    public int degree;
    public static Alcohol GenerateRandomly() {
      return new Alcohol {
        volumeInMl = rnd.Next(5, 16) * 100, // от 500 до 1500 мл
        type = (AlcoholType)rnd.Next(3), // выбираем тип
        degree = rnd.Next(4, 46) // 4..450 градусов
      };
    }
    private String GetDescription() {
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
    public override Image GetPicture() {
      switch (type) {
        case AlcoholType.whiskey:
          return new Bitmap(Resources.whiskey);
        case AlcoholType.jaguar:
          return new Bitmap(Resources.jaguar);
        case AlcoholType.beer:
          return new Bitmap(Resources.beer);
        default:
          return null;
      }
    }
    public override String GetInfo() {
      return ("Алкоголь (" + GetDescription() + ", объём " + volumeInMl + " мл, крепость " + degree + " градусов)");
    }
  }
}
