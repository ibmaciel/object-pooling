using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 5;

	void Update () {
		transform.Translate (0, speed * Time.deltaTime, 0);
	}
}
