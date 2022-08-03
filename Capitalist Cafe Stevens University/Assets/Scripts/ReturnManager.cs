using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReturnManager : MonoBehaviour
{
    public Button ReturnButton;
    // Start is called before the first frame update
    public void Return()
    {
        SceneManager.LoadScene("Title");
    }

}
