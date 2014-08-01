using UnityEngine;

/// <summary>
/// Projectile behavior
/// </summary>
public class WallScript : GameChild, KillableObject
{
	// 1 - Designer variables
	
	/// <summary>
	/// Damage inflicted
	/// </summary>
	public int damage = 1;
	
	/// <summary>
	/// Projectile damage player or enemies?
	/// </summary>
	public bool isEnemyWall = false;
	
	public override void Start()
	{
		base.Start ();
		// 2 - Limited time to live to avoid any leak
		Destroy(gameObject, 20); // 20sec
	}

	public void killed() {
		Destroy (this.gameObject);
		// If a wall dies, does anyone care?
	}
}