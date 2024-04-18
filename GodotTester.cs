using System;
using Godot;

public partial class GodotTester : Node {
    // Called when the node enters the scene tree for the first time.
    public override void _Ready() {
        GD.Print("_Ready from my script!");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta) {
        GD.Print("_Process from my script! (delta = " + delta.ToString("F2") + "sec)");
    }
}
