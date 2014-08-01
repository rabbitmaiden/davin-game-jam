using UnityEngine;
using System.Collections;

public class TutorialScript : MonoBehaviour {
	
	public float timeToAttract = 20f;
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
			Application.LoadLevel ("default");
		} else if (Time.time > loadTime + timeToAttract) {
			Application.LoadLevel ("default");
		}
	}
	
}
