using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool canSpawn = true;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;
    // Update is called once per frame

    void Start()
    {
        InvokeRepeating("changeCanSpawn", startDelay, spawnInterval);
    }
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn = false;
        }
    }

    void changeCanSpawn ()
    {
        canSpawn = true;
    }
}
