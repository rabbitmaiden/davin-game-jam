using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RevengeSpawner : GameChild {
	protected List<List<GameObject>> waves;
	protected int numEnemies = 0;
	protected float cooldownTil = 0;

	void Awake() {
		waves = new List<List<GameObject>>();
	}

	public void GenerateEnemiesBasedOnThreat(int threat) {
		numEnemies = threat;
		// Create a shit ton of enemies

		float[] positions = new float[5]{0f, -2.2f, 2.2f, 4.2f, -4.2f};
		int j = 0;
		
		List<GameObject> wave = new List<GameObject>();

		for (int i=0; i<numEnemies; i++) {			
			GameObject enemyObject = (GameObject) Instantiate(Resources.Load ("Prefabs/Enemies/Revenge Missile"));
			enemyObject.transform.parent = transform;
			float positionX = positions[j];

			float positionY = (playerCamera.orthographicSize) + 1;
			enemyObject.transform.localPosition = new Vector2(positionX, positionY);
			EnemyScript enemyScript = enemyObject.GetComponent<EnemyScript>();
			enemyScript.value = 5;

			// No moving yet
			TrackingScript tracking = enemyObject.GetComponent<TrackingScript>();
			tracking.enabled = false;

			wave.Add(enemyObject);

			j++;
			if(j>=positions.Length) {
				j=0;
				waves.Add (wave);
				wave = new List<GameObject>();
			}
		}

		if(wave.Count > 0) {
		}
		Debug.Log("Generated "+threat+" Revenge Missiles");
	}

	public override void Start() {

	}

	void FixedUpdate()
	{

	}

}
