using Godot;
using static Godot.GD;
using System;

public class Ball : RigidBody2D
{

    const int SpeedUp = 4;
    const int MaxSpeed = 200;

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        SetPhysicsProcess(true);
    }

    public override void _PhysicsProcess(float delta)
    {
        const int multipler = 100;
        var bodies = GetCollidingBodies();
    
        foreach (var body in bodies)
        {
            var b = body as Node;
            if (b.IsInGroup("Bricks"))
            {
                b.QueueFree();
            }

            if (b.GetName() == "Paddle")
            {
                var anchor = (Node2D) b.GetNode("Anchor");
                var speed = GetLinearVelocity().Length();
                var direction = GetPosition() - anchor.GlobalPosition;
                
                var velocity = direction.Normalized() * Math.Min(speed + SpeedUp * delta * multipler, 
                                   MaxSpeed * delta * multipler);
//                Print(velocity);
                LinearVelocity = velocity;
            }
        }
    }
}
