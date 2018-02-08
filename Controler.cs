using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
	
	private Transform t;
	public float SpeedM;
	// Use this for initialization
	void Start ()
	{
		t = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame

	public static void Movment(int angle, Vector3 v1, Vector3 v2, ref Vector3 dir, Transform transform)
	{
		dir = v1 + v2;
		transform.rotation = Quaternion.Euler(0, angle,0);
	}
	
	void Update ()
	{
		Vector3 dir = Vector3.zero;
		if(Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.S))
		Movment(45, Vector3.left, Vector3.back, ref dir, transform);
		else if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.Z))
		Movment(135, Vector3.left, Vector3.forward, ref dir, transform);
		else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.Z))
		Movment(225, Vector3.forward, Vector3.right, ref dir, transform);
		else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
		Movment(315, Vector3.right, Vector3.back, ref dir, transform);
		else if (Input.GetKey(KeyCode.Q))
		Movment(90, Vector3.left, Vector3.zero, ref dir, transform);
		else if (Input.GetKey(KeyCode.Z))
		Movment(180, Vector3.forward, Vector3.zero, ref dir, transform);
		else if (Input.GetKey(KeyCode.D))
		Movment(270, Vector3.right, Vector3.zero, ref dir, transform);
		else if (Input.GetKey(KeyCode.S))
		Movment(0, Vector3.zero, Vector3.back, ref dir, transform);
		t.position += dir * Time.deltaTime * SpeedM;
	}
}
