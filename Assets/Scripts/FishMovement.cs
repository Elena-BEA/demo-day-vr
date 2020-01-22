using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed = 4.0f;
    private float direction;
    private Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(-90,91);
        if (direction > -10 && direction < 10)
        {
            direction = Random.Range(-45,46);
        }
        this.transform.Rotate(0, direction, 0);
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y,transform.position.z+10);
        Vector3 currPos = this.transform.position;

        transform.position += transform.forward * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Fish")
        {
            this.transform.Rotate(0,(direction* -1),0);
            transform.position -= transform.forward * Time.deltaTime * speed;
        }   
    }
    private void OnCollisionStay(Collision other) 
    {
        direction = Random.Range(-90,91);
        if (direction > -10 && direction < 10)
        {
            direction = Random.Range(-45,46);
        }
        this.transform.Rotate(0,(direction* -1),0);
    }
}
