using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Coyote_Script : MonoBehaviour
{
    NavMeshAgent CoyoteAgent;
    public Transform target1;
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
            CoyoteAgent.enabled = false;
        }
    }
}
