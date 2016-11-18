using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour 
{
	private float rotationAngle = 0.0f;

	public float Speed = 1.0f;

	void Start () 
	{

	}

	void Update () 
	{
		rotationAngle += 50.0f * Speed * Time.deltaTime;

		transform.localRotation = Quaternion.Euler (0.0f, rotationAngle, 0.0f);
	}
}
