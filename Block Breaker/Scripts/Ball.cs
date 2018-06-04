using Godot;
using System;

public class Ball : RigidBody2D
{

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        SetPhysicsProcess(true);
    }

    public void physics_process()
    {
        var bodies = GetCollidingBodies();
        foreach (var body in bodies)
        {
            if (IsInGroup("Bricks"))
            {
                QueueFree();
            }
        }
    }
}
