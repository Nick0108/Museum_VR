using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Read : MonoBehaviour {

    public MyGameManager myGameManager;

    private void Start()
    {
        myGameManager = GetComponent<MyGameManager>();
    }

    public void HasRead()
    {
        gameObject.SetActive(true);
        myGameManager.ReadNum++;
        Debug.Log("ReadNum: "+ myGameManager.ReadNum);
        myGameManager.SetLevel();
    }
}
