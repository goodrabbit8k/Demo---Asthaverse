using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* PERHATIAN!!!
 * Kalo mau akses logic di skrip ini
 * Public class nya extend ke class ini
 * Jangan ke MonoBehaviour
 */
public class ExecuteLogic : MonoBehaviour
{

    //logic 'Shoot'
    //setelah di extend, klean bisa make function ini tanpa perlu declare
    public void Shoot()
    {        
        SpawnBullet bullet = GetComponentInChildren<SpawnBullet>();
        bullet.SpawningBullet();
    }

}
