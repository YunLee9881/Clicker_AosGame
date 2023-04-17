using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    bool SceneClick = false;
    int level;
    int MaxExp,exp,expCnt;
    long Score;
    int levelScore; 
    public GameObject targetCharacter;
 

    public void OnMouseDown()
    {
        SceneClick = true;
    }

    private int levelchanger(int level)
    {
        if (exp == MaxExp)
        {
            expCnt++;
            return level++;
        }
        return 0;
    }

    private void levelScoreDec(int level) 
    { 
        switch (level) 
        {
            case 0: levelScore = 40; break;
            case 1: levelScore = 80; break;
            case 2: levelScore = 120; break;
            case 3: levelScore = 240; break;
            case 4: levelScore = 360; break;
            case 5: levelScore = 760; break;
            case 6: levelScore = 980; break;
            case 7: levelScore = 1320; break;
            case 8: levelScore = 1620; break;
            default: levelScore = 2000; break;

        }
    
    }
    private void levelExp()
    {
        switch(expCnt) 
        {
            case 0: MaxExp = 500; break; 
            case 1: MaxExp = 700; break; 
            case 2: MaxExp = 900; break; 
            case 3: MaxExp = 1100; break; 
            case 4: MaxExp = 1300; break; 
            case 5: MaxExp = 1500; break;
            default: MaxExp = 2000; break;
        
        }

    }

    private void AddAScore()
    {
        if(SceneClick) { Score += levelScore; }

    }


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
