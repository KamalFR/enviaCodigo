using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraPlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject gameControler;
    [SerializeField] GameObject _player;
    [SerializeField] Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!I_Can_See(_player))
        {
            canvas.SetActive(true);
            gameControler.SetActive(true);
            Camera.main.GetComponent<AudioSource>().mute = true;
            Time.timeScale = 0;
        }
    }


    private bool I_Can_See(GameObject Object)
    {

        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cam);
        if (GeometryUtility.TestPlanesAABB(planes, Object.GetComponent<Collider2D>().bounds))
            return true;
        else
            return false;
    }
}
