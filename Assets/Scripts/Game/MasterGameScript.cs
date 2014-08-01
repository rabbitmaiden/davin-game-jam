using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MasterGameScript : MonoBehaviour {

	GameScript[] games;
	public bool gameOn = false;
	public int winner = 0;
	public List<Wave> waves;
	
	void Awake() {
		games = this.gameObject.GetComponentsInChildren<GameScript>();
		waves = new List<Wave>();
		
		// Make the waves
		// Hardcoded for now, we should maybe load these from XML or randomly generate them?

		waves.Add(new Wave(5, "LeftSlantWave"));
		waves.Add(new Wave(10, "RightSlantWave"));
		waves.Add(new Wave(15, "LeftSlantWave"));
		waves.Add(new Wave(25, "WedgeWave"));
		waves.Add(new Wave(30, "WedgeWave"));
		waves.Add(new Wave(40, "SpinningWave"));
	}
	
	void Start () {
		gameOn = true;		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameScript GiveMeTheOtherPlayer(GameScript me) {
		foreach(GameScript you in games) {
			if (you != me ){
				return you;
			}
		}
		return null;
	}
	
	public void GameOver(int winner) {
		gameOn = false; 
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
		
		CameraFade.StartAlphaFade( new Color(0,0,0,0.6F), false, 3f, 0, () => { 
			
		} );
		this.winner = winner;
		Debug.Log ("Player "+winner+" wins!!");
		
	}
	
}
