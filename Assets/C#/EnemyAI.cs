using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public Transform target;
    public NavMeshAgent agent;
    public float distance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (target != null)
        {
            agent.SetDestination(target.position);

            //transform.Translate(0, 0, 0.01f);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
         target = col.transform;
    }
}
