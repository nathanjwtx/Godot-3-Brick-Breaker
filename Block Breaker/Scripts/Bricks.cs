using Godot;
using static Godot.GD;
using System;

public class Bricks : Node2D
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        var b = GetChildren();
        foreach (var brick in b)
        {
            AddToGroup("_Bricks");
        }
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
