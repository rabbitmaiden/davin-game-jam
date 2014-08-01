using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chunk1Wave : WaveScript {
	
	// Use this for initialization
	public void Awake() {
		// Parameter order: X position, Y position, enemy type, threat value
		// Enemy types: basic enemy, basic floater, Basic Wall, super baddy
		enemyPositions = new List<EnemyPosition>();
		
		/*
		enemyPositions.Add(new EnemyPosition(-3f, 3f, "super baddy", 1));
		enemyPositions.Add(new EnemyPosition(-3.5f, 2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(3f, 3f, "super baddy", 1));
		enemyPositions.Add(new EnemyPosition(3.5f, 2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-3f, 3f, "super baddy", 1));
		enemyPositions.Add(new EnemyPosition(-3.5f, 2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic floater", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(3f, 3f, "super baddy", 1));
		enemyPositions.Add(new EnemyPosition(3.5f, 2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic floater", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-2f, 0f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(2f, 1f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-3f, 3f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-4f, 6f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(5f, 5f, "basic enemy", 1));
		*/
	
		/*
		enemyPositions.Add(new EnemyPosition(4.5f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(3.5f, 1f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(1.5f, 3f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(0.5f, 4f, "basic floater", 1));
		*\
		
		/*
		enemyPositions.Add(new EnemyPosition(-4.5f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-3.5f, 1f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-1.5f, 3f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-0.5f, 4f, "basic floater", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(0f, 3f, "super baddy", 1));
		enemyPositions.Add(new EnemyPosition(-3f, 6f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(3f, 6f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-4.5f, 3f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(4.5f, 3f, "basic floater", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-4f, 6f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-3f, 6f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 6f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-0f, 4f, "super baddy", 1));
		enemyPositions.Add(new EnemyPosition(2f, 6f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(3f, 6f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(4f, 6f, "basic floater", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(4f, 0f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(2f, 0f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-4f, 4f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 4f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(4f, 8f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(2f, 8f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(0f, 5f, "basic floater", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-4f, 0f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 0f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(4f, 4f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(2f, 4f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-4f, 8f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 8f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(0f, 5f, "basic floater", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-4f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-1f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(4f, 4f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(1f, 4f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(2.5f, 6f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(4f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(1f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(2.5f, 2f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-4f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-1f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-2.5f, 2f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-4f, 1f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-3f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 1f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-1f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(0f, 1f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(1f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(2f, 1f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(3f, 0f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(4f, 1f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(0f, 4f, "super baddy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-4f, 5f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(4f, 5f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-4f, 5f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 2.2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(0f, 5f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(4f, 5f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(2f, 2.2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(0f, 5f, "basic enemy", 1));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 2.2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(2f, 2.2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(0f, 4f, "super baddy", 10));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(-2f, 2.2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(-4f, 2.2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(-2f, 4f, "super baddy", 10));
		*/
		
		/*
		enemyPositions.Add(new EnemyPosition(2f, 2.2f, "basic enemy", 1));
		enemyPositions.Add(new EnemyPosition(0f, 2.2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(4f, 2.2f, "basic floater", 1));
		enemyPositions.Add(new EnemyPosition(2f, 4f, "super baddy", 10));
		*/
		
	}
}
