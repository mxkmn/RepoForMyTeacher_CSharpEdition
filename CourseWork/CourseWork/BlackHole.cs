using System;
using System.Drawing;

namespace CourseWork {
  class BlackHole {
    public int X, Y, Eaten;
    public float Radius = 20, Heaviness = 0;

    public BlackHole(int x, int y) {
      X = x;
      Y = y;
    }
    public void Draw(Graphics g) {
      var b = new SolidBrush(Color.Black); // создали кисть для рисования
      g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2); // отрисовали
      b.Dispose(); // почистили объект из памяти, чтобы сборщику мусора было попроще
    }
    public void DrawInfo(Graphics g) {
      StringFormat stringFormat = new StringFormat();
      stringFormat.Alignment = StringAlignment.Center;
      stringFormat.LineAlignment = StringAlignment.Center;

      g.DrawString("" + Eaten, new Font("Arial", 10), Brushes.White, X, Y, stringFormat);
    }
    public void Eat(Particle p) {
      Heaviness += p.Feed() / 100;
      Radius = 20 + (float)Math.Sqrt(Heaviness);
      Eaten++;
    }
    public bool IsTouching(Particle particle) {
      var x = Math.Abs(particle.X - X);
      var y = Math.Abs(particle.Y - Y);
      var lenght = Math.Sqrt(x * x + y * y);

      return lenght < Radius;
    }
  }
}
