using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public bool isDragging = false;
    private Vector2 touchOffset;
    public GameObject posObj;
    public Transform posTransform;
    
    public void StopDraggin()
    {
        isDragging = false;
        transform.position = posTransform.position;
    }

    void Start()
    {   
        posTransform = posObj.transform;
    }
    void Update()
    {
        #region MouseInput 
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                touchOffset = (Vector2)transform.position - mousePos;
            }
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            StopDraggin();
        }

        if (isDragging)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos + touchOffset;
        }
        #endregion
        
        #region TouchInput
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                touchOffset = (Vector2)transform.position - mousePos;
            }
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            StopDraggin();
        }

        if (isDragging)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            transform.position = mousePos + touchOffset;
        }
        #endregion
    }

}
