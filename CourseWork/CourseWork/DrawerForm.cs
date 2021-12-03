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
    List<BlackHole> blackHoles = new List<BlackHole>(); // список частиц
    public DrawerForm() {
      InitializeComponent();

      drawing.Image = new Bitmap(drawing.Width, drawing.Height);
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

        foreach (var particle in particles) {
          particle.Draw(g);
        }
        foreach (var blackHole in blackHoles) {
          blackHole.Draw(g);
        }
      }

      //drawing.Invalidate();
    }
    private void MouseInteraction(object sender, MouseEventArgs e) {
      blackHoles.Add(new BlackHole(e.X, e.Y));
    }
  }
}
