using UnityEngine;

/// <summary>
/// Launch projectile
/// </summary>
public class WeaponScript : GameChild
{
	//--------------------------------
	// 1 - Designer variables
	//--------------------------------
	
	/// <summary>
	/// Projectile prefab for shooting
	/// </summary>
	public Transform shotPrefab;

	public float driftSpeed = 3f;
	
	/// <summary>
	/// Cooldown in seconds between two shots
	/// </summary>
	public float shootingRate = 0.25f;
	
	public bool ceaseFire = false;
	
	//--------------------------------
	// 2 - Cooldown
	//--------------------------------
	
	private float shootCooldown;


	public override void Start()
	{
		base.Start();
		shootCooldown = 0f;
	}
	
	void Update()
	{
		if (shootCooldown > 0)
		{
			shootCooldown -= Time.deltaTime;
		}
	}
	
	//--------------------------------
	// 3 - Shooting from another script
	//--------------------------------
	
	/// <summary>
	/// Create a new projectile if possible
	/// </summary>
	public void Attack(bool isEnemy)
	{

		if (CanAttack)
		{
			shootCooldown = shootingRate;
			
			// Create a new shot
			var shotTransform = Instantiate(shotPrefab, transform.position, transform.rotation) as Transform;
			shotTransform.parent = parentGame.foreground;

			
			// The is enemy property
			ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
			if (shot != null)
			{
				shot.isEnemyShot = isEnemy;
			}
			
			// Make the weapon shot always towards it
			MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
			if (move != null)
			{
				move.direction = this.transform.up; // towards in 2D space is the right of the sprite

				if (!shot.isEnemyShot){
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
					float yDir = move.direction.y;
					move.direction = new Vector2(inputX, yDir);
					float ySpeed = move.speed.y;
					move.speed = new Vector2(driftSpeed, ySpeed);
				}

			}
		}
	}
	
	/// <summary>
	/// Is the weapon ready to create a new projectile?
	/// </summary>
	public bool CanAttack
	{
		get
		{
			return !ceaseFire && shootCooldown <= 0f;
		}
	}
}