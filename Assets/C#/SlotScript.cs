using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour {

	public Item item;
	public Canvas myCanvas;
	public Camera mainCam;
	public Inventory myInv;

	Image itemImage;

	public bool dragEnabled = false, mouseOverMe = false;
	public bool empty = true;

	Vector3 defaultPosition, mousePos, currentPos;

	// Use this for initialization
	void Start () 
	{
		itemImage = gameObject.GetComponent<Image> ();
		defaultPosition = transform.localPosition;
		myInv = transform.GetComponentInParent<Inventory> ();
		//defaultPosition.z = 0
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(dragEnabled)
		{
			Vector2 pos;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
			transform.position = myCanvas.transform.TransformPoint(pos);
			//transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 2);
			myInv.itemBeingDragged = transform;

		}
		else
		{
			transform.localPosition = defaultPosition;
		}

		Vector3 temp;

		if(Input.GetKeyUp(KeyCode.Mouse0))
		{
			
			if (mouseOverMe && myInv.itemBeingDragged != null) 
			{
				temp = myInv.itemBeingDragged.GetComponent<SlotScript>().defaultPosition;
				myInv.itemBeingDragged.GetComponent<SlotScript>().defaultPosition = defaultPosition;
				defaultPosition = temp;

				int a, b;
				a = int.Parse(myInv.itemBeingDragged.gameObject.name);
				b = int.Parse(gameObject.name);

				GameObject tempGo = myInv.items[a];
				myInv.items[a] = myInv.items[b];
				myInv.items[b] = tempGo;
				tempGo = null;

				myInv.itemBeingDragged = null;
			}
		}

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
	void EnableDrag()
	{
		dragEnabled = true;
	}
	void DisableDrag()
	{
		dragEnabled = false;
	}



}
