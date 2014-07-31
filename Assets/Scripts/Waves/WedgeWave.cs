using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WedgeWave : MonoBehaviour {

	public int xPos;
	public int yPos;
	public GameObject enemyToSpawn;
	public string enemyType = "SingleShotEnemy";

	private List<Vector2> enemyPositions;
	


	// Use this for initialization
	void Awake() {
		enemyPositions = new List<Vector2>();
		enemyPositions.Add(new Vector2(0f, 2f));
		enemyPositions.Add(new Vector2(1.5f, 5f));
		enemyPositions.Add(new Vector2(-1.5f, 5f));
		enemyPositions.Add(new Vector2(-3f, 3f));
		enemyPositions.Add(new Vector2(3f, 3f));
		enemyPositions.Add(new Vector2(4.5f, 0f));
   		enemyPositions.Add(new Vector2(-4.5f, 0f));
	}
	
	// Update is called once per frame

	void Start() {
		SpawnEnemies();
	}


	void SpawnEnemies() {
		foreach(Vector2 enemyPos in enemyPositions){
			GameObject enemyObject = (GameObject) Instantiate(enemyToSpawn);
			if (object.ReferenceEquals(null, enemyObject)) {
				Debug.LogError ("Could not load wave type: "+enemyType);
			}
			enemyObject.transform.parent = transform;

			enemyObject.transform.position = enemyPos;
		}
	}
}
