using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Vector3 topPos;
	public Vector3 bottomPos;
	public Vector3 defaultPos;
	public float speed;
	int state = 0;
	[HideInInspector] public int health = 3;
	public GameObject gameOver;

	public void Update() {
		if(Input.GetKeyDown(KeyCode.UpArrow) && state > -1) {
			state--;
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow) && state < 1) {
			state++;
		}

		if(state == -1) {
			transform.Translate((topPos-transform.position) * Time.deltaTime * speed);
		}
		else if(state == 1) {
			transform.Translate((bottomPos-transform.position) * Time.deltaTime * speed);
		}
		else {
			transform.Translate((defaultPos-transform.position) * Time.deltaTime * speed);
		}

		if(health <= 0) {
			Instantiate(gameOver,Vector3.zero,Quaternion.identity);
			Destroy(gameObject);
		}
	}
}