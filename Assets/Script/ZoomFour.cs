﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomFour : MonoBehaviour
{
    private DisplayImageFour currentDispaly;

    private void Start()
    {
        currentDispaly = GameObject.Find("displayImage").GetComponent<DisplayImageFour>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Zoomable")
            {
                hit.transform.GetComponent<IZoomableFour>().ZoomFour(currentDispaly);
            }
        }
    }
}
