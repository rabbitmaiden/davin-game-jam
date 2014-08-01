using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RightSlantWave : WaveScript {

	// Use this for initialization
	public void Awake() {
		enemyPositions = new List<EnemyPosition>();
		enemyPositions.Add(new EnemyPosition(-4.5f, 4.3f, "basic floater"));
		enemyPositions.Add(new EnemyPosition(-3f, 3.6f, "basic floater"));
		enemyPositions.Add(new EnemyPosition(-1.5f, 2.9f, "basic floater"));
		enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic floater"));
		enemyPositions.Add(new EnemyPosition (1.5f, 1.5f, "basic floater"));
		enemyPositions.Add(new EnemyPosition(3f, 0.7f, "basic floater"));
		enemyPositions.Add(new EnemyPosition(4.5f, 0f, "basic floater"));

	}
}
