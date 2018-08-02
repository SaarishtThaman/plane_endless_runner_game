using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour {
	public float endX;
	public float resetX;
	public float BGSpeed;

	void Update() {
		if(transform.localPosition.x <= endX) {
			Vector3 newPos = transform.position;
			newPos.x = resetX;
			transform.position = newPos;
		}

		transform.Translate(BGSpeed*Time.deltaTime,0,0);
	}
}