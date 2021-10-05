using System;

namespace Lab3Var12 {
  public enum ColorModels { HSV, RGB };
  public class Color {
    private int _h, _s, _v, _r, _g, _b;
    public Color(ColorModels model = ColorModels.HSV, int var1 = 180, int var2 = 50, int var3 = 50) {
      if (model == ColorModels.HSV) {
        H = var1;
        S = var2;
        V = var3;
        _UpdateRgb();
      }
      else {
        R = var1;
        G = var2;
        B = var3;
        _UpdateHsv();
      }
    }
    public int H {
      get => _h;
      set {
        if (0 <= value && value <= 360) {
          _h = value;
          _UpdateRgb();
        }
        else
          throw new ArgumentException("При изменении H получено недопустимое значение " + value);
      }
    }
    public int S {
      get => _s;
      set {
        if (0 <= value && value <= 100) {
          _s = value;
          _UpdateRgb();
        }
        else
          throw new ArgumentException("При изменении S получено недопустимое значение " + value);
      }
    }
    public int V {
      get => _v;
      set {
        if (0 <= value && value <= 100) {
          _v = value;
          _UpdateRgb();
        }
        else
          throw new ArgumentException("При изменении V получено недопустимое значение " + value);
      }
    }
    public int R {
      get => _r;
      set {
        if (0 <= value && value <= 255) {
          _r = value;
          _UpdateHsv();
        }
        else
          throw new ArgumentException("При изменении R получено недопустимое значение " + value);
      }
    }
    public int G {
      get => _g;
      set {
        if (0 <= value && value <= 255) {
          _g = value;
          _UpdateHsv();
        }
        else
          throw new ArgumentException("При изменении G получено недопустимое значение " + value);
      }
    }
    public int B {
      get => _b;
      set {
        if (0 <= value && value <= 255) {
          _b = value;
          _UpdateHsv();
        }
        else
          throw new ArgumentException("При изменении B получено недопустимое значение " + value);
      }
    }
    private void _UpdateRgb() {
      int vMin = Convert.ToInt32(1.0 * (100 - S) * V / 100);
      int a = Convert.ToInt32(1.0 * (V - vMin) * (H % 60) / 60);
      int vInc = vMin + a;
      int vDec = V - a;

      switch ((H / 60) % 6) {
        case 0:
          _r = V;
          _g = vInc;
          _b = vMin;
          break;
        case 1:
          _r = vDec;
          _g = V;
          _b = vMin;
          break;
        case 2:
          _r = vMin;
          _g = V;
          _b = vInc;
          break;
        case 3:
          _r = vMin;
          _g = vDec;
          _b = V;
          break;
        case 4:
          _r = vInc;
          _g = vMin;
          _b = V;
          break;
        case 5:
          _r = V;
          _g = vMin;
          _b = vDec;
          break;
      }
      _r = R * 255 / 100;
      _g = G * 255 / 100;
      _b = B * 255 / 100;
    }
    private void _UpdateHsv() {
      double r = 1.0 * R / 255, g = 1.0 * G / 255, b = 1.0 * B / 255;
      double min = Math.Min(r, Math.Min(g, b));
      double max = Math.Max(r, Math.Max(g, b));

      _v = Convert.ToInt32(max * 100);
      _s = max == 0 ? 0 : Convert.ToInt32((1 - (min / max))*100);

      if (max == 0 || max == min)
        return;
      else if (max == r)
        _h = Convert.ToInt32(((g - b) / (max - min)) % 360);
      else if (max == g)
        _h = Convert.ToInt32((g - b) / (max - min) + 120);
      else if (max == B)
        _h = Convert.ToInt32((g - b) / (max - min) + 240);
    }
  }
}
