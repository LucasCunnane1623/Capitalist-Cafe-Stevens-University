using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class endSlider : MonoBehaviour
{
    public Collider2D useThisCollider;
    public moveSlider slider;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //bouncing//
        slider.sliderSpeedX = -slider.sliderSpeedX;
        slider.GetComponent<Rigidbody2D>().velocity = new Vector2(slider.sliderSpeedX, 0);
        //no bouncing//
        //slider.currentStarAmt = 1;
        //Debug.Log("You cooked a 1 star Meal");
    }
}
