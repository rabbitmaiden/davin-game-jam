using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This class represents a "game", belonging to one of the two players
// It is a child of the MasterGameScript which controls everything
public class GameScript : MonoBehaviour {

	public bool isPlayer2 = false;
	public GUISkin guiSkin;
	public Transform foreground;
	
	private MasterGameScript masterGame;
	private LevelScript level;
	
	private List<Wave> waves;
	
	void Awake() {
		masterGame = GetComponentInParent<MasterGameScript>();
		foreground = transform.Find ("Camera/Foreground");
		level = GetComponentInChildren<LevelScript>();
		waves = new List<Wave>();
	}

	// Use this for initialization
	void Start () {
		foreach (Wave wave in masterGame.waves) {
			Wave myWave = (Wave) wave.Clone ();
			waves.Add (myWave);
		}
	}
	
	
	void FixedUpdate() {
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
				
				
				int positionX = (isPlayer2) ? 15 : 0;
				Debug.Log("positionsX: "+positionX+" isPlayer2: "+isPlayer2);
				int positionY = 5;
				waveObject.transform.position = new Vector2(positionX, positionY);
				
				Debug.Log ("Sending wave "+wave.type);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (!masterGame.gameOn) {
			GUI.skin = guiSkin;
			bool isWinner = (masterGame.winner == (isPlayer2 ? 2 : 1));
			string text = isWinner ? "VICTORIOUS" : "DELETED";
			string style = isWinner ? "End Winner" : "End Loser";
			
			int positionY = Mathf.CeilToInt((Screen.height / 2) - 20);
			int positionX = Mathf.CeilToInt((Screen.width / 4) - 120);
			
			
			if (isPlayer2) {
				positionX = Mathf.CeilToInt((Screen.width / 4)*3 - 80);
			}
			GUI.Label (new Rect(positionX, positionY,200,30), text, style);		
		}
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
