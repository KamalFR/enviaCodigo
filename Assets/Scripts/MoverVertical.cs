using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverVertical : MonoBehaviour {
    private Vector3 mousePositionOffset;
    [SerializeField] private Boolean canMove = true;
    private Vector3 mover;

    private void Start() {
        mover = transform.position;
    }
    
    private Vector3 GetMouseWorldPosition() {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    
    private void OnMouseDown() {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }
    
    private void OnMouseDrag() {
        if(GetMouseWorldPosition().y < transform.position.y) {
            mover.y = GetMouseWorldPosition().y + mousePositionOffset.y;
            transform.position = new Vector3(transform.position.x, mover.y, transform.position.z);
            canMove = true;
        } else if(canMove) {
            mover.y = GetMouseWorldPosition().y + mousePositionOffset.y;
            transform.position = new Vector3(transform.position.x, mover.y, transform.position.z);
        }
    }

    private void OnTriggerStay2D(Collider2D collider) {
        // Debug.Log("Para1");
        if(collider.gameObject.tag == "StopMovementVertical") {
            // Debug.Log("Para2");
            canMove = false;
        }
    }
}