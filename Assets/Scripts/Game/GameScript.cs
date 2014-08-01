using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This class represents a "game", belonging to one of the two players
// It is a child of the MasterGameScript which controls everything
public class GameScript : MonoBehaviour {

	public bool isPlayer2 = false;
	public GUISkin guiSkin;
	public Transform foreground;
	public Texture[] threatTextures = new Texture[11];
	
	private Camera playerCamera;
	private MasterGameScript masterGame;
	private LevelScript level;

	private GameScript otherPlayer;
	private List<Wave> waves;


	public int incomingCount = 0;
	private int threatCount = 0;

	private bool justDumpedthreat = false;

	
	void Awake() {
		masterGame = GetComponentInParent<MasterGameScript>();
		foreground = transform.Find ("Camera/Foreground");
		playerCamera = GetComponentInChildren<Camera>();
		level = GetComponentInChildren<LevelScript>();
		waves = new List<Wave>();
	}

	// Use this for initialization
	void Start () {
		otherPlayer = masterGame.GiveMeTheOtherPlayer(this);
		foreach (Wave wave in masterGame.waves) {
			Wave myWave = (Wave) wave.Clone ();
			waves.Add (myWave);
		}
	}
	
	
	void FixedUpdate() {
		// Spawn the PVE waves
		foreach(Wave wave in waves) {
			if (wave.deployed) {
				continue;
			}
			
			if (level.percent >= wave.percent) {
				wave.deployed = true;
				GameObject waveObject = (GameObject) Instantiate(Resources.Load("Prefabs/Waves/"+wave.type));
				if (object.ReferenceEquals(null, waveObject)) {
					Debug.LogError ("Could not load wave type: "+wave.type);
				}
				waveObject.transform.parent = foreground;
				// Put stuff just above the camera
				float positionY = (playerCamera.orthographicSize) + 1;
				waveObject.transform.localPosition = new Vector2(0, positionY);
				Debug.Log ("Sending wave "+wave.type);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.skin = guiSkin;
		// Incoming Count and Threat Count Temp
		string incomingText = "Incoming: "+incomingCount + " / Threat: "+threatCount;
		int positionY = Mathf.CeilToInt (5);
		int positionX = Mathf.CeilToInt((Screen.width / 4) - 120);
		if (isPlayer2) {
			positionX = Mathf.CeilToInt((Screen.width / 4)*3 - 80);
		}	
		GUI.Label (new Rect(positionX, positionY,200,30), incomingText, "Incoming");
		
		
		positionX = Mathf.CeilToInt((Screen.width / 4) + 65);
		if (isPlayer2) {
			positionX = Mathf.CeilToInt((Screen.width / 4)*3 + 80);
		}		
		GUI.Label (new Rect(positionX, positionY,400,50), threatTextures[threatCount/10]);

		if (!masterGame.gameOn) {
			bool isWinner = (masterGame.winner == (isPlayer2 ? 2 : 1));
			string gameOverText = isWinner ? "VICTORIOUS" : "DELETED";
			string gameOverStyle = isWinner ? "End Winner" : "End Loser";
			
			positionY = Mathf.CeilToInt((Screen.height / 2) - 20);
			positionX = Mathf.CeilToInt((Screen.width / 4) - 120);
			if (isPlayer2) {
				positionX = Mathf.CeilToInt((Screen.width / 4)*3 - 80);
			}
			GUI.Label (new Rect(positionX, positionY,200,30), gameOverText, gameOverStyle);		
		}
	}

	public void addThreat(int howMuch) {
		threatCount += howMuch;
		if ( threatCount > 100) {
			threatCount = 100;
		}
	}

	public void dumpThreat() {
		otherPlayer.getDunked (threatCount);
		threatCount = 0;
	}
	
	public void getDunked(int enemyThreat) {
		// Generate a Revenge wave here
		
	}


}

public class Wave
{
	public string type;
	public double percent;
	public bool deployed = false;
	
	public Wave(){
	}
	
	public Wave(double p, string t) {
		percent = p;
		type = t;
	}
	protected Wave(Wave other){
		type = other.type;
		percent = other.percent;
		deployed = other.deployed;
	}
	public virtual object Clone()
	{
		return new Wave(this);
	}
}
