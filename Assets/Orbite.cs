using System;
using System. Collections;
using System. Collections. Generic;
using UnityEngine;


public class Orbite: MonoBehaviour
{
	private Transform pave;
	private const float vitesse = 1.5f;
	private const double rayon = 60;
	private float
		angle,
		periode
	;
	
	void Start ()
	{
		this. pave = transform;
		this. angle = 0;
	}
	
	void Update ()
	{
		this. periode = Time. deltaTime * Orbite. vitesse;
		this. angle += periode;
		this. pave. Rotate (0, -Orbite. degres (periode), 0);
		
		float x = Convert. ToSingle (Orbite. rayon * Math. Cos (angle));
		float z = Convert. ToSingle (Orbite. rayon * Math. Sin (angle));
		this. pave. position = new Vector3 (x, 0, z);
	}
	
	public static float degres (float radians)
	{
		return Convert. ToSingle (radians / Math. PI * 180);
	}
}
