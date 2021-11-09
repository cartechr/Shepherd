using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] List<GameObject> Sheep;
    [SerializeField] List<GameObject> Food;
    static GameController _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this);
        }
    }


    void InformSheep()
    {
        for (int i = 0; i < Sheep.Count; i++)
        {
            float distance = float.MaxValue;
            int closestFoodID = -1;

            for (int j = 0; j < Food.Count; j++)
            {
                float dist = Vector3.Distance(Sheep[i].transform.position, Food[j].transform.position);
                if (dist < distance)
                {
                    distance = dist;
                    closestFoodID = j;
                }
            }

            if (closestFoodID != -1)
            {
                //Sheep[i].GetFood(Food[closestFoodID], distance);
            }

        }
    }
}
