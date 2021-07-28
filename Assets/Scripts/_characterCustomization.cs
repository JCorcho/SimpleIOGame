using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _characterCustomization : MonoBehaviour {
    public SaveNLoad saveData;

    public GameObject[] hairPiece;
    public GameObject[] Top;
    public GameObject[] Bottom;
 //   public GameObject[] Footwear;
    public GameObject[] FacialHair;
    public GameObject[] Eyewear;
    public GameObject[] Hat;

    private int curHairpiece = -1;
    private int curTop = -1;
    private int curBottom = -1;
   // private int curFootwear = -1;
    private int curFacialhair = -1;
    private int curEyewear = -1;
    private int curHat = -1;

    public string saveCode;

    int characterCustomCode;
	void Start () {
        saveData = GameObject.Find("SaveNLoad").GetComponent<SaveNLoad>();
        curHairpiece = hairPiece.Length -1;
        curTop = Top.Length -1;
        curBottom = Bottom.Length -1;
        curFacialhair = FacialHair.Length -1;
        curEyewear = Eyewear.Length -1;
        curHat = Hat.Length -1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    

   public void choseHairPiece()
    {
        if (curHairpiece < (hairPiece.Length - 1))
        {
            
            curHairpiece++;
            for (int i = -0; i < hairPiece.Length; i++)
            {
                hairPiece[i].SetActive(false);
            }
            hairPiece[curHairpiece].SetActive(true);
        }
        else
        {
            curHairpiece = 0;
            for (int i = -0; i < hairPiece.Length; i++)
            {
                hairPiece[i].SetActive(false);
            }
            hairPiece[curHairpiece].SetActive(true);

        }
    }
   public void choseTop()
    {
        if (curTop < (Top.Length - 1))
        {

            curTop++;
            for (int i = -0; i < Top.Length; i++)
            {
                Top[i].SetActive(false);
            }
            Top[curTop].SetActive(true);
        }
        else
        {
            curTop = 0;
            for (int i = -0; i < Top.Length; i++)
            {
                Top[i].SetActive(false);
            }
            Top[curTop].SetActive(true);
        }
    }
   public void choseBottom()
    {
        if (curBottom < (Bottom.Length - 1))
        {

            curBottom++;
            for (int i = -0; i < Bottom.Length; i++)
            {
                Bottom[i].SetActive(false);
            }
            Bottom[curBottom].SetActive(true);
        }
        else
        {
            curBottom = 0;
            for (int i = -0; i < Bottom.Length; i++)
            {
                Bottom[i].SetActive(false);
            }
            Bottom[curBottom].SetActive(true);
        }
    }
   /*public void choseFootwear()
    {
        if (curFootwear < (Footwear.Length - 1))
        {

            curFootwear++;
            for (int i = -0; i < Footwear.Length; i++)
            {
                Footwear[i].SetActive(false);
            }
           Footwear[curFootwear].SetActive(true);
        }
        else
        {
            curFootwear = 0;
            for (int i = -0; i < Footwear.Length; i++)
            {
                Footwear[i].SetActive(false);
            }
            Footwear[curFootwear].SetActive(true);
        }
    }
    */
   public void choseFacialHair()
    {
        if (curFacialhair < (FacialHair.Length - 1))
        {

            curFacialhair++;
            for (int i = -0; i < FacialHair.Length; i++)
            {
                FacialHair[i].SetActive(false);
            }
            FacialHair[curFacialhair].SetActive(true);
        }
        else
        {
            curFacialhair = 0;
            for (int i = -0; i < FacialHair.Length; i++)
            {
                FacialHair[i].SetActive(false);
            }
            FacialHair[curFacialhair].SetActive(true);
        }
    }
   public void choseEyeWear()
    {
        if (curEyewear < (Eyewear.Length - 1))
        {

            curEyewear++;
            for (int i = -0; i < Eyewear.Length; i++)
            {
                Eyewear[i].SetActive(false);
            }
            Eyewear[curEyewear].SetActive(true);
        }
        else
        {
            curEyewear = 0;
            for (int i = -0; i < Eyewear.Length; i++)
            {
                Eyewear[i].SetActive(false);
            }
            Eyewear[curEyewear].SetActive(true);
        }
    }

    public void choseHat()
    {
        if (curHat < (Hat.Length - 1))
        {

            curHat++;
            for (int i = -0; i < Hat.Length; i++)
            {
                Hat[i].SetActive(false);
            }
            Hat[curHat].SetActive(true);
        }
        else
        {
            curHat = 0;
            for (int i = -0; i < Hat.Length; i++)
            {
                Hat[i].SetActive(false);
            }
            Hat[curHat].SetActive(true);
        }
    }

   public void saveChar()
    {
        characterCustomCode = curHairpiece + curTop + curBottom /*+ curFootwear*/ + curEyewear + curFacialhair;
        saveCode = curHairpiece.ToString() + curTop.ToString() + curBottom.ToString() /*+ curFootwear.ToString() */ + curEyewear.ToString() + curFacialhair.ToString() + curHat.ToString();

        saveData.saveCode = saveCode;
        Debug.Log(saveCode + " Has Been Saved!");

        SceneManager.LoadScene("Main");
    }
   public void loadChar()
    {
        
        int.TryParse(saveData.saveCode.Substring(0, 1), out curHairpiece);
        int.TryParse(saveData.saveCode.Substring(1, 1), out curTop);
        int.TryParse(saveData.saveCode.Substring(2, 1), out curBottom);
       // int.TryParse(saveData.saveCode.Substring(3, 1), out curFootwear);
        int.TryParse(saveData.saveCode.Substring(3, 1), out curEyewear);
        int.TryParse(saveData.saveCode.Substring(4, 1), out curFacialhair);
        int.TryParse(saveData.saveCode.Substring(5, 1), out curHat);
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

       // for (int i = -0; i < Footwear.Length; i++)
      //  {
       //     Footwear[i].SetActive(false);
       // }
        //Footwear[curFootwear].SetActive(true);
        //for (int i = -0; i < FacialHair.Length; i++)
       // {
       //     FacialHair[i].SetActive(false);
        //}
        FacialHair[curFacialhair].SetActive(true);
        for (int i = -0; i < Eyewear.Length; i++)
        {
            Eyewear[i].SetActive(false);
        }
        Eyewear[curEyewear].SetActive(true);
        for (int i = -0; i < Hat.Length; i++)
        {
            Hat[i].SetActive(false);
        }
        Hat[curHat].SetActive(true);

    }
}
