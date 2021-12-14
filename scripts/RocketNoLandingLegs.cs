using Godot;

public class RocketNoLandingLegs : RigidBody2D
{
    int thrustAmount = 50;
    Vector2 thrustVector;

    [Signal]
    public delegate void SendRocketVelocity(Vector2 velocity);
    public override void _Ready()
    {
        thrustVector = new Vector2 { y = -thrustAmount };
    }

    public override void _IntegrateForces(Physics2DDirectBodyState state)
    {
        EmitSignal("SendRocketVelocity", LinearVelocity);
    }

    private void ThrottleUp(float step)
    {
        AppliedForce += thrustVector * step;
    }

    private void Shutoff()
    {
        AppliedForce = Vector2.Zero;
    }
    private void TiltLeft(float step)
    {
        AngularVelocity -= 0.5f * step;
    }

    private void TiltRight(float step)
    {
        AngularVelocity += 0.5f * step;
    }
}
