using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porrete : MonoBehaviour
{
    [SerializeField] private float upgradeTime = 20f;
    [SerializeField] public Boolean invulneravel;
    private float time;
    private void Start()
    {
        time = 0;
        invulneravel = false;
    }
    private void Update()
    {
        if (invulneravel == true)
        {
            time += Time.deltaTime;
            if (Math.Floor(time) == upgradeTime)
            {
                time = 0;
                invulneravel = false;
            }
        }

    }
    public void AtivaPorrete()
    {
        invulneravel = true;
    }
}
