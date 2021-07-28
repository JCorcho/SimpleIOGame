using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityClear : MonoBehaviour {

    private void Start()
    {
        Destroy(gameObject, 30.0f);
    }
}
