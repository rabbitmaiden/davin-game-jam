using UnityEngine;
using System.Collections;

public class TitleScreenScript : MonoBehaviour {

	public float timeToAttract = 8f;
	protected float loadTime;
	protected bool fading = false;
	// Use this for initialization
	void Start () {
		loadTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("p1f1") ||
		    Input.GetButtonDown("p1f2") ||
		    Input.GetButtonDown("p2f1") ||
		    Input.GetButtonDown("p2f2")) {
			Debug.Log ("Time to go!");
			HideEverything ();
			Application.LoadLevel ("Tutorial");
		} else if (Time.time > loadTime + timeToAttract) {
			if(!fading){
				CameraFade.StartAlphaFade( new Color(0,0,0,0.8F), false, 4f, 0, () => { 
					Application.LoadLevel ("Attract Mode");
				} );
				fading = true;
			}
		}
	}


	void HideEverything() {
		SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();
		foreach( SpriteRenderer sprite in sprites) {
			Destroy (sprite.gameObject);
		}
	}
}
