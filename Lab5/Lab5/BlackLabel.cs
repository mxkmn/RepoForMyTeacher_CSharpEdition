using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class BlackLabel : BaseObject {
    int _width, _height;
    public BlackLabel(int width, int height) : base(0, 0, 0) {
      _width = width;
      _height = height;
    }
    public override void Draw(Graphics g) {
      g.FillRectangle(new SolidBrush(Color.Black), -_width, 0, _width, _height );
    }
    public override GraphicsPath GetGraphicsPath() {
      GraphicsPath path = base.GetGraphicsPath();
      path.AddRectangle(new Rectangle(-_width, 0, _width, _height));
      return path;
    }
  }
}
