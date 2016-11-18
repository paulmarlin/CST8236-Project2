using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeCameraPerspective : MonoBehaviour
{

	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			Camera main = GetComponent <Camera> ();
			if (main == null)
				return;
			
			main.orthographic = !main.orthographic;
		}
	}
}
