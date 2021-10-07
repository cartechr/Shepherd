using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Position : MonoBehaviour
{
    public float verticalInput;
    // Update is called once per frame
    public void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

    }
}
