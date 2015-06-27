﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private Rigidbody rbody;
	public float speed = 1;

	private Vector3 target;

	void Awake(){
		rbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
		Vector3 fwd = transform.forward;
		rbody.MovePosition(rbody.position + fwd * speed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision other){
		Debug.Log("player got hit");
		Destroy(this.gameObject);
	}

}
