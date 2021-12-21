using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork {
  public partial class DrawerForm : Form {
    List<Particle> particles = new List<Particle>(); // список частиц
    List<BlackHole> blackHoles = new List<BlackHole>(); // список частиц
    Analyzer analyzer = new Analyzer();

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
            blackHole.DrawInfo(g);
          }
        }
      }
      drawing.Invalidate(); // отображаем рисунок
    }
    public void PrintByteArray(byte[] bytes) {
      var sb = new StringBuilder("new byte[] { ");
      foreach (var b in bytes) {
        sb.Append(b + ", ");
      }
      sb.Append("}");
      Console.WriteLine(sb.ToString());
      Console.WriteLine("\n\n\n");
    }
    private void UpdateParticles() {
      if (_generationType != 2) {
        if (particles.Count < 500) {
          Particle particle = new Particle(drawing.Image.Width, drawing.Image.Height, _generationType);
          particles.Add(particle); // добавляю в список
        }
      }
      else {
        byte[] rawData = analyzer.getRawData();
        for (int i = 0; i < rawData.Length; i++) {
          Particle particle = new Particle(5+i*10, 260-rawData[i], _generationType);
          particles.Add(particle); // добавляю в список
        }
      }
      for (int i = particles.Count-1; i > -1; i--) {
        var particle = particles[i];

        particle.Life -= _generationType == 2 ? 4 : 1; // уменьшаю здоровье
        if (particle.Life < 0) // если здоровье кончилось
          particles.Remove(particle);
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
