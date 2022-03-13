using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public Animator Animator;   
    public int health = 1;
    async void OnTriggerEnter2D()
   {
       int delay = 317;
       
       health --;

       Animator.SetBool("Hit", true);
       await Task.Delay(delay);
       Animator.SetBool("Hit", false);

       if (health <= 0)
       {
           Die();
       }

   }
 
   void Die()
   {
       Destroy(gameObject);
   }
}

