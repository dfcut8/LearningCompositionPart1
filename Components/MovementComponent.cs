using Godot;

[GlobalClass]
public partial class MovementComponent : Node
{
    [Export]
    public CharacterBody2D? Target { get; set; }

    [Export]
    public float Speed { get; set; } = 160.0f;

    public Vector2 Direction = Vector2.Zero;

    public void Update(double delta)
    {
        GD.Print(
            $"MovementComponent: Update. Direction={Direction}. Target Velocity={Target?.Velocity}"
        );
        if (Target is not null && IsInstanceValid(Target))
        {
            if (Direction != Vector2.Zero)
            {
                Target.Velocity = new Vector2(Direction.X * Speed, Direction.Y * Speed);
                Target.MoveAndSlide();
            }
        }
    }
}
