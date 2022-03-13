using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public PlayerController P;
    public GameObject PlayerBulletPrefab;
    public float shootDelay = 0.25f;
    float reloadTime = 0;
    // Update is called once per frame
    void Update()
    {
        reloadTime -= Time.deltaTime;

        if(Input.GetButton("Fire1") && reloadTime <= 0)
        { 
            
            reloadTime = shootDelay;

            Vector3 temp = transform.position;

            

            var thing = Instantiate(PlayerBulletPrefab, temp, transform.rotation);
            var script = thing.GetComponent<BulletTravel>();
            if(!P.m_FacingRight){
                script.isGoingRight  = false;
            }else{
                script.isGoingRight  = true;
            }
    
        }
    }
}
