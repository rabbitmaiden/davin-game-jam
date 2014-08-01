using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpinningWave : WaveScript {

	// Use this for initialization
	public void Awake() {
		enemyPositions = new List<EnemyPosition>();
		// core enemy
		enemyPositions.Add(new EnemyPosition(0f, 2.5f, "super baddy"));
		// south enemy
		enemyPositions.Add(new EnemyPosition(0, 1f, "basic enemy"));
		// south east enemy
		enemyPositions.Add(new EnemyPosition(1.76f, 1.76f, "basic enemy"));
		// north east enemy
		enemyPositions.Add(new EnemyPosition(1.76f, 3.24f, "basic enemy"));
		// north enemy
		enemyPositions.Add(new EnemyPosition(0f, 4f, "basic enemy"));
		// north west enemy
		enemyPositions.Add(new EnemyPosition(-1.76f, 3.24f, "basic enemy"));
		// south west enemy
		enemyPositions.Add(new EnemyPosition(-1.76f, 1.76f, "basic enemy"));
	}
}
