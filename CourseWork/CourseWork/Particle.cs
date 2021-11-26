﻿using System;
using System.Drawing;

namespace CourseWork {
  class Particle {
    public int Radius; // радиус частицы
    public float X, Y, Direction, Speed; // координаты, направление, скорость частицы

    public static Random rand = new Random();

    public Particle() {
      // я не трогаю координаты X, Y потому что хочу, чтобы все частицы возникали из одного места
      Direction = rand.Next(360);
      Speed = 1 + rand.Next(10);
      Radius = 2 + rand.Next(10);
    }
    public void Draw(Graphics g) {
      // создали кисть для рисования
      var b = new SolidBrush(Color.Black);

      // нарисовали залитый кружок радиусом Radius с центром в X, Y
      g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

      // удалили кисть из памяти, вообще сборщик мусора рано или поздно это сам сделает
      // но документация рекомендует делать это самому
      b.Dispose();
    }
  }
}