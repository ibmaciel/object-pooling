using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {

	public float time = 2f;

	void OnEnable () {
		Invoke ("Destroy", time);
	}

	void Destroy () {
		gameObject.SetActive (false);
	}

	void OnDisable () {
		CancelInvoke ();
	}
}
