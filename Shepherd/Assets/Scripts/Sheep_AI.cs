using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_AI : MonoBehaviour
{
    //public static List<GameObject> Sheep = new List<GameObject>();
    public Coyote_Script disablesheep;
    //public GameObject sheep;

    private void Update()
    {
        if (disablesheep.sheeptarget == true)
        {
            //this.gameObject.SetActive(false);
            Debug.Log("Coyote Killed Sheep");
        }
    }

}
   