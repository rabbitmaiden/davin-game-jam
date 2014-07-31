using UnityEngine;
using System.Collections;

public class GameChild : MonoBehaviour {

	protected GameScript parentGame;

	protected Camera playerCamera;

	public virtual void Start() {
		this.parentGame = (GameScript) this.gameObject.GetComponentInParent (typeof(GameScript));
		this.playerCamera = (Camera) this.parentGame.gameObject.GetComponentInChildren (typeof(Camera));
	}
}
