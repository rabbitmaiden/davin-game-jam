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
	public Vector2 speed = new Vector2(0.5f, 5f);
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(0, -1);

	private Vector2 movement;

	private int wiggleDir = 0;
	private int wiggleFrameCounter = 0;
	private int wiggleFrameLimit = 90;
	
	void Update()
	{
		// 2 - Movement


	}
	void Awake(){
		float changeStartingDirRng = Random.value;
		if (changeStartingDirRng > 0.5f){
			wiggleDir = 1;
		}
		else{
			wiggleDir = -1;
		}
	}
	
	void FixedUpdate()
	{

		if (wiggleDir == -1){
			if(direction.x == 1){
				direction = new Vector2(-1, direction.y);
			}
			if(wiggleFrameCounter == wiggleFrameLimit){
				wiggleFrameCounter = 0;
				wiggleDir = 1;
			}
		}
		else{
			if(direction.x == -1){
				direction = new Vector2(1, direction.y);
			}
			if(wiggleFrameCounter == wiggleFrameLimit){
				wiggleFrameCounter = 0;
				wiggleDir = -1;
			}
		}
		wiggleFrameCounter++;

		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}
