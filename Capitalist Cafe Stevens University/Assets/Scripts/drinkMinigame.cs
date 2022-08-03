using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class drinkMinigame : MonoBehaviour
{
    public SpriteRenderer renderSprite;
    public Sprite[] spriteArray;
    private Sprite tempSprite;
    public GameObject location1;
    public GameObject location2;
    public GameObject location3;
    public GameObject location4;
    public GameObject location5;
    public TMP_Text test;
    public TMP_Text score;
    public Sprite correctSprite;
    public int scoreVal;
    private void Start()
    {
        drinkSetup();
    }


    public void shuffle()
    {
        for (int i = 0; i < spriteArray.Length; i++)
        {
            int randomS = Random.Range(0, spriteArray.Length);
            tempSprite = spriteArray[randomS];
            spriteArray[randomS] = spriteArray[i];
            spriteArray[i] = tempSprite;


        }

    }

    public void drinkSetup()
    {
        shuffle();
        correctSprite = spriteArray[Random.Range(0, spriteArray.Length)];
        Debug.Log(correctSprite.name);
        test.SetText("Click on " + correctSprite.name);
        changeSprite();


    }
    




    void changeSprite()
    {

        shuffle();
        location1.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
        location2.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
        location3.GetComponent<SpriteRenderer>().sprite = spriteArray[2];
        location4.GetComponent<SpriteRenderer>().sprite = spriteArray[3];
        location5.GetComponent<SpriteRenderer>().sprite = spriteArray[4];



    }
    



}
