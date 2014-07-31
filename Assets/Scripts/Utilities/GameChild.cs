using UnityEngine;
using System.Collections;

// This is a utility class that children of a GameScript can use to get local references to
// the MasterGameScript, parent GameScript and relevant Camera
public class GameChild : MonoBehaviour {

	protected MasterGameScript masterGame;

	protected GameScript parentGame;

	protected Camera playerCamera;

	public virtual void Start() {
		this.masterGame = this.gameObject.GetComponentInParent<MasterGameScript>();
		this.parentGame = (GameScript) this.gameObject.GetComponentInParent (typeof(GameScript));
		this.playerCamera = (Camera) this.parentGame.gameObject.GetComponentInChildren (typeof(Camera));
	}
}
