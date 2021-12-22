using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class Player : BaseObject {
    public float XModifier, YModifier;
    public Action<Marker> OnMarkerOverlap;
    public Action<Target> OnTargetOverlap;
    public Player(float x, float y, float angle) : base(x, y, angle) { }
    public override void Draw(Graphics g) {
      if (IsColorReversed) {
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
      GraphicsPath path = base.GetGraphicsPath();
      path.AddEllipse(-15, -15, 30, 30);
      return path;
    }
    public override void Overlap(BaseObject obj) { // при пересечении игроком чего-либо
      base.Overlap(obj); // пишем с чем пересёкся

      if (obj is Marker) // если пересёкся с указателем
        OnMarkerOverlap?.Invoke(obj as Marker);
      if (obj is Target) // если пересёкся с едой
        OnTargetOverlap?.Invoke(obj as Target);
    }
  }
}
