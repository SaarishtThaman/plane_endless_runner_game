using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
	public float yLimit;
	public float endX;
	public float resetX;
	private float speed;
	public float minSpeed, maxSpeed;

	void Start() {
		speed = Random.Range(maxSpeed,minSpeed);
	}
	
	void Update() {
		if(transform.localPosition.x < endX) {
			Vector3 newPos = transform.position;
			newPos.x = resetX;
			newPos.y = Random.Range(-yLimit,yLimit);
			transform.position = newPos;
			speed = Random.Range(maxSpeed,minSpeed);
		}
		transform.Translate(speed*Time.deltaTime,0,0);
	}
}
