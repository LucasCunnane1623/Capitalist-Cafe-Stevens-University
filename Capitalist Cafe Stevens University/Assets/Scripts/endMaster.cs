using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class endMaster : MonoBehaviour
{
    public TMP_Text totalScore;
    public Button playAgainButtion;

    // Start is called before the first frame update
    void Start()
    {
        totalScore.SetText("FINAL SCORE " + CafeManager.finalScore);
    }

    // Update is called once per frame
    

    public void playAgain()
    {

        SceneManager.LoadScene("Title");



    }
}
