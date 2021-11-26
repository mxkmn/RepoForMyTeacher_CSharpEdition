using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class Marker : BaseObject {
    public Marker(float x, float y, float angle) : base(x, y, angle) { }
    public override void Draw(Graphics g) {
      g.FillEllipse( new SolidBrush(Color.Red), -3, -3, 6, 6 );
      g.DrawEllipse( new Pen(Color.Red, 2), -6, -6, 12, 12 );
      g.DrawEllipse( new Pen(Color.Red, 2), -10, -10, 20, 20 );
    }
    public override GraphicsPath GetGraphicsPath() {
      var path = base.GetGraphicsPath();
      path.AddEllipse(-10, -10, 20, 20);
      return path;
    }
  }
}
