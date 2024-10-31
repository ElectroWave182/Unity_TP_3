using System. Collections;
using System. Collections. Generic;
using UnityEngine;


public class Rotation: MonoBehaviour
{
	private Transform pave;

	void Start ()
	{
		this. pave = transform;
	}
	
	void Update ()
	{
		this. pave. Rotate (0, 45, 0);
	}
}
