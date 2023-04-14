using System.Numerics;
using Raylib_cs;

namespace SharpSand;

class Concrete : Solid {
    public Concrete(Vector2 position) : base(position) {
        ColorOffset = 15;
        BaseColor = new Color(127, 128, 118, 255);
        ModifyColor();
    }
}