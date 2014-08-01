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
			enemyPositions.Add(new EnemyPosition(-2f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(2f, 1f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-3f, 3f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-4f, 6f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(5f, 5f, "basic enemy", 5));
			break;
		case 5:
			enemyPositions.Add(new EnemyPosition(4.5f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(3.5f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1.5f, 3f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0.5f, 4f, "basic floater", 5));
			break;
		case 6:
			enemyPositions.Add(new EnemyPosition(-4.5f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-3.5f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-1.5f, 3f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-0.5f, 4f, "basic floater", 5));
			break;
		case 7:
			enemyPositions.Add(new EnemyPosition(0f, 3f, "super baddy", 20));
			enemyPositions.Add(new EnemyPosition(-3f, 6f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(3f, 6f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-4.5f, 3f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(4.5f, 3f, "basic floater", 5));
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
			enemyPositions.Add(new EnemyPosition(4f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(2f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-4f, 4f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 4f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(4f, 8f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(2f, 8f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 5f, "basic floater", 5));
			break;
		case 10:
			enemyPositions.Add(new EnemyPosition(-4f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 0f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(4f, 4f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(2f, 4f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-4f, 8f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 8f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 5f, "basic floater", 5));
			break;
		case 11:
			enemyPositions.Add(new EnemyPosition(-4f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-1f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(4f, 4f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1f, 4f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 6f, "basic enemy", 5));
			break;
		case 12:
			enemyPositions.Add(new EnemyPosition(4f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic enemy", 5));
			break;
		case 13:
			enemyPositions.Add(new EnemyPosition(-4f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-1f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic enemy", 5));
			break;
		case 14:
			enemyPositions.Add(new EnemyPosition(-4f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-3f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-1f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(1f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(2f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(3f, 0f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(4f, 1f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0f, 4f, "super baddy", 20));
			break;
		case 15:
			enemyPositions.Add(new EnemyPosition(-4f, 5f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(4f, 5f, "basic enemy", 5));
			break;
		case 16:
			enemyPositions.Add(new EnemyPosition(-4f, 5f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 5f, "basic enemy", 5));
			break;
		case 17:
			enemyPositions.Add(new EnemyPosition(4f, 5f, "basic enemy", 5));
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
			enemyPositions.Add(new EnemyPosition(-4f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(-2f, 4f, "super baddy", 20));
			break;
		case 20:
			enemyPositions.Add(new EnemyPosition(2f, 2.2f, "basic enemy", 5));
			enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic floater", 5));
			enemyPositions.Add(new EnemyPosition(4f, 2.2f, "basic floater", 5));
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
