using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireplaceGame : MonoBehaviour
{
    public int sticksNeeded = 3;
    public int rocksNeeded =2;
    public int sticksCollected = 0;
    public int rocksCollected = 0;
    public GameObject campfire;
    public Text stickText;
    public Text stoneText;


    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Stick")
        {
            sticksCollected++;   
            Destroy(other.gameObject);
        }  
        if (other.gameObject.tag == "Rock")
        {
            rocksCollected++;
            Destroy(other.gameObject);
        }
       
    }
    void Update()
    {
        stickText.text = "Sticks: " + sticksCollected + "/3";
        stoneText.text = "Stone: " + rocksCollected + "/2";
         if(sticksCollected == sticksNeeded && rocksCollected == rocksNeeded)
        {
            Destroy(stoneText);
            Destroy(stickText);
            campfire.SetActive(true);
            this.gameObject.SetActive(false);
        } 

    }

}
