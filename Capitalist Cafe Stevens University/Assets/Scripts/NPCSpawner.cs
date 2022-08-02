using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCSpawner : MonoBehaviour
{
    public int maxNPCNum;
    public Vector2 launchDirection;
    public Vector3 what;
    public GameObject NPCPrefab;
    public Rigidbody2D prefabRigidBody;
    public Transform NPCPrefabTransform;
    public int NPC_numTotal;
    public void Start()
    {
        StartCoroutine(SpawnCoroutine(NPC_numTotal));  
    }
    IEnumerator SpawnCoroutine(int NPC_numTotal)
    {
        int i = 0;
        while (i < maxNPCNum)
        {
            i++;
            what = NPCPrefab.GetComponent<Transform>().position;
            what.Set(0, 0, 0);
            SpawnNPC();
            yield return new WaitForSeconds(3);
            NPC_numTotal += 1;
            
        }
        
    }


    public void SpawnNPC()
    { 
        Instantiate(NPCPrefab);
        
        //launchDirection = this.GetComponent<Rigidbody2D>().velocity;
        //launchDirection.Set(0, -4);


    }
}
