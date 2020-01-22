using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag =="Apple" || other.gameObject.tag =="Pear" || other.gameObject.tag =="Peach")
        {
            if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) >= 0.8f || OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) >= 0.8f)
            {
                
                other.attachedRigidbody.useGravity = true;
            }
        }     
    }
}
