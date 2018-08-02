using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {
	public float speed;
	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Player")) {
			other.GetComponent<Player>().health--;
			Debug.Log(""+other.GetComponent<Player>().health);
			Destroy(gameObject);
		}
	}
	void Update() {
		transform.Translate(speed*Time.deltaTime,0,0);
		if(transform.position.x <= -12) {
			Destroy(gameObject);
		}
	}
}