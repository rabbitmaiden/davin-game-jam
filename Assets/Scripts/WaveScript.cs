using UnityEngine;
using System.Collections;

public class WaveScript : GameChild {

	private EnemyScript[] enemies;
	
	public bool deployed = false;
	public double percent = 0;
	
	public void Awake() {
	}
	// Use this for initialization
	public override void Start () {
		base.Start ();
		enemies = this.GetComponentsInChildren<EnemyScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
