using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveScript : GameChild {

	private EnemyScript[] enemies;

	public bool deployed = false;
	public double percent = 0;

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
			

		}
	}
}


public class EnemyPosition {
	public Vector2 position;
	public string enemyType;

	public EnemyPosition(float x, float y, string type) {
		position = new Vector2(x,y);
		enemyType = type;
	}
}