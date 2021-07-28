using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ServerLoad : NetworkBehaviour {
    public List<GameObject> Players = new List<GameObject>();

    public GameObject[] playerAmt;
    private void Update()
    {
        if (isServer)
        {
          
            playerAmt = GameObject.FindGameObjectsWithTag("Player");
            
        }

    }




}
