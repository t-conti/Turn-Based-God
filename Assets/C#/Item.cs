using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public string itemName, itemDesc;
	public int itemID;
	public Sprite itemIcon;
	public GameObject itemModel;
	public int itemPower, itemSpeed, itemValue;

	public ItemType itemType;

	public enum ItemType
	{
		Weapon,
		Consumable,
		Quest,
		Head,
		Neck,
		Chest,
		Legs,
		Feet,
		Hands,
		Shoulders,
	}

	public Item(string name, int id, string desc, int power, int speed, int itemValue, ItemType type)
	{
		itemName = name;
		itemID = id;
		itemDesc = itemDesc;
		itemPower = itemPower;
		itemSpeed = itemSpeed;
		itemValue = itemValue;
		itemType = type;
		itemIcon = Resources.Load<Sprite> ("" + name);
	}


	public Item()
	{

	}

}
