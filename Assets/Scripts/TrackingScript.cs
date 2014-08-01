using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class TrackingScript : MovementScript
{

	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2(0, -1);

	private GameObject player;

	public Vector2 target;
	private Vector2 movement;

	public override void Start() {
		base.Start ();
		PlayerScript playerScript = this.parentGame.GetComponentInChildren<PlayerScript>();
		player = playerScript.gameObject;
	}

	void Update()
	{
		if(this.transform.position.y >= 2) {
			 direction = (player.transform.position - this.transform.position);
		}
		// 2 - Movement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}