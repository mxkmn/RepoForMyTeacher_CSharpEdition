using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab5 {
  class BaseObject {
    public float X, Y, Angle;
    public bool IsColorReversed;
    // делегаты, которые отрабатываются при пересечении и при отсутствии пересечения
    public Action<BaseObject> OnOverlap, OnNonOverlap;
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
    public void SetReverseColor(bool isReversed) { // этой штукой изменяется цвет
      IsColorReversed = isReversed;
    }
    public Matrix GetPosition() { // получение матрицы сдвига
      Matrix matrix = new Matrix();
      matrix.Translate(X, Y);
      matrix.Rotate(Angle);
      return matrix;
    }
    public virtual GraphicsPath GetGraphicsPath() { // получение размеров объекта
      return new GraphicsPath();
    }
    public virtual bool Overlaps(BaseObject obj, Graphics g) { // пересекается ли этот объект с другим объектом
      // берем информацию о собственной (1) и чужой (2) форме
      GraphicsPath path1 = this.GetGraphicsPath();
      GraphicsPath path2 = obj.GetGraphicsPath();

      // применяем к объектам матрицы трансформации
      path1.Transform(this.GetPosition());
      path2.Transform(obj.GetPosition());

      // используем класс Region, который позволяет определить пересечение объектов в данном графическом контексте
      Region region = new Region(path1);
      region.Intersect(path2); // пересекаем формы
      return !region.IsEmpty(g); // если полученная форма не пуста то значит было пересечение
    }
    public virtual void Overlap(BaseObject obj) { // при пересечении
      OnOverlap?.Invoke(obj); // срабатывание делегата, если он не null
    }
    public virtual void NonOverlap(BaseObject obj) { // при непересечении
      OnNonOverlap?.Invoke(obj);
    }
  }
}
