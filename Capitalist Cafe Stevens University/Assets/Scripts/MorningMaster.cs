using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MorningMaster : MonoBehaviour
{

    public int maxNPCNum;
    //public Vector2 launchDirection;

    public NPCSpawner Spawner;
    public List<GameObject> customerList;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    //  NPCPrefab.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3);


    IEnumerator SpawnCoroutine()
    {
        int i = 0;
        while (i < maxNPCNum)
        {

            SpawnNPC();
            yield return new WaitForSeconds(20);

            i++;

        }

    }


    public void SpawnNPC()
    {
        GameObject newCustomer = Instantiate(Spawner.NPCPrefab);
        customerList.Add(newCustomer);
        newCustomer.GetComponent<Rigidbody2D>().transform.position = new Vector2(Random.Range(-2,3) , 7);
        newCustomer.GetComponent<Rigidbody2D>().velocity = new Vector2(0,-6);
        
    }

    public void TakeToMenu(){
        SceneManager.LoadScene("Order Slip Sample");
    }


   
}
