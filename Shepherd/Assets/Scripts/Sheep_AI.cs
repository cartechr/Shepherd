using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_AI : MonoBehaviour
{
    GameObject[] Sheep;
    public float SpaceBetween = 1.5f;

    void Start()
    {
        Sheep = GameObject.FindGameObjectsWithTag("Sheep");
    }

    void Update()
    {
        foreach (GameObject go in Sheep)
        {
            if (go != gameObject)
            {
                float distance = Vector3.Distance(go.transform.position, this.transform.position);
                if (distance <= SpaceBetween)
                {
                    Vector3 direction = transform.position - go.transform.position;
                    transform.Translate(direction * Time.deltaTime);
                }
            }
        }
    }
}
   