using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour {
	private float timeBtwSpawn;
	public float startTimeBtwSpawn, decreaseTime,minTime;
	public GameObject[] laserPattern;
	void Update() {
		if(timeBtwSpawn <= 0) {
			int rand = Random.Range(0,laserPattern.Length);
			Instantiate(laserPattern[rand],transform.position,Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;
			if(startTimeBtwSpawn > minTime) {
				startTimeBtwSpawn -= decreaseTime;
			}
		}
		else {
			timeBtwSpawn -= Time.deltaTime;
		}
	}
}