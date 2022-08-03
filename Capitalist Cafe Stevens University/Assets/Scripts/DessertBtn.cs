using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DessertBtn : MonoBehaviour
{
    public DessertMaster dm;
    public TMP_Text btnTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Called when button is clicked
    public void addDessert()
    {
        dm.click(btnTxt.text);
        dm.resetButtons();
    }
    public void setText(string text)
    {
        btnTxt.SetText(text);
    }
}