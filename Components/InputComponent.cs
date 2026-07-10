using Godot;

[GlobalClass]
public partial class InputComponent : Node
{
    public Vector2 moveDirection = Vector2.Zero;
    public bool jumpPressed = false;

    public void Update()
    {
        moveDirection = Input.GetVector("move_left", "move_right", "move_up", "move_down");
    }
}
