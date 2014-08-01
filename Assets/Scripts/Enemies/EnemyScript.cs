using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy generic behavior
/// </summary>
public class EnemyScript : GameChild, KillableObject
{
	private WeaponScript[] weapons;
	private bool hasSpawn = false;
	private MoveScript moveScript;

	public int value = 5;
	
	void Awake()
	{
		// Retrieve the weapon only once
		weapons = GetComponentsInChildren<WeaponScript>();
		moveScript = (MoveScript) GetComponent(typeof(MoveScript));
	}

	public override void Start()
	{
		base.Start ();
		// Disable everything
		// -- collider
		collider2D.enabled = false;
		// -- Shooting
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = false;
		}
		//Debug.Log("Good morning. I'm " + this.name);
	}
	
	void Update()
	{
		if (hasSpawn == false)
		{
			if (renderer.IsVisibleFrom(this.playerCamera))
			{
				Spawn();
			}
		}
		else
		{
		
			if (this.renderer.IsVisibleFrom (this.playerCamera) == false) {
				//Debug.Log("I died from being invisible. I am a "+this.name);
				Destroy (this.gameObject);
			}
			
			foreach (WeaponScript weapon in weapons)
			{
				// Auto-fire
				if (weapon != null && weapon.CanAttack)
				{
					weapon.Attack(true);
				}
			}


		}
	}

	void Spawn()
	{
		this.parentGame.incomingCount--;
		this.hasSpawn = true;
		collider2D.enabled = true;
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = true;
		}
	}
	
	public void Moving(bool moving)
	{
		this.moveScript.enabled = moving;
	}

	public void killed() {
		this.parentGame.addThreat (this.value);
		Destroy (this.gameObject);
	}
}