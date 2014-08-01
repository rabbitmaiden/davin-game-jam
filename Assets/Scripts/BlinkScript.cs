using UnityEngine;
using System.Collections;

public class BlinkScript : MonoBehaviour {

	public float blinkTime = 1;
	protected float toggleTime;
	protected bool on = true;
	protected SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		toggleTime = Time.time + blinkTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(on) {
			spriteRenderer.color = new Color(255f,255f,255f,1f);
		} else {
			spriteRenderer.color = new Color(255f,255f,255f,0f);
		}
	}
	
	void FixedUpdate() {
		if (toggleTime < Time.time) {
			on = !on;
			toggleTime = Time.time + blinkTime;
		}
	}
}
