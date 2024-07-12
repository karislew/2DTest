using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FamilyTableInt : MonoBehaviour
{
    public int minProgress=0;
    public int maxProgress=100;
    private int enemyProgress;
    private bool inTrig=false;
    public Slider progressBar;
    // Start is called before the first frame update
    void Start()
    {
        enemyProgress= 20;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inTrig)
        {
            Debug.Log("enemyprogress"+enemyProgress);
            DecProgress(10);
            //Debug.Log("Progress" + progressBar.value);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Table"))
        {
            Debug.Log(" F COLLIDEEE");
            inTrig=true;

           
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Table"))
        {
            Debug.Log(" F NOT COLLIDE");
            inTrig=false;

           
        }
    }
    void DecProgress(int progress)
    {
        //add the progress to current progress
        enemyProgress-=progress;
        progressBar.value=enemyProgress;
    }
}
