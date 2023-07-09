using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Teste");
        SceneManager.LoadScene("RandomScene");
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene("RandomScene");
        }
    }
}
