using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
public class _enemyCustomization : NetworkBehaviour
{

    
    public GameObject[] hairPiece;
    public GameObject[] Top;
    public GameObject[] Bottom;
    public GameObject[] FacialHair;
    public GameObject[] Eyewear;
    public GameObject[] Hat;

    private int curHairpiece = -1;
    private int curTop = -1;
    private int curBottom = -1;
    private int curFacialhair = -1;
    private int curEyewear = -1;
    private int curHat = -1;
    void Start()
    {
        Randomize();
    }



    public void Randomize()
    {
        curHairpiece = Random.Range(0, hairPiece.Length);
        curTop = Random.Range(0, Top.Length);
        curBottom = Random.Range(0, Bottom.Length);
        curEyewear = Random.Range(0, Eyewear.Length);
        curFacialhair = Random.Range(0, FacialHair.Length);
        curHat = Random.Range(0, Hat.Length);
        for (int i = -0; i < hairPiece.Length; i++)
        {
            hairPiece[i].SetActive(false);
        }
        hairPiece[curHairpiece].SetActive(true);

        for (int i = -0; i < Top.Length; i++)
        {
            Top[i].SetActive(false);
        }
        Top[curTop].SetActive(true);

        for (int i = -0; i < Bottom.Length; i++)
        {
            Bottom[i].SetActive(false);
        }
        Bottom[curBottom].SetActive(true);

        for (int i = -0; i < Eyewear.Length; i++)
        {
            Eyewear[i].SetActive(false);
        }
        Eyewear[curEyewear].SetActive(true);

        for (int i = -0; i < FacialHair.Length; i++)
        {
            FacialHair[i].SetActive(false);
        }
        FacialHair[curFacialhair].SetActive(true);
    }
   
}
