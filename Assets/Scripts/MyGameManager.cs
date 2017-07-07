using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour {

    public enum LevelNum
    {
        level_1,
        level_2,
        level_3,
        level_4,
        level_5
    }

    public LevelNum currentLevel;
    public int ReadNum;
    public AudioClip[] levelBGM;
    public GameObject CompletePlane;

    private AudioSource BGMSource;
    private void Start()
    {
        currentLevel = LevelNum.level_1;
        ReadNum = 0;
        BGMSource = GetComponent<AudioSource>();
        BGMplay(0);
    }

    private void BGMplay(int BGMNum)
    {
        BGMSource.clip = levelBGM[BGMNum];
        BGMSource.Play();
    }


    public void SetLevel()
    {
        if (ReadNum == 6)
        {
            currentLevel = LevelNum.level_2;
            BGMplay(1);
        }
        if (ReadNum == 9)
        {
            currentLevel = LevelNum.level_3;
            BGMplay(2);
        }
        if (ReadNum == 12)
        {
            currentLevel = LevelNum.level_4;
            BGMplay(3);
        }
        if (ReadNum == 15)
        {
            currentLevel = LevelNum.level_5;
            BGMplay(4);
        }
        if (ReadNum == 21)
        {
            CompletePlane.SetActive(true);
        }
    }
}

