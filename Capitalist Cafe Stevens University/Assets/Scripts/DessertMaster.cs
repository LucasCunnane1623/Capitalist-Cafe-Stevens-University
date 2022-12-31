using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class DessertMaster : MonoBehaviour
{
    public string[] names;
    public DessertBtn[] buttons;
    public int[] indexPool, quotas, numbers;
    public float offset;
    public TMP_Text starQuality;
    public int oldGlutCount;

    
    // Start is called before the first frame update
    void Start()
    {
      
        CafeManager.foodQuality = 5;
        starQuality.SetText("food Quality " + CafeManager.foodQuality);
        this.makeIndexPool();
        for (int i=0; i < buttons.Length; i++)
            buttons[i].setText(names[indexPool[i]]);
    }

    // Update is called once per frame
    void Update()
    {
        if (CafeManager.foodQuality == 0)
        {
            CafeManager.customersServed++;
            SceneManager.LoadScene("Morning");

        }
        //Probably not needed
    }

    public void click(string buttonName)
    {
        numbers[indexOf(names, buttonName)]++;
        int newGlutCount = 0;
        bool equal = (numbers[0] == quotas[0]), glut = (numbers[0] > quotas[0]), allGE = (numbers[0] >= quotas[0]);
        for (int i = 1; equal && i < numbers.Length; i++)
            equal = (numbers[i] == quotas[i]);
        if (!equal)
        {
            for (int i = 1; i < numbers.Length; i++)
                glut = (glut || numbers[i] > quotas[i]);
            if (glut)
                for (int i=0; i < numbers.Length; i++)
                    if (numbers[i] > quotas[i])
                        newGlutCount+=(numbers[i] - quotas[i]);
            for (int i=0; allGE && i < numbers.Length; i++)
                allGE=(numbers[i] >= quotas[i]);
        }
        if (equal)
        {
            CafeManager.customersServed++;
            CafeManager.QuotaScore += CafeManager.foodQuality;
            SceneManager.LoadScene("Morning");
            Debug.Log("You won!");
            return;
        }
        else if (newGlutCount > oldGlutCount)
        {
            CafeManager.foodQuality--;
            starQuality.SetText("food Quality " + CafeManager.foodQuality);
            Debug.Log("You suck!");
            oldGlutCount = newGlutCount;
        }
        if (allGE)
        {
            CafeManager.customersServed++;
            CafeManager.QuotaScore += CafeManager.foodQuality;
            SceneManager.LoadScene("Morning");
            Debug.Log("You're shit, but done!");
        }
        //for (int i=0; i < numbers.Length; i++)
            //Debug.Log(names[i]+": "+numbers[i]+", ");
    }

    public void resetButtons()
    {
        this.makeIndexPool();
        for (int i=0; i < indexPool.Length; i++)
        {
            buttons[i].setText(names[indexPool[i]]);
            float yPos=Random.value*0.8f+0.1f;
            //Called fuckThis because you wouldn't need this variable in Java
            Vector2 fuckThis=buttons[i].GetComponent<RectTransform>().anchorMax;
            fuckThis.y=yPos+offset;
            buttons[i].GetComponent<RectTransform>().anchorMax=fuckThis;
            fuckThis=buttons[i].GetComponent<RectTransform>().anchorMin;
            fuckThis.y=yPos;
            buttons[i].GetComponent<RectTransform>().anchorMin=fuckThis;
        }
    }
    public void makeIndexPool()
    {
        for (int i=0; i < indexPool.Length; i++)
            indexPool[i]=-1;
        for (int i=0; i < indexPool.Length; i++)
        {
            int rand=Random.Range(0, indexPool.Length);
            while (contains(indexPool, rand))
                rand=Random.Range(0, indexPool.Length);
            indexPool[i]=rand;
        }
    }
    static bool contains(int[] arr, int n)
    {
        for (int i=0; i < arr.Length; i++)
            if (n == arr[i])
                return true;
        return false;
    }
    static int indexOf(string[] arr, string key)
    {
        for (int i=0; i < arr.Length; i++)
            if (key == arr[i])
                return i;
        return -1;
    }
}