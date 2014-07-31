using UnityEngine;
using System.Collections;

public class WaveScript : GameChild {

	private EnemyScript[] enemies;
	private MoveScript moveScript;
	
	public void Awake() {
		moveScript = GetComponent<MoveScript>();
	}
	// Use this for initialization
	public override void Start () {
		base.Start ();
		enemies = this.GetComponentsInChildren<EnemyScript>();
		foreach(EnemyScript enemy in enemies) {
			enemy.Moving (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
