﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public GameObject otherPortal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");

        if(other.tag == "Player")
        {
            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1;
        }
    }




}
