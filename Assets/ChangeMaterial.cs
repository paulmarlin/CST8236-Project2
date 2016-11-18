using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour
{
	void Start ()
	{
	
	}

	void Update ()
	{
		string material = null;

		if (Input.GetKeyDown(KeyCode.Alpha1))
            material = "Cube Material 1";		
		else if (Input.GetKeyDown(KeyCode.Alpha2))
            material = "Cube Material 2";		
		else if (Input.GetKeyDown(KeyCode.Alpha3))
            material = "Cube Material 3";		
		else if (Input.GetKeyDown(KeyCode.Alpha4))
            material = "Cube Material 4";		
		else if (Input.GetKeyDown(KeyCode.Alpha5))
            material = "Cube Material 5";		
		else if (Input.GetKeyDown(KeyCode.Alpha6))
            material = "Cube Material 6";		
		else
			return;

        Debug.Log(material);

		Material newMaterial = Resources.Load(material, typeof(Material)) as Material;
        Debug.Log("--GOT TO HERE--1");
        //if (newMaterial == null)
		//	return;

        Debug.Log("--GOT TO HERE--");

		MeshRenderer cubeRenderer = GetComponent <MeshRenderer> ();
		if (cubeRenderer == null)
			return;

		cubeRenderer.material = newMaterial;
        Debug.Log("--DONE--");
	}
}
