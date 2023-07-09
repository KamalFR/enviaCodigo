using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvancaPtero : MonoBehaviour
{
    [SerializeField] private float avancar;
    [SerializeField] private SpriteRenderer imagem;
    private Boolean liberado;
    private Vector3 mover;
    private void Start()
    {
        liberado = false;
        mover = transform.position;
        imagem.enabled = false;
    }
    private void FixedUpdate()
    {
        if (liberado)
        {
            mover.x += -avancar;
            transform.position = mover;
        }
    }
    public void liberar()
    {
        imagem.enabled = true;
        liberado = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
