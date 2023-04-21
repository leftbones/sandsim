using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace SharpSand;

class Chunk {
    public Vector2i Position { get; private set; }
    public int Size { get; private set; }
    public bool Awake { get; private set; } = true;
    public bool WakeNextStep { get; set; } = false;

    public Chunk(Vector2i position, int size) {
        Position = position;
        Size = size;
    }

    public void Update() {
        Awake = WakeNextStep;
        WakeNextStep = false;
    }

    public void DebugDraw() {
        Color color = Color.WHITE;
        if (!Awake) color = Color.DARKGRAY;
        DrawRectangleLines(Position.X, Position.Y, Size, Size, color);
    }
}