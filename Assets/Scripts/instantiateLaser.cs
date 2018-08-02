using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateLaser : MonoBehaviour {
	public GameObject laser;
	void Start() {
		Instantiate(laser,transform.position,Quaternion.identity);
	}
}