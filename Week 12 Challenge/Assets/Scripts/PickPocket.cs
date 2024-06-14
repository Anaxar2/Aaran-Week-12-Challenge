using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPocket : MonoBehaviour
{
    // pickpocket range
    public float pickPocketRange = 3;

    //how long it takes to pickpocket
    public float 

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the e key is helddown and player is within pickpocket range
        if (Input.GetKey(KeyCode.E))
        {
            //start pickpocketing funtion
            PickPocketing();
        }
    }
    private void PickPocketing()
    {
        if(Vector3.Distance(player.transform, //NPC) < pickPocketRange)
    }
}
