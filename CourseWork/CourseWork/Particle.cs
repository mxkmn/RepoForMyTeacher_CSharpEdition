using System;
using System.Drawing;

namespace CourseWork {
  class Particle {
    public int Radius, CenterX, CenterY;
    public float X, Y, Direction, Speed, Life;
    private static readonly Random rand = new Random();

    public Particle(int centerX, int centerY) {
      CenterX = centerX;
      CenterY = centerY;
      Reset();
    }
    public void Reset(float? x = null, float? y = null) {
      // перенос частицы в центр изображения или куда-то ещё
      X = x == null ? CenterX : (float)x;
      Y = y == null ? CenterY : (float)y;

      // создание рандомных параметров
      Direction = rand.Next(360);
      Speed = rand.Next(1, 10);
      Radius = rand.Next(2, 10);
      Life = rand.Next(20, 100);
    }
    public void Draw(Graphics g) {
      // рассчитываем коэффициент прозрачности по шкале от 0 до 1.0
      float k = Math.Min(1f, Life / 100);
      // рассчитываем значение альфа канала в шкале от 0 до 255
      // по аналогии с RGB, он используется для задания прозрачности
      int alpha = (int)(k * 255);

      // создаем цвет из уже существующего, но привязываем к нему еще и значение альфа канала
      var color = Color.FromArgb(alpha, Color.Black);


      var b = new SolidBrush(color); // создали кисть для рисования
      g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2); // отрисовали
      b.Dispose(); // почистили объект из памяти, чтобы сборщику мусора было попроще
    }
  }
}
