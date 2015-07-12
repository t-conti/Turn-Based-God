using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDataBase : MonoBehaviour {

	public List<Item> items = new List<Item>();

	// Use this for initialization
	void Start () 
	{
		items.Add (new Item ("A_Armor06", 0, "Cool", 10, 10, 1, Item.ItemType.Chest) );
		items.Add (new Item ("A_Armor05", 0, "Cooler", 10, 10, 1, Item.ItemType.Chest) );
		items.Add (new Item ("I_Antidote", 0, "this is even cooler than that stupid shit", 10, 10, 1, Item.ItemType.Consumable) );
		items.Add (new Item ("A_Armor04", 0, "eh, nawh", 10, 10, 1, Item.ItemType.Chest) );
	}
	

}
