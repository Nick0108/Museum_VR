using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public bool isHorizontal = true;
    public float moveDistance = 2.5f;
    public MyGameManager.LevelNum openLevel;
    public MyGameManager myGameManager;
    public bool opened = false;

    private Transform doorTransform;
    private AudioSource doorOpenSound;

    private void Start()
    {
        doorTransform = GetComponent<Transform>();
        doorOpenSound = gameObject.GetComponentInParent<AudioSource>();

    }

    private void Update()
    {
        if (myGameManager.currentLevel == openLevel && !opened)
        {
            OpenDoor();
            opened = true;
        }
    }

    void OpenDoor()
    {
        //doorTransform.Translate(new Vector3(moveX, 1.257544f, 0f));
        doorOpenSound.Play();
        if (isHorizontal)
        {
            iTween.MoveTo(gameObject,
                iTween.Hash(
                "position", new Vector3(doorTransform.position.x + moveDistance, doorTransform.position.y, doorTransform.position.z),
                "time", 1.0f,
                "easetype", "linear"
                )
            );
        }
        else
        {
            iTween.MoveTo(gameObject,
                iTween.Hash(
                "position", new Vector3(doorTransform.position.x, doorTransform.position.y, doorTransform.position.z + moveDistance),
                "time", 1.0f,
                "easetype", "linear"
                )
            );
        }
    }
}
