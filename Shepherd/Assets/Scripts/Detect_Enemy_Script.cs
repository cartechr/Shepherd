using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Enemy_Script : MonoBehaviour
{
    public GameObject Fox;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Fox"))
        {
            Debug.Log("Detected Fox");
            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("Kill Fox");
                Fox.SetActive(false);
            }

        }
    }
}
