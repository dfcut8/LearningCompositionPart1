using Godot;

public partial class Player : CharacterBody2D
{
    [Export]
    InputComponent InputComponent { get; set; }

    public override void _PhysicsProcess(double delta)
    {
        InputComponent.Update();
    }
}
