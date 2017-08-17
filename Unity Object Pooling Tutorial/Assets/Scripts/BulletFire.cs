using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

	public float fireTime = 0.5f;

	void Start () {		
		InvokeRepeating ("Fire", fireTime, fireTime);
	}

	void Fire () {
		GameObject obj = ObjectPooler.current.GetPooledObject ();

		if (obj == null)
			return;
		
		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);
	}
}
