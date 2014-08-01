using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RevengeWave : WaveScript {

	void Awake() {
		enemyPositions = new List<EnemyPosition>();
	}

	void GenerateEnemiesBasedOnThreat(int threat) {
		Debug.Log("Generating enemies for threat: "+threat);
	}

	public override void Start() {
		Debug.Log("I am a revenge wave and had start called on me");
		//base.Start();
	}
}
