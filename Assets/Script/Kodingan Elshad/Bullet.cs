using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //menghancurkan peluru ketika bertabrakan dengan benda yang mempunyai tag selain "Weapon"
        if(collision.gameObject.tag != "Weapon")
        {
            Destroy(gameObject);
        }
        
    }
}
