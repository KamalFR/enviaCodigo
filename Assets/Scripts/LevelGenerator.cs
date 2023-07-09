using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    [SerializeField] private const float playerDistanceSpawnPlatform = 50f;
    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform[] patterns;
    [SerializeField] private Vector3 platformDistance;
    [SerializeField] private GameObject player;
    [SerializeField] private float delayToDestroy;
    private Vector3 lastEndPosition;
    private float posY;

    // Start is called before the first frame update
    void Awake() {
        lastEndPosition = startPosition.position;
        for(int i = 0; i < 5; i++) StartCoroutine(SpawnPlatform());
    }

    // Update is called once per frame
    void FixedUpdate() {
        if(Vector3.Distance(player.transform.position, lastEndPosition) < playerDistanceSpawnPlatform) StartCoroutine(SpawnPlatform());
    }

    IEnumerator SpawnPlatform() {
        Transform lastPlatform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastPlatform.Find("EndPosition").position;
        yield return new WaitForSeconds(delayToDestroy);
        Destroy(lastPlatform.gameObject);
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition) {
        Transform pattern = patterns[UnityEngine.Random.Range(0, patterns.Length)];
        Transform newPlatform = Instantiate(pattern, spawnPosition, Quaternion.identity);
        return newPlatform;
    }
}
