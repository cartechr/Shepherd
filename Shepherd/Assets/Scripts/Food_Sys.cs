using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Sys : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("You are Eating!");
        }
    }


}
