using UnityEngine;
using System.Collections;

public class TitleScreenScript : MonoBehaviour {

	public float timeToAttract = 5f;
	protected float loadTime;

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
			Application.LoadLevel ("default");
		} else if (Time.time > loadTime + timeToAttract) {
			Debug.Log ("Loading Attract Mode");
			//Application
		}
	}


	void HideEverything() {
		SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();
		foreach( SpriteRenderer sprite in sprites) {
			Destroy (sprite.gameObject);
		}
	}
}
