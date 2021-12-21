using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork {
  public partial class DrawerForm : Form {
    List<Particle> particles = new List<Particle>(); // список частиц
    List<BlackHole> blackHoles = new List<BlackHole>(); // список частиц
    bool _debug = false;
    int _ticks = 0, _updateSpeed, _generationType;
    public DrawerForm() {
      InitializeComponent();

      drawing.Image = new Bitmap(drawing.Width, drawing.Height);

      radioButton1.Checked = true;
      // подтягивание инфы из интерфейса
      OnSpeedChange(null, null);
      OnDebugChange(null, null);
    }

    private void OnTick(object sender = null, EventArgs e = null) { // каждый тик
      _ticks++;
      if ((_ticks / _updateSpeed > 0) || (sender.Equals(tickButton))) {
        _ticks %= _updateSpeed;

        UpdateParticles(); // обновляем частицы
        UpdateBlackHoles(); // обновляем чёрные дыры

        using (var g = Graphics.FromImage(drawing.Image)) {
          g.Clear(Color.White);

          foreach (var particle in particles) { // сначала рисуем частицы
            particle.Draw(g, _debug);
          }
          foreach (var blackHole in blackHoles) { // потом дыры
            blackHole.Draw(g);
          }
          foreach (var blackHole in blackHoles) { // потом текст, чтоб не было наслоения черноты на информацию
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString("" + blackHole.Eaten, new Font("Arial", 10), Brushes.White, blackHole.X, blackHole.Y, stringFormat);
          }
        }
      }
      drawing.Invalidate(); // отображаем рисунок
    }
    private void MouseDebug(object sender, MouseEventArgs e) {
      if (_debug) {
        int x = e.X, y = e.Y;
        using (var g = Graphics.FromImage(drawing.Image)) {
          foreach (var particle in particles)
            particle.DrawInfo(g, x, y);
        }
        drawing.Invalidate(); // отображаем рисунок
      }
    }
    private void UpdateParticles() {
      if (particles.Count < 500) {
        var particle = new Particle(drawing.Image.Width / 2, drawing.Image.Height / 2);
        particles.Add(particle); // добавляю в список
      }
      foreach (var particle in particles) {
        particle.Life--; // уменьшаю здоровье
        if (particle.Life < 0) // если здоровье кончилось
          particle.Reset();
        else
          particle.Move();
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
    private void OnDebugChange(object sender, EventArgs e) {
      _debug = debugCheckBox.Checked;
    }
    private void OnSpeedChange(object sender, EventArgs e) {
      _updateSpeed = speedBar.Maximum - speedBar.Value;
      if (_updateSpeed == speedBar.Maximum)
        _updateSpeed = -1; // полная остановка
      else
        _updateSpeed = (int)Math.Pow(2, _updateSpeed);
    }
    private void GenerateInCenter(object sender, EventArgs e) {
      _generationType = 0;
    }
    private void GenerateEverywhere(object sender, EventArgs e) {
      _generationType = 1;
    }
    private void GenerateBySound(object sender, EventArgs e) {
      _generationType = 2;
    }
  }
}
