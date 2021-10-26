using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoyoteCollider : MonoBehaviour
{
    public SheepHUD sheep;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sheep"))
        {
            sheep.TakeDamage(20);
            Debug.Log("Coyote Bites Sheep");

        }
    }
}
