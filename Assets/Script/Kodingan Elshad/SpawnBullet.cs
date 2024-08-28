using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPosition;    
    
    //spawning 'bullet'
    public void SpawningBullet()
    {        
        Instantiate(bulletPrefab, bulletSpawnPosition.transform.position, Quaternion.identity);
    }
    

}
