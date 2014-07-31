using UnityEngine;

/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class HealthScript : MonoBehaviour
{
	/// <summary>
	/// Total hitpoints
	/// </summary>
	public int hp = 1;
	
	/// <summary>
	/// Enemy or player?
	/// </summary>
	public bool isEnemy = true;
	
	/// <summary>
	/// Inflicts damage and check if the object should be destroyed
	/// </summary>
	/// <param name="damageCount"></param>
	public void Damage(int damageCount)
	{
		hp -= damageCount;
		
		if (hp <= 0)
		{
			// Dead!
			Debug.Log("I died. I was a "+this.name);
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		// Is this a shot?
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		if (shot != null)
		{
			// Avoid friendly fire
			if (shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);
				Debug.Log("I am " + this.name + " and I was hit by " + otherCollider.name);
				
				// Destroy the shot
				Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
			}
		}
		
		// Is this a wall?
		WallScript wall = otherCollider.gameObject.GetComponent<WallScript>();
		if (wall != null)
		{
			// Avoid friendly fire
			if (wall.isEnemyWall != isEnemy)
			{
				Damage(wall.damage);				
				// Destroy the wall
				Destroy(wall.gameObject); // Remember to always target the game object, otherwise you will just remove the script
			}
		}
	}
}