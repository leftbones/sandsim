using System.Numerics;
using Raylib_cs;

namespace SharpSand;

class Ice : Solid {
    public Ice(Vector2i position) : base(position) {
        Health = 20.0f;
        CoolFactor = 2.0f;
        ActDirections = Direction.ShuffledDiagonal;
        ColorOffset = 15;
        BaseColor = new Color(165, 242, 243, 255);
        ModifyColor();
    }

    public override void HeatReaction(Matrix matrix) {
        matrix.Set(Position, new Water(Position));
    }
}