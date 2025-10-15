using Godot;
using System;

public partial class Bumper : Area2D
{
	[Export] public float BounceStrength = 800f;

	public override void _Ready()
	{
		// Connect to collision signal
		BodyEntered += Collision;
	}

	private void Collision(Node body)
	{
		if (body is RigidBody2D Player)
		{
			// Vector pointing from bumper center to ball
			Vector2 direction = (Player.GlobalPosition - GlobalPosition).Normalized();

			// Apply outward impulse
			Player.ApplyImpulse(direction * BounceStrength);
		}
	}
}
