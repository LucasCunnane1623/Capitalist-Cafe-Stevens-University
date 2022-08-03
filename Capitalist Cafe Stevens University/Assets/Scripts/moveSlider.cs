using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveSlider : MonoBehaviour
{
    public KeyCode stopPaddle;
    public Rigidbody2D Rigidbody;
    public Collider2D usedCollider;
    public int sliderSpeedX, currentStarAmt;
    
    // Start is called before the first frame update
    void Start()
    {
        sliderSpeedX = Random.Range(27,35);
        
        Rigidbody.velocity = new Vector2(sliderSpeedX, 0);


    }



    public void Update()
    {

        if (Input.GetKey(stopPaddle)){
            sliderSpeedX = 0;
            Rigidbody.velocity = new Vector2(sliderSpeedX, 0);
            GiveStars();
            SceneManager.LoadScene("Morning");
        }

    }

    public void GiveStars()
    {
        Debug.Log("You cooked a " + currentStarAmt + " star Meal!");
    }


}
