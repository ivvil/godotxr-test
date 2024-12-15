using Godot;
using System;

public partial class Main : Node3D
{
    private XRInterface _xrInterface;

    public override void _Ready()
    {
        _xrInterface = XRServer.FindInterface("OpenXR");

        if (_xrInterface != null && _xrInterface.IsInitialized())
        {
            GD.Print("OpenXR initialized successfully");

            // Vsync off
            DisplayServer.WindowSetVsyncMode(DisplayServer.VSyncMode.Disabled);

            // HMD video output
            GetViewport().UseXR = true;
        }
		else
		{
			GD.Print("Error during OpenXR initialization");
		}
    }
}
