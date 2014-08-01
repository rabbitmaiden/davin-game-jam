using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MasterGameScript : MonoBehaviour {

	GameScript[] games;
	public bool gameOn = false;
	public int winner = 0;
	public List<Wave> waves;
	private string winCondition;

	public Texture[] endGameTextures;
	public Texture reloadText;

	private bool fireReloads = false;
	
	void Awake() {
		games = this.gameObject.GetComponentsInChildren<GameScript>();
		waves = new List<Wave>();
		
		// Make the waves
		// Hardcoded for now, we should maybe load these from XML or randomly generate them?
		waves.Add(new Wave(5, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(15, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(25, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(35, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(45, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(55, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(70, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(75, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		waves.Add(new Wave(80, "RandomSimpleWave", RandomSimpleWave.GetSeed ()));
		/*
		waves.Add(new Wave(10, "RightSlantWave"));
		waves.Add(new Wave(15, "LeftSlantWave"));
		waves.Add(new Wave(25, "WedgeWave"));
		waves.Add(new Wave(30, "WedgeWave"));
		waves.Add(new Wave(40, "SpinningWave"));
		*/
		Debug.Log ("hey now");
	}
	
	void Start () {
		gameOn = true;		
	}

	void Update() {
		if(fireReloads && (Input.GetButtonDown("p1f1") ||
			    Input.GetButtonDown("p1f2") ||
			    Input.GetButtonDown("p2f1") ||
			    Input.GetButtonDown("p2f2"))) {
				Application.LoadLevel ("default");
		}
	}


	public GameScript GiveMeTheOtherPlayer(GameScript me) {
		foreach(GameScript you in games) {
			if (you != me ){
				return you;
			}
		}
		return null;
	}
	
	public void GameOver(int winner, string wc) {

		gameOn = false; 

		// Turn everything(?) off
		GameChild[] goblins = this.gameObject.GetComponentsInChildren<GameChild>();
		foreach(GameChild goblin in goblins) {
			goblin.enabled = false;
		}


		// Stop movement on everything
		MovementScript[] movers = this.gameObject.GetComponentsInChildren<MovementScript>();
		foreach(MovementScript mover in movers) {
			mover.StopMoving();
		}
		
		// Cease fire
		WeaponScript[] weapons = this.gameObject.GetComponentsInChildren<WeaponScript>();
		foreach(WeaponScript weapon in weapons) {
			weapon.ceaseFire = true;
		}
		
		CameraFade.StartAlphaFade( new Color(0,0,0,0.6F), false, 2f, 0, () => { 
			fireReloads = true;
			Invoke ("BackToTitleScreen", 10);
		} );
		this.winner = winner;
		winCondition = wc;
	}

	protected void BackToTitleScreen() {
		Application.LoadLevel ("Title Screen");
	}
	
	void OnGUI() {
		if(gameOn) {
			return;
		}
		int index = 0;
		if (winner == 1) {
			if (winCondition == "end") {
				index = 1;
			}
		} else {
			if (winCondition == "death") {
				index = 2;
			} else {
				index = 3;
			}
		}
		int width = Mathf.CeilToInt(Screen.width * 0.8f);
		int height = 40;
		int posX = Mathf.CeilToInt ((Screen.width/2)-(width/2));
		int posY = Mathf.CeilToInt ((Screen.height/2));
		GUI.Label (new Rect(posX, posY, width, height), endGameTextures[index]);

			
		width = Mathf.CeilToInt(Screen.width * 0.6f);
		height = 40;
		posX = Mathf.CeilToInt ((Screen.width/2)-(width/2));
		posY = Mathf.CeilToInt ((Screen.height/2)) + 200;

		GUI.Label (new Rect(posX, posY, width, height), reloadText);

	}
}
