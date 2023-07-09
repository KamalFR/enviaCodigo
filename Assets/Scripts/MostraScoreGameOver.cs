using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostraScoreGameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private GameObject player;
    //[SerializeField] private GameObject _scoreHandler;
    private int _actualScore;
    // Start is called before the first frame update
    void Update()
    {
        _actualScore = player.GetComponent<DistanciaPercorrida>().getScore();
        _score.text = _actualScore.ToString();
    }
}