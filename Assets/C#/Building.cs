using UnityEngine;
using System.Collections;

public class Building : BuildObject {

	public Collider myCollider;
	public Vector3 mousePosition;

	public float moveSpeed = 15;

	public LayerMask layerMask;

	public Color canBuild, cannotBuild;

	public BuildObject buildObject;

	MeshRenderer renderer;


	// Use this for initialization
	void Start () {
		myCollider = transform.GetComponent<Collider> ();
		canBuild = Color.green;
		cannotBuild = Color.red;

		renderer = gameObject.GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast(ray, out hit, 100.0F, layerMask))
		{
			float oldY = transform.position.y;
			transform.position = hit.point;
			transform.position = new Vector3(transform.position.x, 2, transform.position.z);
		}


	}

	void OnTriggerEnter(Collider col)
	{
		renderer.material.SetColor("_Color", cannotBuild);
		objBeingPlaced = false;

	}
	void OnTriggerExit(Collider col)
	{
		renderer.material.SetColor("_Color", canBuild);
	}
}
