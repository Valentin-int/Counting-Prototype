using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Counter counter;
    public GameObject player;

    private float xSpawn = -0.24f;
    private float ySpawn = 9.48f;
    private float zSpawn = -0.31f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        NewPlayer();
    }

    void NewPlayer()
    {
        if (counter.playerIsCount == true)
        {
            Vector3 spawnPos = new Vector3(xSpawn, ySpawn, zSpawn);
            Instantiate(player, spawnPos, gameObject.transform.rotation);

            counter.playerIsCount = false;
        }
    }
}
