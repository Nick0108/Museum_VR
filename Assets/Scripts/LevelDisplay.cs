using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{

    public GameObject DisplayPlane;

    //private BoxCollider TriggerBox;
    private CanvasGroup canvas;
    private bool Fadein = false;
    private AudioSource panelFadeinSound;

    private void Start()
    {
        //TriggerBox = GetComponent<BoxCollider>();
        canvas = DisplayPlane.GetComponent<CanvasGroup>();
        canvas.alpha = 0.0f;
        panelFadeinSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Fadein == true)
        {
            if(canvas.alpha<1.0f)
                canvas.alpha += Time.deltaTime;
        }
        else
        {
            if (canvas.alpha > 0.0f)
                canvas.alpha -= Time.deltaTime;
        }   
    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter");
        DisplayPlane.SetActive(true);
        Fadein = true;
        panelFadeinSound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        DisplayPlane.SetActive(false);
        Fadein = false;
    }
}
