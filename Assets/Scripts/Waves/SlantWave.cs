using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SlantWave : WaveScript {

	// Use this for initialization
	public void Awake() {
		enemyType = "SingleShotEnemy";
		enemyPositions = new List<EnemyPosition>();
		enemyPositions.Add(new EnemyPosition(-4.5f, 0f, "SingleShotEnemy"));
		enemyPositions.Add(new EnemyPosition(-3f, 0.7f, "SingleShotEnemy"));
		enemyPositions.Add(new EnemyPosition(-1.5f, 1.5f, "SingleShotEnemy"));
		enemyPositions.Add(new EnemyPosition(0f, 2.2f, "SingleShotEnemy"));
		enemyPositions.Add(new EnemyPosition (1.5f, 2.9f, "SingleShotEnemy"));
		enemyPositions.Add(new EnemyPosition(3f, 3.6f, "SingleShotEnemy"));
		enemyPositions.Add(new EnemyPosition(4.5f, 4.3f, "SingleShotEnemy"));

	}
}
