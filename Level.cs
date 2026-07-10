using Godot;

public partial class Level : Node2D
{
    public override void _Ready()
    {
        GD.Print("Ready...");
    }

    public override void _Process(double delta)
    {
        GD.Print("Process...");
    }
}
