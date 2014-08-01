using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RevengeWave : GameChild {

	protected int numEnemies = 0;

	void Awake() {
		enemyPositions = new List<EnemyPosition>();
	}

	public void GenerateEnemiesBasedOnThreat(int threat) {
		numEnemies = threat;
		// Create a shit ton of enemies
		for (int i=0; i<numEnemies; i++) {
			/*
			GameObject enemyObject = (GameObject) Instantiate(Resources.Load ("Prefabs/Enemies/" + ep.enemyType));
			if (object.ReferenceEquals(null, enemyObject)) {
				Debug.LogError ("Could not load wave type: "+enemyType);
			}
			enemyObject.transform.parent = transform;
			enemyObject.transform.localPosition = ep.position;
			EnemyScript enemyScript = enemyObject.GetComponent<EnemyScript>();
			enemyScript.value = ep.value;
		*/
		}
	}

	public override void Start() {

	}
}
