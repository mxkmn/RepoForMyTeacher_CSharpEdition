using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class Player : BaseObject {
    public float vX, vY;
    public Player(float x, float y, float angle) : base(x, y, angle) { }
    public override void Draw(Graphics g) {
      if (isColorReversed) {
        g.FillEllipse(new SolidBrush(Color.White), -15, -15, 30, 30);
        g.DrawEllipse(new Pen(Color.DarkGray, 2), -15, -15, 30, 30);
        g.DrawLine(new Pen(Color.DarkGray, 2), 0, 0, 25, 0);
      }
      else {
        g.FillEllipse(new SolidBrush(Color.Yellow), -15, -15, 30, 30);
        g.DrawEllipse(new Pen(Color.Black, 2), -15, -15, 30, 30);
        g.DrawLine(new Pen(Color.Black, 2), 0, 0, 25, 0);
      }
    }
    public override GraphicsPath GetGraphicsPath() {
      var path = base.GetGraphicsPath();
      path.AddEllipse(-15, -15, 30, 30);
      return path;
    }
    public Action<Marker> OnMarkerOverlap;
    public Action<Target> OnTargetOverlap;
    public override void Overlap(BaseObject obj) { // при пересечении игроком чего-либо
      base.Overlap(obj); // пишем с чем пересёкся

      if (obj is Marker) // если пересёкся с указателем
        OnMarkerOverlap(obj as Marker);
      if (obj is Target) // если пересёкся с едой
        OnTargetOverlap(obj as Target);
    }
  }
}
