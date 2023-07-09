using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHorizontal : MonoBehaviour {
    private Vector3 mousePositionOffset;
    private Vector3 mover;
    private bool touchingLeft = false;
    private bool touchingRight = false;
    private Transform rangeLeft;
    private Transform rangeRight;
    [SerializeField] float distance;
    [SerializeField] LayerMask isWall;
    private Rigidbody2D rb;
    
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        mover = transform.position;
        rangeLeft = transform.GetChild(0);
        rangeRight = transform.GetChild(1);
    }

    void Update () {
        if(Physics2D.Raycast(rangeLeft.position, Vector2.left, distance, isWall)) {
            touchingLeft = true;
        } else {
            touchingLeft = false;
        }
        if(Physics2D.Raycast(rangeRight.position, Vector2.right, distance, isWall)) {
            touchingRight = true;
        } else {
            touchingRight = false;
        }
		transform.eulerAngles = new Vector3(0, 0, 0);
	}

    private Vector3 GetMouseWorldPosition() {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown() {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag() {
        if(GetMouseWorldPosition().x < transform.position.x && !touchingLeft) { //movendo para a esquerda
            mover.x = GetMouseWorldPosition().x + mousePositionOffset.x;
            transform.position = mover;
            // rb.velocity = new Vector3(-3, 0, 0);
        }

        else if(GetMouseWorldPosition().x > transform.position.x && !touchingRight) { //movendo para a direita
            mover.x = GetMouseWorldPosition().x + mousePositionOffset.x;
            transform.position = mover;
            // rb.velocity = new Vector3(3, 0, 0);
        }
    }

    private void OnDrawGizmosSelected() {
        rangeLeft = transform.GetChild(0);
        rangeRight = transform.GetChild(1);
        Gizmos.DrawLine(rangeLeft.position, new Vector2(rangeLeft.position.x - distance, rangeLeft.position.y));
        Gizmos.DrawLine(rangeRight.position, new Vector2(rangeRight.position.x + distance, rangeRight.position.y));
    }

    // void OnCollisionEnter2D(Collision2D collisionInfo) { //you can change this to OnCollisionStay or OnTriggerStay
    //     Debug.Log("Entrei");
    //     var direction = transform.InverseTransformPoint (collisionInfo.transform.position); //this helps us find which direction the object collided from
 
    //     if (direction.x > 0f) { //Change the axis to fit your needs
    //             Debug.Log("right");
    //             touchingRight = true;
    //         }
    //     }
    // }

    // void OnCollisionExit2D(Collision2D collisionInfo) { //you can change this to OnCollisionStay or OnTriggerStay
    //     Debug.Log("Sai");
    //     touchingLeft = false;
    //     touchingRight = false;
    // }
}