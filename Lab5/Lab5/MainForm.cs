using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab5 {
  public partial class MainForm : Form {
    int score = 0;
    List<BaseObject> drawingObjects = new List<BaseObject>();
    Player player;
    Marker marker;
    Target target1 = new Target(0, 0, 0);
    Target target2 = new Target(0, 0, 0);
    BlackLabel blackLabel;
    public MainForm() {
      InitializeComponent();
      
      // инициализируем объекты
      player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);
      target1.GenerateRandomly(pbMain.Width, pbMain.Height);
      target2.GenerateRandomly(pbMain.Width, pbMain.Height);
      blackLabel = new BlackLabel(pbMain.Width / 2, pbMain.Height);

      // инициализируем делегаты игрока
      player.OnOverlap = (obj) => {
        if (!(obj is BlackLabel))
          txtLog.Text = $"[{DateTime.Now:mm:ss:ff}] Игрок пересёкся с {obj}\n" + txtLog.Text;
      };
      player.OnMarkerOverlap = (m) => {
        drawingObjects.Remove(m);
        marker = null;
      };
      player.OnTargetOverlap = (t) => {
        score++;
        t.GenerateRandomly(pbMain.Width, pbMain.Height);
      };
      // инициализируем делегаты чёрной метки
      blackLabel.OnOverlap = (obj) => {
        obj.SetReverseColor(true);
      };
      blackLabel.OnNonOverlap = (obj) => {
        obj.SetReverseColor(false);
      };

      // добавляем объекты, которые нужно отрисовывать, в массив
      drawingObjects.Add(blackLabel);
      drawingObjects.Add(target1);
      drawingObjects.Add(target2);
      drawingObjects.Add(player);
    }
    
    private void MovePlayer(object sender = null, EventArgs e = null) { // Движение игрока
      if (marker != null) { // если маркер не удалён, смещаем игрока к нему
        float dx = marker.X - player.X;
        float dy = marker.Y - player.Y;

        float lenght = MathF.Sqrt(dx * dx + dy * dy);
        dx /= lenght;
        dy /= lenght;

        player.XModifier += dx * 0.45f;
        player.YModifier += dy * 0.45f;

        player.Angle = 90 - MathF.Atan2(player.XModifier, player.YModifier) * 180 / MathF.PI;
      }

      // уменьшаем скорость
      player.XModifier *= 0.9f;
      player.YModifier *= 0.9f;

      // сдвигаем игрока
      player.X += player.XModifier;
      player.Y += player.YModifier;
    }



    private void DrawPicture(object sender, PaintEventArgs e) {
      // подготовка полотна
      Graphics g = e.Graphics;
      g.Clear(Color.White);

      MovePlayer(); // движение игрока

      foreach (BaseObject obj in drawingObjects.ToList()) {
        // поиск и обработка пересечений с игроком
        if (!(obj is Player) && player.Overlaps(obj, g)) {
          player.Overlap(obj);
          obj.Overlap(player);
        }

        // поиск и обработка пересечений с чёрной областью
        if (!(obj is BlackLabel)) {
          if (blackLabel.Overlaps(obj, g))
            blackLabel.Overlap(obj);
          else
            blackLabel.NonOverlap(obj);
        }

        // перемещение объектов
        g.Transform = obj.GetPosition();
        obj.Draw(g);
      }

      lblScore.Text = $"Счёт: {score}";
    }
    private void UpdatePicture(object sender, EventArgs e) { // при тике таймера
      blackLabel.X = (float)((blackLabel.X + 2) % (pbMain.Width * 1.5));
      pbMain.Invalidate(); // вызов DrawPicture
    }
    private void PictureClicked(object sender, MouseEventArgs e) { // при нажатии мышкой
      if (marker == null) {
        marker = new Marker(0, 0, 0);
        drawingObjects.Add(marker);
      }
      marker.X = e.X;
      marker.Y = e.Y;
    }
  }
}