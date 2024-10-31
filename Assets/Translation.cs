using System. Collections;
using System. Collections. Generic;
using UnityEngine;


public class Translation: MonoBehaviour
{
	private Transform pave;
	private const float vitesse = 3;
	private float periode;
	
	void Start ()
	{
		this. pave = transform;
	}
	
	void Update ()
	{
		this. periode = Time. deltaTime;
		this. pave. position += Vector3. forward * Translation. vitesse * this. periode;
	}
}
