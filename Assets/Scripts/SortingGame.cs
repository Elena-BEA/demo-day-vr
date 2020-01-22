using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SortingGame : MonoBehaviour
{
   
    public int appleCount = 0;
    public Text appleText; 
    public int peachCount = 0;
    public Text peachText;
    public int pearCount = 0;
    public Text pearText;

    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Apple" && this.tag == "Crate1" )
        {
            appleCount += 1;
            appleText.text = "Apples: " + appleCount;
            Destroy(other.gameObject);

        }
        if(other.gameObject.tag == "Peach" && this.tag == "Crate2" )
        {
            peachCount += 1;
            peachText.text = "Peaches: " + peachCount;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Pear" && this.tag == "Crate3" )
        {
            pearCount += 1;
            pearText.text = "Pears: " + pearCount;
            Destroy(other.gameObject);
        }
    }
}
