using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAutoHorizontal : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject jogador;
    [SerializeField] private Boolean canMove = true;
    private Boolean jogadorBateu;
    private void Start() {
        jogador = GameObject.Find("Player");
        jogadorBateu = false;
    }

    private void FixedUpdate() {
        if (jogadorBateu && canMove == true) {
            Debug.Log("Movendo");
            rb.velocity = jogador.GetComponent<PlayerMovement>().movement;
            // rb.MovePosition(rb.position + movement * jogador.GetComponent<PlayerMovement>()._speed * Time.fixedDeltaTime);
        } else {
            rb.velocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Player") {
            jogadorBateu = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collider) {
        // Debug.Log("Para1");
        if(collider.gameObject.tag == "StopMovement") {
            // Debug.Log("Para2");
            canMove = false;
        }
    }
}
