using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MorningMaster : MonoBehaviour
{

    public int maxNPCNum;
    //public Vector2 launchDirection;

    public NPCSpawner Spawner;
    public List<GameObject> customerList;
    public TMP_Dropdown orderMenu;
    public TMP_Text tempQuotaScore;
    public Sprite Food;
    public int quotaProgress;
    public Slider quotaSlider;
    public TMP_Text totalCustomersServed;
    // Start is called before the first frame update
    void Start()
    {
        totalCustomersServed.SetText("Customers Served "+CafeManager.customersServed + "" + " of " + maxNPCNum + "");
        quotaProgress += CafeManager.QuotaScore;
        tempQuotaScore.SetText(quotaProgress + "");
        setQuota();
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    //  NPCPrefab.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3);

    private void FixedUpdate()
    {
        if (CafeManager.customersServed== maxNPCNum)
        {
            CafeManager.finalScore = quotaProgress;
            SceneManager.LoadScene("gameEnd");


        }
    }
    IEnumerator SpawnCoroutine()
    {
        
        while (CafeManager.customersServed != maxNPCNum)
        {

            SpawnNPC();
            yield return new WaitForSeconds(20);

            

        }

    }

    public void setQuota()
    {
        quotaSlider.maxValue = 15;






    }



    public void SpawnNPC()
    {
        GameObject newCustomer = Instantiate(Spawner.NPCPrefab);
        customerList.Add(newCustomer);
        newCustomer.GetComponent<Rigidbody2D>().transform.position = new Vector2(Random.Range(-2,3) , 7);
        newCustomer.GetComponent<Rigidbody2D>().velocity = new Vector2(0,-6);
        
    }

    public void TakeToMenu()
    {

        int chosenMinigame = Random.Range(0, 3);

        if (chosenMinigame == 0)
        {

            SceneManager.LoadScene("drinkMinigame");


        }
        else if (chosenMinigame == 1)
        {

            SceneManager.LoadScene("CookingMinigame");

        }

        else if (chosenMinigame == 2)
        {

            SceneManager.LoadScene("Dessert");


        }


        /* List<Sprite> list = new List<Sprite>();
         List<string> nameList = new List<string>();
         nameList.Add(Food.name);
         list.Add(Food);
         orderMenu.AddOptions(list);
        */



    }
}
