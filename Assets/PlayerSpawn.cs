using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerSpawnPoints;   // The parent of the spawn points
     Transform[] spawnPositions;
    public bool isRespawn = false;
    public bool respawnToggle = false; 
    void Start()
    {
        spawnPositions = playerSpawnPoints.GetComponentsInChildren<Transform>();
        //RandomSpawn();
        //Debug.Log(spawnPositions.Length);
    }

    public void RandomSpawn()
    {
        int i = UnityEngine.Random.Range(1, spawnPositions.Length);

        Debug.Log(spawnPositions[i].transform.position);
        this.transform.position = spawnPositions[i].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(respawnToggle!=isRespawn)
        {
            RandomSpawn();
            isRespawn = false;
        }
        else
        {
            respawnToggle = isRespawn;
        }*/
       if(Input.GetKeyDown(KeyCode.Space))
        {
            RandomSpawn();
        }
    }
}
