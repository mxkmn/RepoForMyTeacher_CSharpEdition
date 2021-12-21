using System;
using System.Drawing;

namespace CourseWork {
  class Particle {
    public int Radius;
    public float X, Y, Direction, Speed, Life;
    private static readonly Random rand = new Random();

    public Particle(int x, int y, int generationType) {
      if (generationType == 0) {
        X = x/2;
        Y = y/2;
      }
      else if (generationType == 1) {
        X = rand.Next(x);
        Y = rand.Next(y);
      }
      else { // (generationType == 2)
        X = x;
        Y = y;
      }

      if (generationType == 2) {
        Direction = 270;
        Speed = 2;
        Radius = 4;
        Life = 100;
      }
      else { // создание рандомных параметров
        Direction = rand.Next(360);
        Speed = rand.Next(1, 10);
        Radius = rand.Next(2, 10);
        Life = rand.Next(20, 100);
      }
    }
    public void Move() {
      var directionInRadians = Direction / 180 * Math.PI;
      X += (float)(Speed * Math.Cos(directionInRadians));
      Y -= (float)(Speed * Math.Sin(directionInRadians));
    }
    public void DrawInfo(Graphics g, int _x, int _y) {
      var x = Math.Abs(X - _x);
      var y = Math.Abs(Y - _y);
      var lenght = Math.Sqrt(x * x + y * y);

      if (lenght < Radius) {
        var b = new SolidBrush(Color.SkyBlue);
        g.FillRectangle(b, X, Y, 50, 50);

        StringFormat stringFormat = new StringFormat();
        stringFormat.Alignment = StringAlignment.Center;
        stringFormat.LineAlignment = StringAlignment.Center;
        g.DrawString("X: " + (int)X, new Font("Arial", 10), Brushes.Black, X + 25, Y + 10, stringFormat);
        g.DrawString("Y: " + (int)Y, new Font("Arial", 10), Brushes.Black, X + 25, Y + 25, stringFormat);
        g.DrawString("Life: " + (int)Life, new Font("Arial", 10), Brushes.Black, X + 25, Y + 40, stringFormat);
      }
    }
    public void Draw(Graphics g, bool debug) {
      int alpha = (int)(Math.Min(1f, Life / 100) * 255);
      var color = Color.FromArgb(alpha, Color.Black);
      var b = new SolidBrush(color); // создали кисть для рисования

      g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2); // отрисовали
      if (debug) {
        var directionInRadians = -Direction / 180 * Math.PI;
        g.DrawLine(new Pen(Color.OrangeRed, 2), X, Y, (int)(X + Math.Cos(directionInRadians) * 5), (int)(Y + Math.Sin(directionInRadians) * 5));
      }
      b.Dispose(); // почистили объект из памяти, чтобы сборщику мусора было попроще
    }
    public float Feed() {
      float life = Life;
      Life = 0;
      return life;
    }
  }
}
