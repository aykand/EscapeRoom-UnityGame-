﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonlvltwo : MonoBehaviour
{
    private DisplayImageTwo currentDisplay;

    private float FirstCameraSize;
    private Vector3 FirstCameraPosition;



    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImageTwo>();

        FirstCameraSize = Camera.main.orthographicSize;
        FirstCameraPosition = Camera.main.transform.position;
    }

    public void RightArrowClick()
    {
        currentDisplay.CurrentRoom = currentDisplay.CurrentRoom + 1;

    }

    public void LeftArrowClick()
    {
        currentDisplay.CurrentRoom = currentDisplay.CurrentRoom - 1;
    }
    public void ZoomOut()
    {
        GameObject.Find("displayImage").GetComponent<DisplayImageTwo>().CurrentState = DisplayImageTwo.State.normal;
        var zoomInObjects = FindObjectsOfType<ObjectZoom>();
        foreach (var zoomInObject in zoomInObjects)
        {
            zoomInObject.gameObject.layer = 0;
        }
        Camera.main.orthographicSize = FirstCameraSize;
        Camera.main.transform.position = FirstCameraPosition;
    }

}
