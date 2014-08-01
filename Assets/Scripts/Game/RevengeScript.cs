using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This class controls the revenge spawning behavior
public class RevengeScript : MonoBehaviour {

	public bool isPlayer2 = false;
	public GUISkin guiSkin;
	public Transform foreground;
	
	private Camera camera;
	private MasterGameScript masterGame;
	private LevelScript level;

	private GameScript otherPlayer;
	
	void Awake() {
		masterGame = GetComponentInParent<MasterGameScript>();
		foreground = transform.Find ("Camera/Foreground");
		level = GetComponentInChildren<LevelScript>();
		camera = GetComponentInChildren<Camera>();
		waves = new List<Wave>();
	}

	// Use this for initialization
	void Start () {
		otherPlayer = masterGame.GiveMeTheOtherPlayer(this);
		Debug.Log("Me: "+isPlayer2+ " / Them: " + otherPlayer.isPlayer2);
	}
	
	
	void RevengeSpawn() {
		// Spawn the Revenge waves
		foreach(Wave wave in waves) {
			if (wave.deployed) {
				continue;
			}
			
			if (level.percent >= wave.percent) {
				wave.deployed = true;
				GameObject waveObject = (GameObject) Instantiate(Resources.Load("Prefabs/Waves/"+revenge.type));
				if (object.ReferenceEquals(null, waveObject)) {
					Debug.LogError ("Could not load wave type: "+wave.type);
				}
				waveObject.transform.parent = foreground;
				// Put stuff just above the camera
				float positionY = (this.camera.orthographicSize) + 1;
				waveObject.transform.localPosition = new Vector2(0, positionY);
				
				Debug.Log ("Sending wave "+wave.type);
			}
		}
	}
}