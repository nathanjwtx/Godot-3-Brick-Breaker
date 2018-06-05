using Godot;
using System;
using static Godot.GD;

public class Ball : RigidBody2D
{

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        SetPhysicsProcess(true);
    }

    public override void _PhysicsProcess(float delta)
    {
        ContactMonitor = true;
        var bodies = GetCollidingBodies();
        var hits = this.ContactsReported;
        // Print(GetTree().HasGroup("_Bricks"));
        // Print(GetTree().GetNodesInGroup("_Bricks"));
        
        foreach (var body in bodies)
        {
            if (IsInGroup("_Bricks"))
            {
                Print("Yes");
                QueueFree();
            }
            // else
            // {
            //     Print("No");
            // }
        }
    }
}
