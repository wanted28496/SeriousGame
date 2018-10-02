/*
 * Script for dragging object to the point user moves
 * created by: Mit Doshi
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

    public Camera camera;
    // Offest values to prevent shaking
    Vector3 offset;
    Vector3 point;
    // Rigidbody component
    Rigidbody rb;

    // boolean to stop the ball from moving
    bool isMoving = false;

    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // Touch touch = Input.GetMouseButtonDown(0);
        // Debug.Log(touch);
        // Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);


        //switch(touch.phase)
        //{
        //    case TouchPhase.Began:
        //        if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
        //        {
        //            deltaX = touchPos.x - transform.position.x;
        //            deltaY = touchPos.y - transform.position.y;
        //            isMoving = true;

        //            rb.freezeRotation = true;
        //            rb.velocity = new Vector2(0, 0);
        //            GetComponent<SphereCollider>().sharedMaterial = null;
        //        }
        //        break;
        //    case TouchPhase.Moved:
        //        if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && isMoving)
        //        {
        //            rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
        //        }
        //        break;
        //    case TouchPhase.Ended:
        //        isMoving = false;
        //        rb.freezeRotation = false;
        //        break;
        //}
	}

    private void OnMouseDown()
    {
        point = camera.WorldToScreenPoint(gameObject.transform.position);
        //offset = gameObject.transform.position - camera.WorldToScreenPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, point.z));
    }

    private void OnMouseDrag()
    {
        Vector3 currScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, point.z);
        Vector3 currPosition = camera.ScreenToWorldPoint(currScreenPoint);// - offset;

        gameObject.transform.position = currPosition;
    }

    void onStart()
    {

    } 

    void onDrag()
    {

    }

    void onEnd()
    {

    }
}
