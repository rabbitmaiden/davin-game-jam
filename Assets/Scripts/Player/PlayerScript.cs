using UnityEngine;
using System.Collections;

public class PlayerScript: MovementScript, KillableObject {

	/// <summary>
	/// 1 - The speed of the ship
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);

	// 2 - Store the movement
	private Vector2 movement;

	private LevelScript level;

	public override void Start() {
		base.Start();
		
		level = (LevelScript) parentGame.GetComponentInChildren (typeof(LevelScript));
	}

	void Update()
	{
		float inputX, inputY;
		// 3 - Retrieve axis information
		if (this.parentGame.isPlayer2) 
		{
			inputX = Input.GetAxis ("p2h");
			inputY = Input.GetAxis ("p2v");
		} 
		else 
		{
			inputX = Input.GetAxis ("p1h");
			inputY = Input.GetAxis ("p1v");
		}

		// 4 - Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);



		var dist = (transform.position - this.playerCamera.transform.position).z;
		
		var leftBorder = this.playerCamera.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).x;
		
		var rightBorder = this.playerCamera.ViewportToWorldPoint(
			new Vector3(1, 0, dist)
			).x;
		
		var topBorder = this.playerCamera.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).y;
		
		var bottomBorder = this.playerCamera.ViewportToWorldPoint(
			new Vector3(0, 1, dist)
			).y;
		
		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
			transform.position.z
			);

		// 5 - Shooting
		bool shoot;
		if (!this.parentGame.isPlayer2) {
			shoot = Input.GetButtonDown("p1f1");
		} else {
			shoot = Input.GetButtonDown("p2f1");
		}
		
		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				// false because the player is not an enemy
				weapon.Attack(false);
			}
		}
	}
	
	void FixedUpdate()
	{
		// Movement
		rigidbody2D.velocity = movement;
		
		// If we are in the top half of the screen, increase the scrolling speed
		if (transform.position.y > 0) {
			// Right now this is 1:1, we might want to multiply it by something
			int verticalDifference = Mathf.CeilToInt(transform.position.y);
			int newSpeed = 3 + verticalDifference;
			level.speed = new Vector2(0, newSpeed);
		} else {
			level.speed = new Vector2(0, 3);
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{

		bool damagePlayer = false;
		// Collision with enemy
		EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();
		if (enemy != null)
		{
			// Kill the enemy
			HealthScript enemyHealth = enemy.GetComponent<HealthScript>();
			if (enemyHealth != null) enemyHealth.Damage(enemyHealth.hp);
			
			damagePlayer = true;
		}
		
		// Damage the player
		if (damagePlayer)
		{
			HealthScript playerHealth = this.GetComponent<HealthScript>();
			if (playerHealth != null) playerHealth.Damage(1);
		}

	}

	void OnDestroy()
	{

	}

	public void killed() {
		// Winner is other player
		int winner = this.parentGame.isPlayer2 ? 1 : 2;
		this.masterGame.GameOver(winner);
	}
}
