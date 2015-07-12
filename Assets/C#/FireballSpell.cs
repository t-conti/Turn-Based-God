using UnityEngine;
using System.Collections;

public class FireballSpell : MonoBehaviour {

    public Transform[] fireBalls;
    int cnt = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, 2, 0);

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            //fireBalls[cnt].GetComponent<Rigidbody>().AddForce(0, 0, 3000);
            cnt++;
        }

	}
}
