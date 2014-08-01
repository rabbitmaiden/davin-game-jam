using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomSimpleWave : WaveScript {
	
	public int seed = 0;

	// Use this for initialization
	public void Awake() {
		// Parameter order: X position, Y position, enemy type, threat value
		// Enemy types: basic enemy, basic floater, Basic Wall, super baddy
		enemyPositions = new List<EnemyPosition>();		
	}

	public override void Start()
	{
		Debug.Log ("RandomWave Spawning Wave "+seed);
		// DEBUG**
		//seed = 14;
		switch(seed)
		{
		case 0:
			enemyPositions.Add(new EnemyPosition(-3f, 3f, "super baddy", 20));
			enemyPositions.Add(new EnemyPosition(-3.5f, 2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic enemy", 5));
			break;
		case 1:
			enemyPositions.Add(new EnemyPosition(3f, 3f, "super baddy", 20));
			enemyPositions.Add(new EnemyPosition(3.5f, 2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic enemy", 5));
			break;
		case 2:
			enemyPositions.Add(new EnemyPosition(-3f, 3f, "super baddy", 20));
			enemyPositions.Add(new EnemyPosition(-3.5f, 2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic floater", 5));
			break;
		case 3:
			enemyPositions.Add(new EnemyPosition(3f, 3f, "super baddy", 20));
			enemyPositions.Add(new EnemyPosition(3.5f, 2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic floater", 5));
			break;
		case 4:
			// adjusted to remove the 4.0 x-axis position
			enemyPositions.Add(new EnemyPosition(-3.5f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0.5f, 1f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-1.5f, 3f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 6f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(3.5f, 5f, "basic enemy", 5));
			break;
		case 5:
			//4.5 spawns the enemy right in the border
			//enemyPositions.Add(new EnemyPosition(4.5f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(3.5f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1.5f, 3f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0.5f, 4f, "basic floater", 5));
			//added this one to compensate for removing the above guy
			enemyPositions.Add(new EnemyPosition(-0.5f, 5f, "basic floater", 5));
			break;
		case 6:
			// adjusted to remove the -4.5 x axis position
			//enemyPositions.Add(new EnemyPosition(-4.5f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-3.5f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-1.5f, 2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-0.5f, 3f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0.5f, 4f, "basic floater", 5));
			break;
		case 7:
			// adjusted to ensure that all ships are fully on screen
			enemyPositions.Add(new EnemyPosition(0f, 3f, "super baddy", 20));
			enemyPositions.Add(new EnemyPosition(-2.25f, 6f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.25f, 6f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-3.5f, 3f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(3.5f, 3f, "basic floater", 5));
			break;
		case 8:
			enemyPositions.Add(new EnemyPosition(-4f, 6f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-3f, 6f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 6f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-0f, 4f, "super baddy", 20));
			enemyPositions.Add(new EnemyPosition(2f, 6f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(3f, 6f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(4f, 6f, "basic floater", 5));
			break;
		case 9:
			enemyPositions.Add(new EnemyPosition(3.75f, 0f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(2f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-4f, 4f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 4f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(3.75f, 8f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(2f, 8f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 5f, "basic floater", 5));
			break;
		case 10:
			enemyPositions.Add(new EnemyPosition(-3.75f, 0f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(3.75f, 4f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(2f, 4f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-3.75f, 8f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 8f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 5f, "basic floater", 5));
			break;
		case 11:
			enemyPositions.Add(new EnemyPosition(-3.5f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-1f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(3.5f, 4f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1f, 4f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 6f, "basic enemy", 5));
			break;
		case 12:
			enemyPositions.Add(new EnemyPosition(3.5f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic enemy", 5));
			break;
		case 13:
			enemyPositions.Add(new EnemyPosition(-3.75f, 0f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(-0.5f, 0f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(0.45f, 0f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "Basic Wall", 5));

			enemyPositions.Add(new EnemyPosition(3.75f, 5f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(0.5f, 5f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(-0.45f, 5f, "Basic Wall", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 7f, "Basic Wall", 5));
			break;
		case 14:
			enemyPositions.Add(new EnemyPosition(-3.5f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2.0f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-0.5f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1.0f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 1f, "basic floater", 5));
			//enemyPositions.Add(new EnemyPosition(3.5f, 0f, "basic floater", 5));

			// these enemies included made this wave un-dodgeable
			//enemyPositions.Add(new EnemyPosition(5f, 1f, "basic floater", 5));
			//enemyPositions.Add(new EnemyPosition(3f, 0f, "basic floater", 5));
			//enemyPositions.Add(new EnemyPosition(4f, 1f, "basic floater", 5));
			//enemyPositions.Add(new EnemyPosition(0f, 4f, "super baddy", 20));
			break;
		case 15:
			enemyPositions.Add(new EnemyPosition(-3.5f, 5f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(3.5f, 5f, "basic enemy", 5));
			break;
		case 16:
			enemyPositions.Add(new EnemyPosition(-3.5f, 5f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 5f, "basic enemy", 5));
			break;
		case 17:
			enemyPositions.Add(new EnemyPosition(3.5f, 5f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(2f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 5f, "basic enemy", 5));
			break;
		case 18:
			enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0f, 4f, "super baddy", 10));
			break;
		case 19:
			enemyPositions.Add(new EnemyPosition(-2f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-3.5f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 4f, "super baddy", 20));
			break;
		case 20:
			enemyPositions.Add(new EnemyPosition(2f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(3.5f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2f, 4f, "super baddy", 20));
			break;
		}
		base.Start ();
	}
	
	protected static System.Random rng = new System.Random();

	public static int GetSeed() {
		return RandomSimpleWave.rng.Next (0,21);
	}

}
