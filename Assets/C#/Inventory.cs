using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<GameObject> items = new List<GameObject> ();
	public List<SlotScript> slots = new List<SlotScript> ();

	public Transform itemBeingDragged;


	// Use this for initialization
	void Start () 
	{

		foreach(SlotScript slot in transform.GetComponentsInChildren<SlotScript>())
		{
			slots.Add(slot);
		}

	}

	public void AddItem(GameObject item)
	{
		foreach(SlotScript slot in slots)
		{
			if(slot.empty)
			{
				items.Add (item);
				item.SetActive (false);

				slot.GetComponent<Image>().sprite = item.GetComponent<Item>().itemIcon;
				slot.GetComponent<Image> ().color = new Color (255, 255, 255, 255);
				slot.empty = false;
				break;
			}
		}

	}



	

}
