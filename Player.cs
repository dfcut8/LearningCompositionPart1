using Godot;

public partial class Player : CharacterBody2D
{
    [Export]
    InputComponent InputComponent { get; set; }

    [Export]
    MovementComponent MovementComponent { get; set; }

    public override void _PhysicsProcess(double delta)
    {
        InputComponent.Update();
        MovementComponent.Direction = InputComponent.MoveDirection;
        MovementComponent.Update(delta);
    }
}
