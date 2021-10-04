using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Var12 {
  public enum ColorModels { HSV, RGB };
  public class Color {
    private int _h, _s, _v, _r, _g, _b;
    public Color(ColorModels model = ColorModels.HSV, int var1 = 180, int var2 = 50, int var3 = 50) {
      if (model == ColorModels.HSV) {
        S = var1;
        H = var2;
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
      int vMin = ((100 - S) * V / 100);
      int a = (V - vMin) * (H % 60) / 60;
      int vInc = vMin + a;
      int vDec = V - a;

      switch ((H / 60) % 6) {
        case 0:
          R = V;
          G = vInc;
          B = vMin;
          break;
        case 1:
          R = vDec;
          G = V;
          B = vMin;
          break;
        case 2:
          R = vMin;
          G = V;
          B = vInc;
          break;
        case 3:
          R = vMin;
          G = vDec;
          B = V;
          break;
        case 4:
          R = vInc;
          G = vMin;
          B = V;
          break;
        case 5:
          R = V;
          G = vMin;
          B = vDec;
          break;
      }
      R = R * 255 / 100;
      G = G * 255 / 100;
      B = B * 255 / 100;
    }
    private void _UpdateHsv() {
      int min = Math.Min(R, Math.Min(G, B));
      int max = Math.Max(R, Math.Max(G, B));

      V = max;
      S = max == 0 ? 0 : 1 - (min / max);

      if (max == 0)
        return;
      else if (max == R)
        H = ((G - B) / (max - min)) % 360;
      else if (max == G)
        H = (G - B) / (max - min) + 120;
      else if (max == B)
        H = (G - B) / (max - min) + 240;
    }
  }
}
