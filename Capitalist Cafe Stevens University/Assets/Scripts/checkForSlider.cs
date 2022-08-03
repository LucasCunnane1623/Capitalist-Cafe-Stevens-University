using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForSlider : MonoBehaviour
{

    public moveSlider mover;
    public Collider2D boxCollider;
    public int starsAfterPosition;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collider)
    {
        mover.currentStarAmt = starsAfterPosition;

    }


}
