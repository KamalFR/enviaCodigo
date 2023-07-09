using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _tempoVariacaoVelocidade;
    [SerializeField] private float _quantidadeVariacaoVelocidade;
    [SerializeField] private GameObject player;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private float smoothTime = 0.25f;
    private Rigidbody2D _rigidBody;
    private float _deltaTime;
    // Start is called before the first frame update
    void Awake() {
        Camera.main.GetComponent<AudioSource>().mute = false;
        Time.timeScale = 1;
    }
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 TargetPosition = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref velocity, smoothTime);
        if(_speed < _maxSpeed)
            {
            if (_deltaTime > _tempoVariacaoVelocidade)
            {
                _speed = _speed + (Time.deltaTime * _quantidadeVariacaoVelocidade);
                _deltaTime = 0;
            }
        }
        _rigidBody.velocity = new Vector2(_speed, _rigidBody.velocity.y);
    }
}
