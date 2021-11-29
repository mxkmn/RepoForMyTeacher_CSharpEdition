using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class Marker : BaseObject {
    public Marker(float x, float y, float angle) : base(x, y, angle) { }
    public override void Draw(Graphics g) {
      if (IsColorReversed) {
        g.FillEllipse(new SolidBrush(Color.White), -3, -3, 6, 6);
        g.DrawEllipse(new Pen(Color.DarkGray, 2), -6, -6, 12, 12);
        g.DrawEllipse(new Pen(Color.DarkGray, 2), -10, -10, 20, 20);
      }
      else {
        g.FillEllipse(new SolidBrush(Color.Green), -3, -3, 6, 6);
        g.DrawEllipse(new Pen(Color.Green, 2), -6, -6, 12, 12);
        g.DrawEllipse(new Pen(Color.Green, 2), -10, -10, 20, 20);
      }
    }
    public override GraphicsPath GetGraphicsPath() {
      GraphicsPath path = base.GetGraphicsPath();
      path.AddEllipse(-10, -10, 20, 20);
      return path;
    }
  }
}
