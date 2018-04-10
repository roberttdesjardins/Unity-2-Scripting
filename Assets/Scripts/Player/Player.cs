using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour {

	public event Action<Player> onPlayerDeath;
	public int health = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void collidedWithEnemy(Enemy enemy) {
		enemy.Attack (this);
		if (health <= 0) {
			if (onPlayerDeath != null) {
				onPlayerDeath (this);
			}
		}
	}

	// Triggers when two rigidbodies with colliders touch
	void OnCollisionEnter(Collision col) {
		Enemy enemy = col.collider.gameObject.GetComponent<Enemy> ();
		if (enemy) {
			collidedWithEnemy (enemy);
		}
	}
}
