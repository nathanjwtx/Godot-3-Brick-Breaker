using Godot;
using System;

public class Lose_Wall : StaticBody2D
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        SetPhysicsProcess(true);
    }

    public override void _PhysicsProcess(float delta)
    {
        System.Console.WriteLine("umm");
    }
}
