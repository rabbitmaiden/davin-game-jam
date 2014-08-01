using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveScript : GameChild {

	private EnemyScript[] enemies;

	public bool deployed = false;

	public int enemyValue = 0;

	protected List<EnemyPosition> enemyPositions;
	public string enemyType;

	// Use this for initialization
	public override void Start () {
		base.Start ();

		foreach(EnemyPosition ep in enemyPositions){
			GameObject enemyObject = (GameObject) Instantiate(Resources.Load ("Prefabs/Enemies/" + ep.enemyType));
			if (object.ReferenceEquals(null, enemyObject)) {
				Debug.LogError ("Could not load wave type: "+enemyType);
			}
			enemyObject.transform.parent = transform;
			enemyObject.transform.localPosition = ep.position;
			EnemyScript enemyScript = enemyObject.GetComponent<EnemyScript>();
			enemyScript.value = ep.value;
		}
	}
}


public class EnemyPosition {
	public Vector2 position;
	public string enemyType;
	public int value = 0;

	public EnemyPosition(float x, float y, string type) {
		position = new Vector2(x,y);
		enemyType = type;
	}

	public EnemyPosition(float x, float y, string type, int val) {
		position = new Vector2(x,y);
		enemyType = type;
		value = val;
	}
}