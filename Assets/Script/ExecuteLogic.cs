using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteLogic : MonoBehaviour
{

    //logic 'Shoot'
    public void Shoot()
    {        
        SpawnBullet bullet = GetComponentInChildren<SpawnBullet>();
        bullet.SpawningBullet();
    }

}
