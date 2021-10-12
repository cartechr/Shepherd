using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoyoteCollider : MonoBehaviour
{
    //public Coyote_Script target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("Detected Sheep");
        }
    }
}
