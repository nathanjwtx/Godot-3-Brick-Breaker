using Godot;
using System;

public class Paddle : KinematicBody2D
{

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        SetPhysicsProcess(true);
    }

    public override void _PhysicsProcess(float delta)
    {
        var y = Position.y;
        var x = GetViewport().GetMousePosition().x;
        System.Console.WriteLine(y);
        System.Console.WriteLine(x);
        var position = new Vector2(x, y);
        SetPosition(position);
    }
//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
