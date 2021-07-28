using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;

public class Health : NetworkBehaviour
{
    public SaveNLoad saveData;
    public PlayerStats playerStats;
    public const int maxHealth = 100;
    public bool destroyOnDeath;
    public Text nameDisplay;

    [SyncVar(hook = "OnChangeHealth")]
    public int currentHealth = maxHealth;

    [SyncVar(hook = "OnNameChange")]
    public string playerName;




    public RectTransform healthBar;

    private NetworkStartPosition[] spawnPoints;

    void Start()
    {


        if (isLocalPlayer)
        {
            spawnPoints = FindObjectsOfType<NetworkStartPosition>();
        }
        saveData = GameObject.Find("SaveNLoad").GetComponent<SaveNLoad>();
        playerStats = GameObject.Find("Local").GetComponent<PlayerStats>();
        InvokeRepeating("Regen", playerStats.regenSpeed, 5);
        if (nameDisplay != null)
        {
            nameDisplay.text = playerName;
        }

    }
    private void Update()
    {
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    private void OnStartClient()
    {
        OnNameChange(playerName);   // Call it directly to update UI Text component on other clients who join the game later.
    }
    private void OnNameChange(string newValue)
    {
        nameDisplay.text = newValue;  // Unity's UI Text component
    }

    public void TakeDamage(int amount)
    {
        if (!isServer)
            return;

        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
                    playerStats.curXP += 10;
            }
            else
            {
                currentHealth = maxHealth;

                // called on the Server, invoked on the Clients
                RpcRespawn();
            }
        }
    }

    void OnChangeHealth(int currentHealth)
    {
        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
    }
    void Regen()
    {
        currentHealth += 5;
    }

    [ClientRpc]
    void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            // Set the spawn point to origin as a default value
            Vector3 spawnPoint = Vector3.zero;

            // If there is a spawn point array and the array is not empty, pick one at random
            if (spawnPoints != null && spawnPoints.Length > 0)
            {
                spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
            }

            // Set the player’s position to the chosen spawn point
            transform.position = spawnPoint;
        }
    }
}