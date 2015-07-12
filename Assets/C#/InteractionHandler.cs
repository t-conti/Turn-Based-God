using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InteractionHandler : MonoBehaviour {

	public List <GameObject> objectsInteracting;
	public Inventory inventory;
	public GameObject target;
	public GameObject usePrompt;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.E) && objectsInteracting.Count > 0)
		{
			Debug.Log (target.name);
			Interact ();
		}

		if(objectsInteracting.Count > 0 && target == null)
			FindTarget();

		if (target != null)
			usePrompt.SetActive (true);
		else
			usePrompt.SetActive (false);

	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "NPC" ||  col.gameObject.tag == "UseableObject")
			objectsInteracting.Add (col.gameObject);
	}

	void OnTriggerExit(Collider col)
	{
		objectsInteracting.Remove (col.gameObject);

		if (target == col.gameObject)
			target = null;
	}

	void Interact()
	{
		if(target.tag == "UseableObject")
		{
			inventory.AddItem(target);
			objectsInteracting.Remove(target);
			target = null;
		}
	}

	void FindTarget()
	{
		float newDist = 0, oldDist = 10;

		foreach (GameObject go in objectsInteracting) 
		{
			newDist = (transform.position - go.transform.position).sqrMagnitude;

			if(Vector3.Angle(transform.forward, go.transform.position - transform.position) < 60 &&
			   newDist < oldDist )
			{
				target = go;

			}

			oldDist = newDist;
		}
	}
}
