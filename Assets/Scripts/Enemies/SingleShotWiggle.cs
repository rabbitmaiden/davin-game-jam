using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class SingleShotWiggle : MovementScript
{
	// 1 - Designer variables
	
	/// <summary>
	/// Object speed
	/// </summary>
	public Vector2 speed = new Vector2(1, 10);
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(0, -1);
	
	private Vector2 movement;

	private bool wiggleLeft = true;
	private int wiggleFrameCounter = 0;
	private int wiggleFrameLimit = 60;
	
	void Update()
	{
		// 2 - Movement
		wiggleFrameCounter++;


		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		if (wiggleLeft = true){
			if(wiggleFrameCounter == 0){
				direction.x = -1;
			}
			if(wiggleFrameCounter == wiggleFrameLimit){
				wiggleFrameCounter = 0;
				wiggleLeft = false;
			}
		}
		else{
			if(wiggleFrameCounter == 0){
				direction.x = 1;
			}
			if(wiggleFrameCounter == wiggleFrameLimit){
				wiggleFrameCounter = 0;
				wiggleLeft = true;
			}
		}
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}
