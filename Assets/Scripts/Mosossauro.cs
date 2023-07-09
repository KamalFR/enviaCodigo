using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mosossauro : MonoBehaviour
{
    [SerializeField] private float tamanhoPulo;
    //[SerializeField] private Transform jogador;
    [SerializeField] private Animator animator;
    private Vector3 lugar;
    private Boolean atacou;


    private void Start()
    {
        lugar = transform.position;
        atacou = false;
    }
    public void ataque()
    {
        lugar.y += tamanhoPulo;
        transform.position = lugar;
        atacou = true;
    }
    public void volta()
    {
        lugar.y -= tamanhoPulo;
        transform.position = lugar;
        atacou = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator.SetBool("recuaAtaque", false);
            animator.SetBool("comecaAtaque", true);
            ataque();
            SceneManager.LoadScene("GameOver");
        }
    }
        
}
