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
	public Vector2 direction = new Vector2(-1, -1);
	
	private Vector2 movement;

	private string wiggleDir = "left";
	private int wiggleFrameCounter = 0;
	private int wiggleFrameLimit = 60;
	
	void Update()
	{
		// 2 - Movement


	}
	
	void FixedUpdate()
	{

		if (wiggleDir == "left"){
			if(direction.x == 1){
				direction = new Vector2(-1, direction.y);
			}
			if(wiggleFrameCounter == wiggleFrameLimit){
				wiggleFrameCounter = 0;
				wiggleDir = "right";
				Debug.Log ("wiggleDir set to: " + wiggleDir);
			}
		}
		else{
			if(direction.x == -1){
				direction = new Vector2(1, direction.y);
			}
			if(wiggleFrameCounter == wiggleFrameLimit){
				wiggleFrameCounter = 0;
				wiggleDir = "left";
				Debug.Log ("wiggleDir set to: " + wiggleDir);
			}
		}
		wiggleFrameCounter++;

		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
		Debug.Log ("wiggle X velocity: " + direction.x * speed.x);
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}
