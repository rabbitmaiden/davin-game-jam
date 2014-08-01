using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RevengeSpawner : GameChild {
	protected Queue<List<float>> waves;
	public float cooldown = 3f;
	protected float cooldownTil = 0;
	// This is just to watch from the editor, may not always be up to date
	public int waveCount = 0;
	public Texture warningIndicator;
	private bool blink = true;
	private int counter = 0;
	private int blinkSpeed = 20;

	void Awake() {
		waves = new Queue<List<float>>();
	}

	public void GenerateEnemiesBasedOnThreat(int threat) {
		float[] positions = new float[5]{0f, -2.2f, 2.2f, 4.2f, -4.2f};
		int j = 0;
		
		List<float> wave = new List<float>();

		for (int i=0; i<threat; i++) {			

			parentGame.incomingCount++;
			wave.Add(positions[j]);
			j++;
			if(j>=positions.Length) {
				j=0;
				waves.Enqueue (wave);
				wave = new List<float>();
			}
		}

		if(wave.Count > 0) {
			waves.Enqueue (wave);
		}
		waveCount = waves.Count;
		
		// If we are the first wave, might as well wait 3 seconds
		if(Time.time > cooldownTil) {
			cooldownTil = Time.time + cooldown;
		}

	}

	void FixedUpdate() {
		if (waves.Count > 0 && Time.time > cooldownTil) {
			LaunchWave ();
			cooldownTil = Time.fixedTime + cooldown;
		}
	}


	void LaunchWave(){
		if( waves.Count == 0 || !masterGame.gameOn ) {
			return;
		}
		List<float> wave = waves.Dequeue();
		foreach(float positionX in wave) {
			GameObject enemyObject = (GameObject) Instantiate(Resources.Load ("Prefabs/Enemies/Revenge Missile"));
			enemyObject.transform.parent = transform;			
			float positionY = (playerCamera.orthographicSize) + 1;
			enemyObject.transform.localPosition = new Vector2(positionX, positionY);
			EnemyScript enemyScript = enemyObject.GetComponent<EnemyScript>();
			enemyScript.value = 5;
		}
		waveCount = waves.Count;
	}

	void OnGUI()
	{
		
		if(!masterGame.gameOn || !blink || waveCount <= 0) {
			return;
		}
		int positionX = Mathf.CeilToInt(Screen.width/4) - 25;
		if(parentGame.isPlayer2){
			positionX = Mathf.CeilToInt((Screen.width/4)*3) - 15;
		}

		int positionY = 60;
		GUI.Label (new Rect(positionX, positionY, 50, 50), warningIndicator);

	}

	void Update()
	{
		if(counter == blinkSpeed)
		{
			blink = !blink;
			counter = 0;
		} 
		counter++;
	}


}
