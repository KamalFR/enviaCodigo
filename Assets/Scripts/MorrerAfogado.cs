using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MorrerAfogado : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject gameControler;
    // Colocar nas aguas e em lugares que s�o poss�veis cair do mapa, colocar um collider com Trigger ligado.
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Death") {
            canvas.SetActive(true);
            gameControler.SetActive(true);
            Camera.main.GetComponent<AudioSource>().mute = true;
            Time.timeScale = 0;
        }
    }
}
