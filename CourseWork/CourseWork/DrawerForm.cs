using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork {
  public partial class DrawerForm : Form {
    List<Particle> particles = new List<Particle>(); // список частиц
    List<BlackHole> blackHoles = new List<BlackHole>(); // список частиц
    public DrawerForm() {
      InitializeComponent();

      drawing.Image = new Bitmap(drawing.Width, drawing.Height);
    }

    private void OnTick(object sender = null, EventArgs e = null) { // каждый тик
      UpdateParticles(); // обновляем частицы
      UpdateBlackHoles(); // обновляем чёрные дыры

      using (var g = Graphics.FromImage(drawing.Image)) {
        g.Clear(Color.White);

        foreach (var particle in particles) {
          particle.Draw(g);
        }
        foreach (var blackHole in blackHoles) { // сначала рисуем дыры
          blackHole.Draw(g);
        }
        foreach (var blackHole in blackHoles) { // потом текст, чтоб не было наслоения черноты на информацию
          StringFormat stringFormat = new StringFormat();
          stringFormat.Alignment = StringAlignment.Center;
          stringFormat.LineAlignment = StringAlignment.Center;

          g.DrawString("" + blackHole.Eaten, new Font("Arial", 10), Brushes.White, blackHole.X, blackHole.Y, stringFormat);
        }
      }

      drawing.Invalidate(); // отображаем рисунок
    }
    private void UpdateParticles() {
      if (particles.Count < 500) {
        var particle = new Particle(drawing.Image.Width / 2, drawing.Image.Height / 2);
        particles.Add(particle); // добавляю в список
      }
      foreach (var particle in particles) {
        particle.Life--; // уменьшаю здоровье
        if (particle.Life < 0) { // если здоровье кончилось
          particle.Reset();
        }
        else {
          var directionInRadians = particle.Direction / 180 * Math.PI;
          particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
          particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
        }
      }
    }
    private void UpdateBlackHoles() {
      foreach (var blackHole in blackHoles) {
        foreach (var particle in particles) {
          if (blackHole.IsTouching(particle))
            blackHole.Eat(particle);
        }
      }
    }



    private void MouseInteraction(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left)
        blackHoles.Add(new BlackHole(e.X, e.Y));
      if (e.Button == MouseButtons.Right) {
        for (int i = 0; i < blackHoles.Count; i++) {
          var blackHole = blackHoles[i];

          var x = Math.Abs(e.X - blackHole.X);
          var y = Math.Abs(e.Y - blackHole.Y);
          var lenght = Math.Sqrt(x * x + y * y);
          if (lenght < blackHole.Radius) {
            blackHoles.Remove(blackHole);
            i--;
          }
        }
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {

    }
  }
}
