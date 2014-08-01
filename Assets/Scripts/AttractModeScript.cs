using UnityEngine;
using System.Collections;

public class AttractModeScript : MonoBehaviour {


	public Vector2 speed = new Vector2(10, 10);
	protected Vector2 direction = new Vector2(0, 1);
	private bool fading = false;
	private Vector2 movement;
	
	void Start(){

	}

	void Update()
	{
		if (transform.position.y <= 30) {
			movement = new Vector2(
				speed.x * direction.x,
				speed.y * direction.y);
		} else {
			movement = new Vector2(0,0);
			if(!fading){
				CameraFade.StartAlphaFade( new Color(255f,0,0,0.6F), false, 5f, 0, () => { 
					Application.LoadLevel ("Title Screen");
				} );
				fading = true;
			}
		}
		if (Input.GetButtonDown("p1f1") ||
		    Input.GetButtonDown("p1f2") ||
		    Input.GetButtonDown("p2f1") ||
		    Input.GetButtonDown("p2f2")) {
			Application.LoadLevel ("Title Screen");
		}
	}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}
