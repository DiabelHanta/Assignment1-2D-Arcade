﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	//PUBLIC INSTANCE VARIABLES
	public float speed;
	
	//On first frame
	void Start()
	{
		//Velocity property assigned to transform's property's sub-property: forward times speed
		GetComponent<Rigidbody> ().velocity = transform.right * speed;
	}
}