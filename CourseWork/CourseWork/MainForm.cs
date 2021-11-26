using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork {
  public partial class MainForm : Form {
    List<Particle> particles = new List<Particle>(); // список частиц
    public MainForm() {
      InitializeComponent();
      picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

      for (var i = 0; i < 500; ++i) { // генерация 500 частиц
        var particle = new Particle();

        // перенос частиц в центр изображения
        particle.X = picDisplay.Image.Width / 2;
        particle.Y = picDisplay.Image.Height / 2;

        particles.Add(particle); // добавляю в список
      }
    }
    private void UpdateState() {
      foreach (var particle in particles) {
        var directionInRadians = particle.Direction / 180 * Math.PI;
        particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
        particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
      }
    }
    private void Render(Graphics g) { // функция рендеринга
      // утащили сюда отрисовку частиц
      foreach (var particle in particles) {
        particle.Draw(g);
      }
    }
    private void timer1_Tick(object sender, EventArgs e) {
      UpdateState(); // каждый тик обновляем систему

      using (var g = Graphics.FromImage(picDisplay.Image)) {
        g.Clear(Color.White);
        Render(g); // рендерим систему
      }

      picDisplay.Invalidate();
    }
  }
}
