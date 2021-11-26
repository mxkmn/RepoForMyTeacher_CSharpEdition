using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class Target : BaseObject {
    public Target(float x, float y, float angle) : base(x, y, angle) { }
    public override void Draw(Graphics g) {
      g.FillEllipse( new SolidBrush(Color.Orange), -15, -15, 30, 30 );
      g.DrawEllipse( new Pen(Color.DarkOrange, 3), -15, -15, 30, 30 );
    }
    public override GraphicsPath GetGraphicsPath() {
      var path = base.GetGraphicsPath();
      path.AddEllipse(-15, -15, 30, 30);
      return path;
    }
  }
}
