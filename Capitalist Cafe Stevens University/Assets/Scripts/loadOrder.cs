using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadOrder : MonoBehaviour
{
    public Button OrderButton;

    public Collider2D CounterCollider;  
    void Start()
    {
        OrderButton.interactable = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        OrderButton.interactable = true;
    }

}
