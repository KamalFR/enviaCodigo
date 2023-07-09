using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPtero : MonoBehaviour
{
    [SerializeField] private AvancaPtero avancar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            avancar.liberar();
        }
    }
}
