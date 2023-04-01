using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScPotion : MonoBehaviour

{
    
    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
        Debug.Log("potion consumed");
        
    }
   
}
