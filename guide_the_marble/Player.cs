using Godot;
using System;

public partial class Player : CharacterBody2D
{
	// initialization for animation
	private AnimatedSprite2D PlayerAnimation;
	
	// initialization for dblSpeed and dblGravity
	public const float dblSpeed = 230f;
	public const float dblGravity = 10f;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// player animation
		PlayerAnimation = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Vector2 vel = Velocity;
		
		// ensures marble is falling
		vel.Y += dblGravity * (float)delta;
		
		// if statements for animation
			if (Input.IsActionPressed("Right"))
			{
				// move to right
				vel.X = dblSpeed;
			}
			else if (Input.IsActionPressed("Left"))
			{
				// move to left
				vel.X = -dblSpeed;
			}
			// neccessary movement code
			Velocity = vel;
			MoveAndSlide();
		
	}
}
