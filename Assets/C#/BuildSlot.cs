using UnityEngine;
using System.Collections;

public class BuildSlot : MonoBehaviour {

	public bool mouseOverMe = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MouseEnter()
	{
		Debug.Log (transform.name);
		mouseOverMe = true;
	}
	void MouseExit()
	{
		mouseOverMe = false;
	}


}
