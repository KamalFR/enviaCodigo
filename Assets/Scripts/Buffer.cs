using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffer : MonoBehaviour
{
    private bool grande = false;
    [SerializeField] Sprite _marreta;
    [SerializeField] Sprite _carninha;

    private void Awake()
    {
            SpriteRenderer sprt = GetComponent<SpriteRenderer>();
            sprt.sprite = _carninha;
    }

    private void Update()
    {
        if (grande)
        {
            SpriteRenderer sprt = GetComponent<SpriteRenderer>();
            sprt.sprite = _carninha;
        }
        else
        {
            SpriteRenderer sprt = GetComponent<SpriteRenderer>();
            sprt.sprite = _marreta;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        grande = collision.GetComponent<GrowBuffer>().Buffer();
    }
}
