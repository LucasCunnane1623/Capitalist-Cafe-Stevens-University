using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleSceneMaster : MonoBehaviour
{
    public Button StartButton;
    public Button SettingsButton;
    // Start is called before the first frame update
    public void PlayGame()
    {
        CafeManager.finalScore = 0;
        CafeManager.customersServed = 0;
        CafeManager.foodQuality = 5;
        CafeManager.QuotaScore = 0;
        Debug.Log("Load Level 1");
        SceneManager.LoadScene("Morning");
    }

    // Update is called once per frame
    public void PlaySettings()
    {
        Debug.Log("Load Settings");
        SceneManager.LoadScene("Settings");
    }
}
