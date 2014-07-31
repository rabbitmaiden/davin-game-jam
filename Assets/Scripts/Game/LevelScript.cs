using UnityEngine;
using System.Collections;

public class LevelScript : ScrollingScript {

	private float totalDistance = 200;

	public GUISkin customSkin;
	

	void OnGUI() {
		GUI.skin = customSkin;
		int positionY = Screen.height - 50;
		int positionX = 20;		

		string progress = "Progress: " + System.Math.Round ( (Mathf.Abs(this.transform.position.y) / totalDistance) * 100, 2) + '%';


		if (this.parentGame.isPlayer2) {
			positionX = Screen.width - 160;
			GUI.Label (new Rect(positionX, positionY,200,30), progress);
			
		} else {
			GUI.Label (new Rect(positionX, positionY,200,30), progress);
		}
		
		
		
		
		
	}



}
