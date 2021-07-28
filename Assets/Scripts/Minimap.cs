using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Minimap : NetworkBehaviour {

    public Transform playerPos = null;


    void LateUpdate ()
	{
     
            GameObject Player = GameObject.Find("Local");
            if (Player != null)
            {
                playerPos = Player.GetComponent<Transform>();
                Vector3 newPosition = playerPos.position;
                newPosition.y = transform.position.y;
                transform.position = newPosition;

                // transform.rotation = Quaternion.Euler(90f, playerPos.eulerAngles.y, 0f);
            }
        

		
	}

    

}
