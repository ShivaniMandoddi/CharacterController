using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerSpawnPoints;   // The parent of the spawn points
     Transform[] spawnPositions;
    private bool isRespawn = false;
    public bool respawnToggle = false;
    public Animator animator;
    // int k;
    private void Awake()
    {
        spawnPositions = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }
    void Start()
    {
      
        RandomSpawn();
        //Debug.Log(spawnPositions.Length);
    }

    public void RandomSpawn()
    {
        int i = UnityEngine.Random.Range(1, spawnPositions.Length);
        transform.position = spawnPositions[i].transform.position;

        Debug.Log(spawnPositions[i].transform.position);
        //return (i);
        
    }

    // Update is called once per frame
    void Update()
    {
        /*  if(respawnToggle!=isRespawn)
          {
              RandomSpawn();

              isRespawn = false;
          }
          else
          {
              respawnToggle = isRespawn;
          }
         /*if(Input.GetKeyDown(KeyCode.Space))
          {
              k=RandomSpawn();

          }        transform.position = spawnPositions[k].transform.position;*/
        
       
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            animator.SetBool("Attack", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Attack", false);
    }

}
