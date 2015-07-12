using UnityEngine;
using System.Collections;

public class OpenInventory : MonoBehaviour {

	public bool isHidden = false;
	public GameObject inv;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(Input.GetKeyUp(KeyCode.Tab))
		{
			if(!isHidden)
			{
				inv.SetActive (false);
				isHidden = true;
			}
			else if(isHidden)
			{
				inv.SetActive (true);
				isHidden = false;
			}
			
			
		}
	
	}
}
