using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerStats : NetworkBehaviour {

    TPlayerController playerController;
    Health health;
    public GameObject Canvas;

    public Text LevelNXpUI;
    public Text skillPointsUI;

    public int curXP;
    public int maxXP = 100;

    public int curLVL = 1;
    public int maxLVL = 45;

    public int SkillPoints;

    public int Damage = 10;
    public int bulletSpeed = 10;
    public int regenSpeed = 10;


    public int speedLevel = 1;
    public int DamageLevel = 1;
    public int BulletSpeedLevel = 1;
    public int MaxHealthLevel = 1;
    public int HealthRegenLevel = 1;

    private void Start()
    {
        playerController = GameObject.Find("Local").GetComponent<TPlayerController>();
        health = GameObject.Find("Local").GetComponent<Health>();

        if(isLocalPlayer)
        {
            Canvas.SetActive(true);
        }
    }

    private void Update()
    {

        if (curXP >= maxXP)
        {
            LevelUp();
        }

       if(curLVL >= maxLVL)
        {
            curLVL = maxLVL;
        }

        LevelNXpUI.text = "Level " + curLVL + "    " + curXP + "/" + maxXP;
        skillPointsUI.text = "Points - " + SkillPoints;

        if (regenSpeed <= 1)
        {
            regenSpeed = 1;
        }
    }




    public void upgradeSpeed()
    {
        if (SkillPoints >= 1 && speedLevel <= 5)
        {
            playerController.m_moveSpeed += 1;
            SkillPoints -= 1;
            speedLevel += 1;
        }
    }

    public void upgradeBulletDamage() //upgrade the damage the bullet applies to the GameObject it hits.
    {
        if (SkillPoints >= 1 && DamageLevel <= 5)
        {
            Damage += 5;
            SkillPoints -= 1;

            DamageLevel += 1;
        }
    }
    
    public void upgradeBulletSpeed() //upgrade the force added to the bullet when spawned.
    {
        if (SkillPoints >= 1 && BulletSpeedLevel <= 5)
        {
            bulletSpeed += 5;
            SkillPoints -= 1;

            BulletSpeedLevel += 1;
        }
    }

    public void upgradeMaxHealth() //upgrades the max health.
    {
        if (SkillPoints >= 1 && MaxHealthLevel <= 5)
        {
            SkillPoints -= 1;
            MaxHealthLevel += 1;
        }
    }

    public void upgradeHealthRegen() //upgrades the health regeneration speed.
    {
        if (SkillPoints >= 1 &&HealthRegenLevel <= 5)
        {
            regenSpeed -= 1;
            SkillPoints -= 1;
            regenSpeed += 1;
        }
    }

    void LevelUp()
    {
        curLVL += 1;
        curXP = 0;
        maxXP += 100;
        SkillPoints += 1;
    }

}
