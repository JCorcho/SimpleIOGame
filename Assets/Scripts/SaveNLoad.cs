using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveNLoad : MonoBehaviour {

    public string saveCode;
    public string name;
    public InputField nameInput;
    public GameObject Player;

    public _characterCustomization CC;
    public Health health;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Local Player");
        if (Player != null)
        {
           loadChar();
        }
        
    }

    private void loadChar()
    {
        
        {
            CC = Player.GetComponent<_characterCustomization>();
            health = Player.GetComponent<Health>();
            health.playerName = name;
            CC.loadChar();
        }
    }

    public void saveName()
    {
        if (nameInput != null)
        {
            name = nameInput.text;
            Debug.Log(name);
        }
    }
}
