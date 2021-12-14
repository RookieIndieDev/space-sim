using Godot;

public class LabelUI : RichTextLabel
{
    public override void _Ready()
    {
        GetParent().GetParent().GetNode("RocketNoLandingLegs").Connect("SendRocketVelocity", this, nameof(OnSendRocketVelocity));
    }
    public void OnSendRocketVelocity(Vector2 velocity)
    {
        Text = "Velocity: " + velocity.ToString();
    }
}