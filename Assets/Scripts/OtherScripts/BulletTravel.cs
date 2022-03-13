using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTravel : MonoBehaviour
{
    public bool isGoingRight;

    float maxSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity;
        if(this.isGoingRight){
            velocity = new Vector3( maxSpeed * Time.deltaTime,0,0);
        }else{
           velocity = new Vector3( -maxSpeed * Time.deltaTime,0,0);
        }
        

        pos += transform.localScale.x * velocity;

        transform.position = pos;
        
    }

}
