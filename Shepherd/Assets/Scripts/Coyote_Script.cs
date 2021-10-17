using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Coyote_Script : MonoBehaviour
{
    NavMeshAgent CoyoteAgent;
    public Transform sheep;
    public Transform target1;
    public bool sheeptarget = false;
    private void Start()
    {
        CoyoteAgent = GetComponent<NavMeshAgent>();
        CoyoteAgent.destination = target1.position;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("Detected Sheep");
            //CoyoteAgent.enabled = false;
            sheeptarget = true;
        }
    }
    private void FixedUpdate()
    {
        if (sheeptarget == true)
        {
            this.gameObject.transform.position = sheep.position;
        }
        sheeptarget = false;
    }
}
