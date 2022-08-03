using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DessertMaster : MonoBehaviour
{
    public string[] names;
    public DessertBtn[] buttons;
    public int[] indexPool, quotas, numbers;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        this.makeIndexPool();
        for (int i=0; i < buttons.Length; i++)
            buttons[i].setText(names[indexPool[i]]);
    }

    // Update is called once per frame
    void Update()
    {
        //Probably not needed
    }

    public void click(string buttonName)
    {
        numbers[indexOf(names, buttonName)]++;
        bool equal=(numbers[0] == quotas[0]), glut=(numbers[0] > quotas[0]);
        for (int i=1; equal && i < numbers.Length; i++)
            equal=(numbers[i] == quotas[i]);
        if (!equal)
            for (int i=1; i < numbers.Length; i++)
                glut=(glut || numbers[i] > quotas[i]);
        if (equal)
            Debug.Log("You won!");
        else if (glut)
            Debug.Log("You suck!");
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