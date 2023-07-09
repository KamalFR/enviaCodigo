using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBuffer : MonoBehaviour
{
    [SerializeField] private float _time;
    [SerializeField] private Sprite _hugoMaior;
    [SerializeField] private Sprite _hugoMenor;
    [SerializeField] private GameObject _hitBoxSmall;
    [SerializeField] private GameObject _hitBoxBig;
    private bool grande;

    // Tenho que fazer o buffer de crescimento trocar o buffer
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D boxColliderS = _hitBoxSmall.GetComponent<BoxCollider2D>();
        BoxCollider2D boxColliderB = _hitBoxBig.GetComponent<BoxCollider2D>();

        _hitBoxBig.SetActive(false);
        grande = false;
    }

    // Update is called once per frame
    void Update()
    {    
 
    }


    public bool Buffer()
    {
        if (!grande)
        {
            SpriteRenderer sprt = GetComponent<SpriteRenderer>();
            sprt.sprite = _hugoMaior;
            _hitBoxSmall.SetActive(false);
            _hitBoxBig.SetActive(true);
            grande = true;
            // Mudar o sprite do buffer!!!!!
        }
        else
        {
            // Código de deixar ele com o porrete
        }

        return grande;
    }


}
