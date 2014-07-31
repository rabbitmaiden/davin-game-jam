using UnityEngine;
using System.Collections;

// Parent class to anything that moves
public class MovementScript : GameChild {

	public void StopMoving() {
		rigidbody2D.velocity = new Vector2(0,0);
		this.enabled = false;
	}
}