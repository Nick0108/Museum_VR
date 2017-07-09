using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    public Transform startLine;
    public Transform EndLine;
    
    private LineRenderer Line;

    private void Start()
    {
        Line = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        //Line.SetPosition(0, startLine.position);
        Line.SetPosition(2,new Vector3(EndLine.position.x,0.03f, EndLine.position.z));
        Line.SetPosition(3, EndLine.position);
    }

}
