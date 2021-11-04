using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Follow : MonoBehaviour
{
    //Transform that NPC has to follow
    public Transform transformToFollow;
    //NavMesh Agent variable
    NavMeshAgent agent;
    //bool to check if sheep should follow player or not
    public Player follow;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //checks if sheep should follow player or not
        if (follow.followplayer == true)
        {
            //Follow the player
            agent.destination = transformToFollow.position;
            agent.isStopped = false;
        }
        if (follow.followplayer == false)
        {
            agent.isStopped = true;
        }
    }
}

// https://sharpcoderblog.com/blog/npc-follow-player-in-unity-3d //