using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork {
  public partial class DrawerForm : Form {
    List<Particle> particles = new List<Particle>(); // список частиц
    public DrawerForm() {
      InitializeComponent();

      drawing.Image = new Bitmap(drawing.Width, drawing.Height);

      for (var i = 0; i < 500; ++i) { // генерация 500 частиц
        var particle = new Particle();

        // перенос частиц в центр изображения
        particle.X = drawing.Image.Width / 2;
        particle.Y = drawing.Image.Height / 2;

        particles.Add(particle); // добавляю в список
      }
    }
    private void UpdateParticles() {
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
    private void OnTick(object sender = null, EventArgs e = null) {
      UpdateParticles(); // каждый тик обновляем частицы

      using (var g = Graphics.FromImage(drawing.Image)) {
        g.Clear(Color.White);
        Render(g); // рендерим систему
      }

      drawing.Invalidate();
    }
  }
}
