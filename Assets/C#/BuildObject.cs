using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuildObject : MonoBehaviour {

	public GameObject buildMesh, menu;
	public GameObject  building;

	public bool objBeingPlaced = false, menuActive = false;
	public MouseLook mLook;

	
	// Update is called once per frame
	void Update () 
	{
	
		if(Input.GetKeyUp (KeyCode.B))
		{
			if(!menuActive)
			{
				menu.SetActive(true);
				menuActive = true;
			}
			else
			{
				menu.SetActive(false);
				menuActive = false;
				objBeingPlaced = false;
			}
		}

		if(objBeingPlaced)
		{
			mLook.enabled = false;
			buildMesh.SetActive(true);

			if(Input.GetMouseButtonDown(0))
			{
				building.transform.position = buildMesh.transform.position;
				building.SetActive(true);
			}
		}
		else
		{
			mLook.enabled = true;
			buildMesh.SetActive(false);
		}



	}




	public void EnableBuildMode()
	{
		objBeingPlaced = true;
	}

}
