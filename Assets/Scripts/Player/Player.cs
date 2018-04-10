using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int health = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void collidedWithEnemy(Enemy enemy) {
		if (health <= 0) {
			// TODO
		}
	}

	// Triggers when two rigidbodies with colliders touch
	void OnCollisionEnter(Collision col) {
		Enemy enemy = col.collider.gameObject.GetComponent<Enemy> ();
		collidedWithEnemy (enemy);
	}
}
