using UnityEngine;
using System.Collections;

public class LevelScript : ScrollingScript {

	private float totalDistance = 200;
	public double percent = 0;
	
	
	public GUISkin customSkin;
	
	private Transform foreground;

	void OnGUI() {
		GUI.skin = customSkin;
		GUI.depth = 0;
		
		if (!this.masterGame.gameOn) {
			return;
		}
		
		// Draw the progress meter
		int positionY = Screen.height - 30;
		int positionX = 20;		

		var gameOver = false;
		percent = System.Math.Round ( (Mathf.Abs(this.transform.position.y) / totalDistance) * 100, 2);
		// Did someone win by reaching the end of the level?
		if(percent > 100) {
			percent = 100.00;
			gameOver = true;
		}

		string progress = "Progress: " + percent  + '%';
		if (this.parentGame.isPlayer2) {
			positionX = Screen.width - 180;
		}
		GUI.Label (new Rect(positionX, positionY,200,30), progress);
		
		if (gameOver) {
			this.masterGame.GameOver (this.parentGame.isPlayer2 ? 2 : 1, "end");
		}
	}
	
	



}
