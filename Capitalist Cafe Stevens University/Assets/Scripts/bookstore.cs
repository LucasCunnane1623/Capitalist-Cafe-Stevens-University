using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class bookstore : MonoBehaviour
{
    public int starCount;
    public TMP_Text starVal;

    // Start is called before the first frame update
    void Start()
    {
        starCount += CafeManager.playerStars;
        starVal.SetText(CafeManager.playerStars + "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
