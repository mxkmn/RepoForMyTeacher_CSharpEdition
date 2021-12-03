using System;
using System.Drawing;

namespace CourseWork {
  class BlackHole {
    public int X, Y;
    public float Radius;

    public BlackHole(int x, int y) {
      X = x;
      Y = y;
      Radius = 20;
    }
    public void Draw(Graphics g) {
      float radius = 5 + Radius;

      var b = new SolidBrush(Color.Black); // создали кисть для рисования
      g.FillEllipse(b, X - radius, Y - radius, radius * 2, radius * 2); // отрисовали
      b.Dispose(); // почистили объект из памяти, чтобы сборщику мусора было попроще
    }
    public void Eat(Particle p) {
      Radius += p.Feed();
    }
  }
}
