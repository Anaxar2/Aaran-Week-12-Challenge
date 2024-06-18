using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPocket : MonoBehaviour
{

    // pickpocket range
    public float pickPocketRange = 3;

    //how long it takes to pickpocket
    public float pickPocketTime = 5;

    //
    private GameObject NPC;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //if the e key is helddown and player is within pickpocket range
        Debug.Log("E key held down");

        if (Input.GetKey(KeyCode.E) && NPC !=null)
        {
            //start pickpocketing funtion
            Debug.Log("Attempting Pickpocket on NPC");
            PickPocketing();
        }
        else
        {
            Debug.Log("No npc target in range");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("npc"))
        {
            Debug.Log("Npc entered range");
            NPC = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("npc"))
        {
            Debug.Log("Npc exited range");
            NPC = null;
        }
    }

    private void PickPocketing()
    {
        bool success = Random.Range(0, 1) > 0.5f;
        if(success)
        {
            Debug.Log("Pickpocket Successful");
            //Add code to transfer items to player.
        }
        else
        {
            Debug.Log("Pickpocket Failed");
            //Add code too handle failure
        }
    }
}
