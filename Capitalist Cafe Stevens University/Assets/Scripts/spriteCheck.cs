using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteCheck : MonoBehaviour
{


    public GameObject Locate1;
    public GameObject master;
    public drinkMinigame miniDrink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && master.GetComponent<drinkMinigame>().correctSprite == this.GetComponent<SpriteRenderer>().sprite)
        {
            Debug.Log("I Work!");
            miniDrink.drinkSetup();
            miniDrink.scoreVal++;
            miniDrink.score.SetText(miniDrink.scoreVal + "");
        }

        else if (Input.GetMouseButtonDown(0) && master.GetComponent<drinkMinigame>().correctSprite != this.GetComponent<SpriteRenderer>().sprite)
        {

            Debug.Log(":(");
            miniDrink.drinkSetup();
            miniDrink.scoreVal--;
            miniDrink.score.SetText(miniDrink.scoreVal + "");
        }
        else
        {
            return;
        }
    }
}
