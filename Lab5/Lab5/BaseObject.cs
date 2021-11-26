using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class BaseObject {
    public float X, Y, Angle;
    public BaseObject(float x, float y, float angle) { // установка стартовых значений
      X = x;
      Y = y;
      Angle = angle;
    }
    public virtual void GenerateRandomly(int maxX, int maxY) { // рандомное задавание позиции
      Random random = new Random();
      X = random.Next(10, maxX-10);
      Y = random.Next(10, maxY-10);
    }
    public virtual void Draw(Graphics g) { } // этой штукой объект рисуется в начале координат
    public Matrix GetPosition() {
      var matrix = new Matrix();
      matrix.Translate(X, Y);
      matrix.Rotate(Angle);
      return matrix;
    }
    public virtual GraphicsPath GetGraphicsPath() {
      return new GraphicsPath();
    }
    public virtual bool Overlaps(BaseObject obj, Graphics g) {
      // берем информацию о собственной (1) и чужой (2) форме
      var path1 = this.GetGraphicsPath();
      var path2 = obj.GetGraphicsPath();

      // применяем к объектам матрицы трансформации
      path1.Transform(this.GetPosition());
      path2.Transform(obj.GetPosition());

      // используем класс Region, который позволяет определить 
      // пересечение объектов в данном графическом контексте
      var region = new Region(path1);
      region.Intersect(path2); // пересекаем формы
      return !region.IsEmpty(g); // если полученная форма не пуста то значит было пересечение
    }
    public Action<BaseObject, BaseObject> OnOverlap; // делегат, который отрабатывается при пересечении 
    public virtual void Overlap(BaseObject obj) { // при любом пересечении
      OnOverlap?.Invoke(this, obj); // срабатывание делегата, если он не null
    }
  }
}
