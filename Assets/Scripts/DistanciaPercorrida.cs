using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanciaPercorrida : MonoBehaviour
{
    void awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private float posicaoInicial;
    [SerializeField] private GameObject player;
    public float distancia = 4;
    void Start()
    {
        posicaoInicial = player.transform.position.x;
    }
    void Update()
    {
        // Debug.Log(distancia);
        distancia = player.transform.position.x - posicaoInicial;
    }

    public int getScore()
    {
        return (int) distancia;
    }
}
