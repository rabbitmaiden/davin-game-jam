using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WedgeWave : WaveScript {

	// Use this for initialization
	public void Awake() {
		enemyType = "SingleShotEnemy";
		enemyPositions = new List<EnemyPosition>();
		enemyPositions.Add(new EnemyPosition(0f, 2f, "basic enemy"));
		enemyPositions.Add(new EnemyPosition(1.5f, 5f, "basic enemy"));
		enemyPositions.Add(new EnemyPosition(-1.5f, 5f, "basic enemy"));
		enemyPositions.Add(new EnemyPosition(-3f, 3f, "basic enemy"));
		enemyPositions.Add(new EnemyPosition(3f, 3f, "basic enemy"));
		enemyPositions.Add(new EnemyPosition(4.5f, 0f, "basic enemy"));
		enemyPositions.Add(new EnemyPosition(-4.5f, 0f, "basic enemy"));
	}
}
