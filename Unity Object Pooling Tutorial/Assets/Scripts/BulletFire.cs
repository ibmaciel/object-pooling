using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

	public float fireTime = 0.5f;
	public GameObject bullet;

	public int pooledAmount = 20;
	List<GameObject> bullets;

	void Start () {
		
		bullets = new List<GameObject> ();
		for (int i = 0; i < pooledAmount; i++) {
			GameObject obj = Instantiate (bullet) as GameObject;
			obj.SetActive (false);
			bullets.Add (obj);
		}

		InvokeRepeating ("Fire", fireTime, fireTime);
	}

	void Fire () {
		for (int i = 0; i < bullets.Count; i++) {
			if (!bullets[i].activeInHierarchy) {
				bullets [i].transform.position = transform.position;
				bullets [i].transform.rotation = transform.rotation;
				bullets [i].SetActive (true);
				break;
			}
		}
	}
}
