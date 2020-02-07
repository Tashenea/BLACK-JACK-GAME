﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{

    private bool isDragging = false;
    private bool isOverDropZone = false;
    private GameObject DropZone;
    private Vector2 startPosition;
    // Update is called once per frame
    void Update()
    {
        if(isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        isOverDropZone = true;
        DropZone = collision.gameObject;
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        DropZone = null;
    }
    public void StartDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    } virtua
    public void EndDrag()
    {
        isDragging = false;
        if(isOverDropZone)
        {
            transform.SetParent(DropZone.transform, false);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
