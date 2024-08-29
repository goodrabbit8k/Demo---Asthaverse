using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPosition;
    [SerializeField] private float moveSpeed = 10f;

    //spawning 'bullet'
    public void SpawningBullet()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPosition.transform.position, bulletSpawnPosition.transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPosition.transform.forward * moveSpeed;
    }
    
    public Vector3 GetForwardForBullet()
    {
        return bulletSpawnPosition.transform.forward;
    }

}
