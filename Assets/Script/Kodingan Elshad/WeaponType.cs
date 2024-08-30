using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponType : MonoBehaviour
{
    
    public void ExecuteShooting(GameObject gameObject)
    {
        string weaponType = gameObject.gameObject.tag;
        float fireRate;
        float spawnRate;

        switch (weaponType)
        {
            case "AssaultRifle":
                fireRate = 10;
                spawnRate = 1;
                AsaultRifle(fireRate, spawnRate);
                break;
            case "Pistol":
                fireRate = 1;
                spawnRate = 1;
                Pistol(fireRate, spawnRate);
                break;
            case "Shotgun":
                fireRate = 1;
                spawnRate = 3;
                Shotgun(fireRate, spawnRate);
                break;
        };        
    }

    public void AsaultRifle(float fireRate, float spawnRate)
    {
        SpawnBullet bullet = GetComponentInChildren<SpawnBullet>();
        bullet.SpawningBullet();
        bullet.SpawningBullet();
    }

    public void Shotgun(float fireRate, float spawnRate)
    {
        SpawnBullet bullet = GetComponentInChildren<SpawnBullet>();
        bullet.SpawningBullet();
        bullet.SpawningBullet();
        bullet.SpawningBullet();
    }

    public void Pistol(float fireRate, float spawnRate)
    {
        SpawnBullet bullet = GetComponentInChildren<SpawnBullet>();
        bullet.SpawningBullet();
    }

}
