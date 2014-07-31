using UnityEngine;
using System.Collections;

public class EnemyShotPool : Singleton<EnemyShotPool> {
	protected EnemyShotPool () {} // guarantee this will be always a singleton only - can't use the constructor!
	protected Transform enemyShotPrefab;
	protected Queue pool;

	void Awake () 
	{
		this.enemyShotPrefab = (Transform) Resources.Load ("enemy_shot");

		this.makeShots (30);
	}

	protected void makeShots(int count) 
	{
		for (int i=0; i< count; i++) {
			var shotTransform = Instantiate (this.enemyShotPrefab) as Transform;
				pool.Enqueue (shotTransform);
		}
	}

	public Transform GetShot() {
		if (this.pool.Count == 0) {
			this.makeShots (5);
		}

		var shotTransform = (Transform) this.pool.Dequeue ();
		return shotTransform;
	}

}